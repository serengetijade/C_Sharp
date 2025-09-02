using SwapiWebApp;
using SwapiWebApp.Data;
using SwapiWebApp.Interfaces;
using SwapiWebApp.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<SwapiSettings>(builder.Configuration.GetSection("SwapiSettings"));
var swapiSettings = builder.Configuration.GetSection(nameof(SwapiSettings)).Get<SwapiSettings>();

builder.Services.AddControllersWithViews();

builder.Services.AddHttpContextAccessor();
builder.Services.AddHttpClient("SwapiClient", client =>
{
    if (string.IsNullOrEmpty(swapiSettings?.BaseUrl))
    {
        throw new InvalidOperationException("SwapiSettings.BaseUrl is not configured properly.");
    }
    client.BaseAddress = new Uri(swapiSettings.BaseUrl);
    client.DefaultRequestHeaders.Add("Accept", "application/json");
});

builder.Services.AddScoped<ISwapiRepository, ISwapiRepository>();
builder.Services.AddScoped<ISwapiService, ISwapiService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
	//Add a custom error page
	app.UseExceptionHandler("/Home/Error");
	app.UseHsts();
}

using (var scope = app.Services.CreateScope())
{
	var services = scope.ServiceProvider;
	try
	{
		SeedData.Initialize(services);
	}
	catch (Exception ex)
	{
		throw new Exception(ex.Message, ex.InnerException);
	}
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();