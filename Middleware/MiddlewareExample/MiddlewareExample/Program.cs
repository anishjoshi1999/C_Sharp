var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
//app.Use() forward the request to the subsequent middleware
//middleware 1
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Hello-1");
    await next(context);
});
//middleware 2
app.Use(async (HttpContext context,RequestDelegate next)=> {
    await context.Response.WriteAsync(" Hello-2");
    await next(context);    
});
//middleware 3
//app.Run() is also called shortcircuting middleware or terminating middleware
app.Run(async (HttpContext context) => {
    await context.Response.WriteAsync(" Hello-3");
});

app.Run();
