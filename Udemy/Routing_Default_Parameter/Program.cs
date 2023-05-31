using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
//enable routing
app.UseRouting();
//creating endpoints
app.UseEndpoints(endpoints => {

    endpoints.Map("files/{filename}.{extension}", async context =>
    {
        string? fileName = Convert.ToString(context.Request.RouteValues["filename"]);
        string? extension = Convert.ToString(context.Request.RouteValues["extension"]);
        await context.Response.WriteAsync($"In files - {fileName} - {extension}");

    });
    //Default parameter {employeeName=mahendra}
    endpoints.Map("employee/profile/{employeeName=mahendra}", async (context) =>
    {
        string? employeeName = Convert.ToString(context.Request.RouteValues["employeeName"]);
        await context.Response.WriteAsync($"In employee/profile - {employeeName}");
    });
    //Eg: products/details/{id}
    endpoints.Map("products/details/{id=1}",async context =>
    {
       int id =  Convert.ToInt32(context.Request.RouteValues["id"]);
       await context.Response.WriteAsync($"Products details - {id}");
    });
});


app.Run(async context => {
    await context.Response.WriteAsync($"Request received at {context.Request.Path}");

});



app.Run();
