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

    //endpoints.Map("employee/profile/{employeeName=mahendra}", async (context) =>
    //{
    //    string? employeeName = Convert.ToString(context.Request.RouteValues["employeeName"]);
    //    await context.Response.WriteAsync($"In employee/profile - {employeeName}");
    //});

    //It accepts 3 characters minimum

    //endpoints.Map("employee/profile/{employeeName:minlength(3)=mahendra}", async (context) =>
    //{
    //    string? employeeName = Convert.ToString(context.Request.RouteValues["employeeName"]);
    //    await context.Response.WriteAsync($"In employee/profile - {employeeName}");
    //});

    //It accepts minimum 3 characters and maximum 7 characters
    //shortform of this process is use :length(3,7)
    endpoints.Map("employee/profile/{employeeName:minlength(3):maxlength(7)=mahendra}",async (context)=>
    {
        string? employeeName = Convert.ToString(context.Request.RouteValues["employeeName"]);
        await context.Response.WriteAsync($"In employee/profile - {employeeName}");
    });


    //Eg: products/details/{id}
    //Inorder to provide restrictions on parameters we use constraints
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
    //Eg: daily-digest-report/{reportdate}
    endpoints.Map("daily-digest-report/{reportdate:datetime}",async context => {
       DateTime reportDate = Convert.ToDateTime(context.Request.RouteValues["reportdate"]);
        await context.Response.WriteAsync($"In daily-digest-report-{reportDate.ToShortDateString()}");
    });
    //Eg: cities/cityid
    endpoints.Map("cities/{cityid:guid}",async context => {
       Guid cityId = Guid.Parse(Convert.ToString(context.Request.RouteValues["cityid"])!);
        await context.Response.WriteAsync($"City Information - {cityId}");
    
    });
    //sales-report/2030/apr
    endpoints.Map("sales-report/{year:int:min(1900)}/{month:regex(^(apr|jul|oct|jan)$)}",async context =>
    {
        int year = Convert.ToInt32(context.Request.RouteValues["year"]);
        string? month = Convert.ToString(context.Request.RouteValues["month"]);
        await context.Response.WriteAsync($"sales report - {year} - {month}");

    });
});


app.Run(async context => {
    await context.Response.WriteAsync($"Request received at {context.Request.Path}");

});



app.Run();
