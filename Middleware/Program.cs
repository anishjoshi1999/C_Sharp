var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
//app.Run() does not forward the request to the subsequent request.
//Middleware1
app.Use(async (HttpContext context,RequestDelegate next) =>
{
    await context.Response.WriteAsync("Hello Before\n");
    await next(context);
    await context.Response.WriteAsync("Hello After\n");
});
//Middleware2
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Hello 1 Before\n");
    await next(context);
    await context.Response.WriteAsync("Hello 1 After\n");
});
//Middleware3
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Hello 2 Before\n");
    await next(context);
    await context.Response.WriteAsync("Hello 2 After\n");
});
//Middleware4
app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Hello 3\n");
});
app.Run();

