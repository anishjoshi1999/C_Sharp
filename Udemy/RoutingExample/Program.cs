var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Use(async (context, next) =>
{
    Microsoft.AspNetCore.Http.Endpoint endpoint = context.GetEndpoint();
    await next(context);
});
//enable routing
app.UseRouting();

app.Use(async (context, next) =>
{
    Microsoft.AspNetCore.Http.Endpoint endpoint = context.GetEndpoint();
    await next(context);
});
app.UseEndpoints(endpoints =>
{
    //add your end points
    //endpoints.Map("/map1",async (context)=>
    //{
    //    await context.Response.WriteAsync("In Map 1");
    //});
    endpoints.MapGet("/map1", async (context) =>
    {
        await context.Response.WriteAsync("In Map 1");
    });
    //endpoints.Map("/map2", async (context) =>
    //{
    //    await context.Response.WriteAsync("In Map 2");
    //});
    endpoints.MapPost("/map2", async (context) =>
    {
        await context.Response.WriteAsync("In Map 2");
    });
});

app.Run();
