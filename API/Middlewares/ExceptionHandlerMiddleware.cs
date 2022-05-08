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
                await HandleGlobalExceptionAsync(context, exception.StatusCode, exception.Message);
            }
            catch(Exception e)
            {
                await HandleGlobalExceptionAsync(context, errorBody: e.Message);
            }
        }

        private static async Task HandleGlobalExceptionAsync(
            HttpContext context, 
            HttpStatusCode statusCode = HttpStatusCode.InternalServerError,
            string errorBody = "Unknown error has occured")
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)statusCode;
            await context.Response.WriteAsync(JsonConvert.SerializeObject(errorBody));
        }
    }
}
