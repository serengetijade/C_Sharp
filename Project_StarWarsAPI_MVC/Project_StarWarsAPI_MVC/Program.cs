using Microsoft.EntityFrameworkCore;
using Project_StarWarsAPI_MVC;
using Project_StarWarsAPI_MVC.Data;
using Project_StarWarsAPI_MVC.Helpers;
using Project_StarWarsAPI_MVC.Interfaces;
using Project_StarWarsAPI_MVC.Repositories;

var builder = WebApplication.CreateBuilder(args);

ApplicationSettings settings = builder.Configuration.GetSection(nameof(ApplicationSettings)).Get<ApplicationSettings>();

builder.Services.AddAutoMapper(cfg =>
{
    cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly; //Map properties with public or internal getters
    cfg.AddProfile<AutoMapperProfile>();
});

builder.Services.AddDbContext<SWContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SWContext") ?? throw new InvalidOperationException("Connection string 'SWContext' not found.")));

builder.Services.AddControllersWithViews();

builder.Services.AddHttpContextAccessor();
builder.Services.AddHttpClient(nameof(SwapiRepository), cfg =>{
    cfg.BaseAddress = new Uri(settings.Swapi.ApiBaseUri);
    });

builder.Services.AddScoped<ISWAPIRepository, SwapiRepository>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider; 
    
    try
    {
        SeedData.Initialize(services);
    }
    catch (Exception)
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