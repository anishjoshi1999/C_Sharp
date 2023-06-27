using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
// This code is for configuring endpoints and routing in an ASP.NET Core application.
// Enable routing
app.UseRouting();
// Configure endpoints
app.UseEndpoints(endpoints => {

    // Map a route for accessing files
    endpoints.Map("files/{filename}.{extension}", async context =>
    {
        string? fileName = Convert.ToString(context.Request.RouteValues["filename"]);
        string? extension = Convert.ToString(context.Request.RouteValues["extension"]);
        await context.Response.WriteAsync($"In files - {fileName} - {extension}");
    });

    // Map a route for accessing employee profiles
    // The default parameter is set to "mahendra"
    endpoints.Map("employee/profile/{employeeName=mahendra}", async (context) =>
    {
        string? employeeName = Convert.ToString(context.Request.RouteValues["employeeName"]);
        await context.Response.WriteAsync($"In employee/profile - {employeeName}");
    });

    // Map a route for accessing product details
    // The parameter "id" is optional and can be omitted
    endpoints.Map("products/details/{id?}", async context =>
    {
        if (context.Request.RouteValues.ContainsKey("id"))
        {
            int id = Convert.ToInt32(context.Request.RouteValues["id"]);
            await context.Response.WriteAsync($"Products details - {id}");
        }
        else
        {
            await context.Response.WriteAsync($"Products details - id is not supplied");
        }
    });

});
// Handle other requests
app.Run(async context => {
    await context.Response.WriteAsync($"Request received at {context.Request.Path}");
});

// Start the application
app.Run();