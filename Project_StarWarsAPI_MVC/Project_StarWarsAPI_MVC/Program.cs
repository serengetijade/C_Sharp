using Microsoft.EntityFrameworkCore;
using Project_StarWarsAPI_MVC.Data;
using Project_StarWarsAPI_MVC.Models;
using Microsoft.Extensions.DependencyInjection;
using Project_StarWarsAPI_MVC.Models.SWAPI_Resources;
using Project_StarWarsAPI_MVC.Models.Content;

var builder = WebApplication.CreateBuilder(args);
//Connect the app to the SQL server: 
builder.Services.AddDbContext<SWContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SWContext") ?? throw new InvalidOperationException("Connection string 'SWContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

//Seed the DB within a using statement when done, it is collected by garbage cleaner:
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;   
    SeedData.Initialize(services);
    SeedData.GetRandomRecord(services);
}

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
