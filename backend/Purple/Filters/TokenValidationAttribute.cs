using Business.Constant.Messages;
using Core.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Purple.Filters
{
    /// <summary>
    /// Jwt token verify attiribute
    /// </summary>
    public class TokenValidationAttribute : Attribute, IActionFilter
    {
        /// <summary>
        /// Finish method
        /// </summary>
        /// <param name="context"></param>
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine(SuccessMessages.TokenVerify);
        }

        /// <summary>
        /// Start method
        /// </summary>
        /// <param name="context"></param>
        public async void OnActionExecuting(ActionExecutingContext context)
        {
            AllowAnonymousFilter allowAnonymousFilter = (AllowAnonymousFilter)context.Filters.FirstOrDefault(x => x.GetType() == typeof(AllowAnonymousFilter));

            if (allowAnonymousFilter != null)
            {
                return;
            }

            StringValues bearer = new StringValues();

            try
            {
                var userId = Convert.ToInt32(context.HttpContext.User.Claims.FirstOrDefault().Value);
                context.HttpContext.Request.Headers.TryGetValue("Authorization", out bearer);
                if (userId <= 0 || bearer.ToString().Split(' ')[1] == null)
                {
                    await UnAuthorized(context);
                    return;
                }
            }
            catch (Exception)
            {
                await UnAuthorized(context);
                return;
            }

            if (allowAnonymousFilter == null)
            {
                context.HttpContext.Request.Headers.TryGetValue("Authorization", out bearer);

                if (bearer == "{}" || String.IsNullOrEmpty(bearer))
                {
                    await UnAuthorized(context);
                }
            }
        }

        public async Task UnAuthorized(ActionExecutingContext context)
        {
            ErrorResult errorResult = new ErrorResult();
            errorResult.Message = ErrorMessages.Unauthorized;
            context.Result = new UnauthorizedObjectResult(errorResult);
            await context.Result.ExecuteResultAsync(context);
        }
    }
}
