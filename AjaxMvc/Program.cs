var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
//builder.Services.AddSession();

// Hämta connection-strängen från AppSettings.json
// Registrera Context-klassen för dependency injection


var app = builder.Build();
//app.UseSession();
app.UseRouting();
app.UseEndpoints(o => o.MapControllers());


app.Run();