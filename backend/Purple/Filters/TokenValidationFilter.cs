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
    public class TokenValidationFilter : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            AllowAnonymousFilter allowAnonymousFilter = (AllowAnonymousFilter)context.Filters.FirstOrDefault(x => x.GetType() == typeof(AllowAnonymousFilter));

            if (allowAnonymousFilter != null)
            {
                return;
            }

            string apiPath = context.HttpContext.Request.Path;

            StringValues bearer = new StringValues();

            try
            {
                var userId = Convert.ToInt32(context.HttpContext.User.Identity.Name);
                context.HttpContext.Request.Headers.TryGetValue("Authorization", out bearer);
                if (userId <= 0 || bearer.ToString().Split(' ')[1] == null)
                {
                    UnAuthorized(context);
                    return;
                }
            }
            catch (Exception)
            {
                UnAuthorized(context);
                return;
            }

            if (allowAnonymousFilter == null)
            {
                context.HttpContext.Request.Headers.TryGetValue("Authorization", out bearer);

                if (bearer == "{}" || String.IsNullOrEmpty(bearer))
                {
                    UnAuthorized(context);
                    return;
                }
            }
        }

        public async void UnAuthorized(ActionExecutingContext context)
        {
            ErrorResult errorResult = new ErrorResult();
            errorResult.Message = ErrorResponseMessage.Unauthorized;
            context.Result = new UnauthorizedObjectResult(errorResult);
            await context.Result.ExecuteResultAsync(context);
        }
    }
}
