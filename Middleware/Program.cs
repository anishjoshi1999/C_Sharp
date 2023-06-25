using Middleware;
var builder = WebApplication.CreateBuilder(args);
// This code registers the MyCustomMiddleware class as a transient service with the dependency injection container.
// Transient means that a new instance of MyCustomMiddleware will be created each time it is requested.
// This middleware can be used to handle specific tasks or add custom functionality to the application's request pipeline.
builder.Services.AddTransient<MyCustomMiddleware>();
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
// This code adds the MyCustomMiddleware to the application's request pipeline.
// UseMiddleware<MyCustomMiddleware>() ensures that each request passing through the pipeline will be handled by an instance of MyCustomMiddleware.
// This middleware can be used to perform certain operations or add custom behavior to the request processing flow.
app.UseMiddleware<MyCustomMiddleware>();
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

