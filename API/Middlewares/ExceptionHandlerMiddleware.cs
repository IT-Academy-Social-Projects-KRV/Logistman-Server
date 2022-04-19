using Core.Exceptions;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;

namespace API.Middlewares
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch(HttpException exception)
            {
                await HandleGlobalExceptionAsync(context, exception.StatusCode, new { error = exception.Message });
            }
            catch (Exception)
            {
                await HandleGlobalExceptionAsync(context);
                return;
            }
        }

        private static async Task HandleGlobalExceptionAsync(
            HttpContext context, 
            HttpStatusCode statusCode = HttpStatusCode.InternalServerError,
            object errorBody = null)
        {
            errorBody ??= new { error = "Unknown error has occured" };
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)statusCode;
            await context.Response.WriteAsync(JsonConvert.SerializeObject(errorBody));
        }
    }
}
