using DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;
using ProjectAPI;
using ProjectAPI.Infrastructure.AutomapperConfigurations;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ProjectDbContext>(o =>
{
    o.UseSqlServer(connectionString);
});
builder.Services.AddTransient<DataInitializer>();

var app = builder.Build();

await using (var scope = app.Services.CreateAsyncScope())
{
    await scope.ServiceProvider.GetService<DataInitializer>()!.SeedData();
}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
