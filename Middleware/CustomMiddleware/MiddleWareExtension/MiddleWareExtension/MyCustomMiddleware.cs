using System.Runtime.CompilerServices;

namespace MiddleWareExtension
{
        public class MyCustomMiddleware : IMiddleware
        {
            public async Task InvokeAsync(HttpContext context, RequestDelegate next)
            {
                await context.Response.WriteAsync("\nMy Custom Middleware - Starts");
                await next(context);
                await context.Response.WriteAsync("\nMy Custom Middleware - Ends");
            }
        }
    public static class CustomMiddlewareExtension
    {
        public static IApplicationBuilder UseMyCustomMiddleware(this IApplicationBuilder app)
        {
           return app.UseMiddleware<MyCustomMiddleware>();

        }
    }

}
