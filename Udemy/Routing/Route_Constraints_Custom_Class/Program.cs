using Microsoft.AspNetCore.Http;
using Route_Constraints_Custom_Class.CustomConstraints;
var builder = WebApplication.CreateBuilder(args);
// This code adds a custom route constraint to the ASP.NET Core application's routing configuration.
builder.Services.AddRouting(options => {
    // Add a custom route constraint named "months" and specify the corresponding constraint type as "MonthsCustomConstrain".
    options.ConstraintMap.Add("months", typeof(MonthsCustomConstraints));
});
var app = builder.Build();

// Enable routing
app.UseRouting();
// Configure endpoints
app.UseEndpoints(endpoints => {
    // Map a route for accessing files
    // files/readme.md
    endpoints.Map("files/{filename}.{extension}", async context =>
    {
        string? fileName = Convert.ToString(context.Request.RouteValues["filename"]);
        string? extension = Convert.ToString(context.Request.RouteValues["extension"]);
        await context.Response.WriteAsync($"In files - {fileName} - {extension}");
    });

    // Map a route for accessing employee profiles
    // Apply constraints for minimum length, maximum length, and default value
    // employee/profile/johndoe
    endpoints.Map("employee/profile/{employeeName:minlength(3):maxlength(10)=mahendra}", async (context) =>
    {
        string? employeeName = Convert.ToString(context.Request.RouteValues["employeeName"]);
        await context.Response.WriteAsync($"In employee/profile - {employeeName}");
    });

    // Map a route for accessing product details
    // Apply a constraint to ensure the parameter is an integer
    // products/details/123
    endpoints.Map("products/details/{id:int?}", async context =>
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

    // Map a route for accessing daily digest reports
    // Apply a constraint to ensure the parameter is a valid DateTime value
    // daily-digest-report/2023-06-27
    endpoints.Map("daily-digest-report/{reportdate:datetime}", async context =>
    {
        DateTime reportDate = Convert.ToDateTime(context.Request.RouteValues["reportdate"]);
        await context.Response.WriteAsync($"In daily-digest-report - {reportDate.ToShortDateString()}");
    });

    // Map a route for accessing city information
    // Apply a constraint to ensure the parameter is a valid GUID value
    // cities/6f59dbb0-8a4f-4f4a-b68c-dbf603f9a1f1
    endpoints.Map("cities/{cityid:guid}", async context =>
    {
        Guid cityId = Guid.Parse(Convert.ToString(context.Request.RouteValues["cityid"])!);
        await context.Response.WriteAsync($"City Information - {cityId}");
    });

    // Map a route for accessing sales reports
    // Apply constraints for the year and month parameters using min, max, and regex
    // sales-report / 2023 / jan
    endpoints.Map("sales-report/{year:int:min(1900)}/{month:months}", async context =>
    {
        int year = Convert.ToInt32(context.Request.RouteValues["year"]);
        string? month = Convert.ToString(context.Request.RouteValues["month"]);
        await context.Response.WriteAsync($"Sales report - {year} - {month}");
    });

});


app.Run(async context => {
    await context.Response.WriteAsync($"Request received at {context.Request.Path}");

});



app.Run();
