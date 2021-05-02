using Core.Results;
using Core.Utilities.Connection;
using Core.Utilities.Middleware.Models;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext httpContext,Exception ex)
        {
            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            if(ex.GetType() == typeof(ValidationException))
            {
                return httpContext.Response.WriteAsync(JsonConvert.SerializeObject(new ValidationErrorDetail()
                {
                    Errors = ((ValidationException)ex).Errors.Select(x => x.ErrorMessage).ToList(),
                    Success = false,
                    StatusCode = (int)HttpStatusCode.BadRequest
                }));
            }

            return httpContext.Response.WriteAsync(JsonConvert.SerializeObject(new ErrorDetail()
            {
                Message = ex.Message,
                Success = false,
                StatusCode = httpContext.Response.StatusCode
            }));
        }
    }
}
