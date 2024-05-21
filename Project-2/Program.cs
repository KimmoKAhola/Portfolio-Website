using System.Net.Http.Headers;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project_2;
using Project_2.Controllers;
using Project_2.Data;
using Project_2.Infrastructure;
using Project_2.Models;
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
    // https://api.openweathermap.org/data/2.5/
    o.BaseAddress = new Uri("https://api.openweathermap.org/data/2.5/");
    o.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
});

builder.Services.AddHttpClient<IHttpService<GithubProjectModel>, GithubApiService>(o =>
{
    o.BaseAddress = new Uri("https://kimmo-github-api.azurewebsites.net/");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
