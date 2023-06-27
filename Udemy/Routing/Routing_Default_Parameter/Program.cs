using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Enable routing
app.UseRouting();

// Configure endpoints
app.UseEndpoints(endpoints => {
    // Map route for serving files
    endpoints.Map("files/{filename}.{extension}", async context =>
    {
        string? fileName = Convert.ToString(context.Request.RouteValues["filename"]);
        string? extension = Convert.ToString(context.Request.RouteValues["extension"]);
        await context.Response.WriteAsync($"In files - {fileName} - {extension}");
    });

    // Map route for employee profiles with a default parameter
    endpoints.Map("employee/profile/{employeeName=mahendra}", async (context) =>
    {
        string? employeeName = Convert.ToString(context.Request.RouteValues["employeeName"]);
        await context.Response.WriteAsync($"In employee/profile - {employeeName}");
    });

    // Map route for product details with an optional ID parameter
    endpoints.Map("products/details/{id=1}", async context =>
    {
        int id = Convert.ToInt32(context.Request.RouteValues["id"]);
        await context.Response.WriteAsync($"Products details - {id}");
    });
});

// Default request handling
app.Run(async context => {
    await context.Response.WriteAsync($"Request received at {context.Request.Path}");
});

// Start the application
app.Run();
