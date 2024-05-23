using Microsoft.EntityFrameworkCore;
using Project_StarWarsAPI_MVC;
using Project_StarWarsAPI_MVC.Data;
using Project_StarWarsAPI_MVC.Interfaces;
using Project_StarWarsAPI_MVC.Models.Swapi;
using Project_StarWarsAPI_MVC.Repositories;

var builder = WebApplication.CreateBuilder(args);

ApplicationSettings settings = builder.Configuration.GetSection(nameof(ApplicationSettings)).Get<ApplicationSettings>();

builder.Services.AddDbContext<SWContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SWContext") ?? throw new InvalidOperationException("Connection string 'SWContext' not found.")));

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ISWAPIRepository, SwapiRepository>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider; 
    
    try
    {
        SeedData.Initialize(services);
    }
    catch (Exception ex)
    {
        throw;
    }
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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