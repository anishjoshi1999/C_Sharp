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
    //Optional Paramter
    //"?" indicates an optional parameter.
    //That means, it matches with a value or empty value also.
    endpoints.Map("products/details/{id?}", async context =>
    {
        if (context.Request.RouteValues.ContainsKey("id"))
        {
            int id = Convert.ToInt32(context.Request.RouteValues["id"]);
            await context.Response.WriteAsync($"Products details - {id}");
        }else
        {
            await context.Response.WriteAsync($"Products details - id is not supplied");
        }
        
    });
});


app.Run(async context => {
    await context.Response.WriteAsync($"Request received at {context.Request.Path}");

});



app.Run();
