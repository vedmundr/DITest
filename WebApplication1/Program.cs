using WebApplication1;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddTransient<IClass, Class>();
builder.Services.AddScoped<IMyRandomClass, MyRandomClass>();
var app = builder.Build();
int xxx;
using (var serviceScope = app.Services.CreateScope())
{
    var services = serviceScope.ServiceProvider;

    var myDependency = services.GetRequiredService<IMyRandomClass>();
    StartClass classRandome = new(myDependency);
    xxx = classRandome.MethodRun();
}

app.MapGet("/", () => "Hello World! "+xxx);

app.Run();
