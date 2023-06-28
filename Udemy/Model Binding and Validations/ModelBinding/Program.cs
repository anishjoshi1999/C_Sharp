var builder = WebApplication.CreateBuilder(args);
//adds all the controller classes as services
builder.Services.AddControllers();
var app = builder.Build();
app.UseStaticFiles();
app.MapControllers();

app.Run();
