using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project_2.Data;
using Project_2.Infrastructure;
using Project_2.Models.ViewModels.GithubProjects;
using Project_2.Models.ViewModels.Weather;
using Project_2.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

var apiKey = builder.Configuration.GetSection("ApiSettings")["Key"];

builder.Services.AddHttpClient<IHttpService<Root>, WeatherApiService>(o =>
{
    o.BaseAddress = new Uri("https://api.openweathermap.org/data/2.5/");
    o.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
});

builder.Services.AddHttpClient<IHttpService<GithubProjectModel>, GithubApiService>(o =>
{
    o.BaseAddress = new Uri("https://kimmo-github-api.azurewebsites.net/");
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
