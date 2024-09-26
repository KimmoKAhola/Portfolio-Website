using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project_2.Data;
using Project_2.Infrastructure;
using Project_2.Services;

var builder = WebApplication.CreateBuilder(args);

var connectionString =
    builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder
    .Services.AddDefaultIdentity<IdentityUser>(options =>
        options.SignIn.RequireConfirmedAccount = true
    )
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

builder.Services.AddHttpClient<IWeatherService, WeatherApiService>(o =>
{
    o.BaseAddress = new Uri("https://api.open-meteo.com/v1/");
});

builder.Services.AddHttpClient<IGithubProjectService, GithubApiService>(o =>
{
    o.BaseAddress = new Uri("https://project-2-api-kimmo.azurewebsites.net/");
});

var app = builder.Build();

app.UseMigrationsEndPoint();
app.UseExceptionHandler("/Home/Error");
app.UseHsts();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
