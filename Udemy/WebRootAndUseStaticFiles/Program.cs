var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseStaticFiles();

//app.UseRouting();
//app.UseEndpoints(endpoints =>);
//app.MapGet(); is a short form
//app.MapGet("/", () => "Hello World!");
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.Map("/",async context =>
    {
        await context.Response.WriteAsync("Hello");
    });
});

app.Run();
