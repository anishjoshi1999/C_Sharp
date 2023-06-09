using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting(); // Enable routing middleware

app.UseEndpoints(endpoints => {
    // Map endpoint for "files/{filename}.{extension}"
    endpoints.Map("files/{filename}.{extension}", async context =>
    {
        string? fileName = Convert.ToString(context.Request.RouteValues["filename"]);
        string? extension = Convert.ToString(context.Request.RouteValues["extension"]);
        await context.Response.WriteAsync($"In files - {fileName} - {extension}");
    });

    // Map endpoint for "employee/profile/{employeeName}"
    endpoints.Map("employee/profile/{employeeName}", async context =>
    {
        string? employeeName = Convert.ToString(context.Request.RouteValues["employeeName"]);
        await context.Response.WriteAsync($"In employee/profile - {employeeName}");
    });
});

app.Run(async context => {
    await context.Response.WriteAsync($"Request received at {context.Request.Path}");
});

app.Run();
