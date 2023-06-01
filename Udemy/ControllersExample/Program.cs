using ControllersExample.Controllers;

var builder = WebApplication.CreateBuilder(args);
//adds all the controller classes as services
builder.Services.AddControllers();
//builder.Services.AddTransient<HomeController>();
var app = builder.Build();
app.UseStaticFiles();
app.MapControllers();

app.Run();
