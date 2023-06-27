var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//enable routing
app.UseRouting();
// Middleware to retrieve the current endpoint being executed in the pipeline
app.Use(async (context, next) =>
{
    Microsoft.AspNetCore.Http.Endpoint endpoint = context.GetEndpoint(); // Get the current endpoint
    await next(context); // Pass the request to the next middleware component
});

//creting end points
app.UseEndpoints(endpoints =>
{
    //add your end points
    //by default the map function runs for both get and post requests
    endpoints.Map("map1", async (context) =>
    {
        await context.Response.WriteAsync("In Map 1");
    });
    //be specific for hitting a specific http verbs
    endpoints.MapGet("map3", async (context) =>
    {
        await context.Response.WriteAsync("Hitting the map3 using get request only");
    });
    //status code 405 means url matches but the http verb doesnot match
    endpoints.MapPost("map4", async (context) =>
    {
        await context.Response.WriteAsync("Hitting the map4 using post request only");
    });
    endpoints.Map("map2", async (context) =>
     {
         await context.Response.WriteAsync("In Map 2");
     });
});
//endpoints other than map1 and map2
app.Run(async context =>
{
    await context.Response.WriteAsync("Something");
});

app.Run();
