var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseStaticFiles();

// Configure routing and endpoints
// app.UseRouting();
// app.UseEndpoints(endpoints =>);
// app.MapGet(); is a short form

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    // Map the root endpoint ("/") to return "Hello"
    endpoints.Map("/", async context =>
    {
        await context.Response.WriteAsync("Hello");
    });
});

app.Run();
