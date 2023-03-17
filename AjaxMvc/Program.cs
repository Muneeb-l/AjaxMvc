var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
//builder.Services.AddSession();

// H�mta connection-str�ngen fr�n AppSettings.json
// Registrera Context-klassen f�r dependency injection


var app = builder.Build();
//app.UseSession();
app.UseRouting();
app.UseEndpoints(o => o.MapControllers());


app.Run();