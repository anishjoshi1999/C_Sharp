using CustomMiddleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<MyCustomMiddleware>();
var app = builder.Build();
//app.Use() forward the request to the subsequent middleware
//middleware 1
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("\nHello-1");
    await next(context);
});
//middleware 2
app.UseMiddleware<MyCustomMiddleware>();
//middleware 3
//app.Run() is also called shortcircuting middleware or terminating middleware
app.Run(async (HttpContext context) => {
    await context.Response.WriteAsync("\nHello-3");
});

app.Run();