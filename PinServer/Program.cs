using PinServer;
using PinServer.Models;

Globals.SeedData = new List<RaspberryPi>() {
    new RaspberryPi{Id=1, Name="Test1", Pin1=4, Pin2=5, Pin3=2},
    new RaspberryPi{Id=2, Name="Test2", Pin1=7, Pin2=5, Pin3=5},
    new RaspberryPi{Id=3, Name="Test3", Pin1=3, Pin2=4, Pin3=2}
};
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
