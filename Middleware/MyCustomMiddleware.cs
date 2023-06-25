namespace Middleware
{
    public class MyCustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("My First Custom Middleware - Starts\n");
            await next(context);
            await context.Response.WriteAsync("My First Custom Middleware - Ends\n");

        }
    }
}
