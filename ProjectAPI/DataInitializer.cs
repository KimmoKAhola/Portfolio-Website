using DataAccessLayer.Data;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectAPI;

public class DataInitializer(ProjectDbContext context)
{
    public async Task SeedData()
    {
        await context.Database.MigrateAsync();
        if (context.Projects.Any())
            return;

        var project = new Project
        {
            Title = "Hej",
            Description = "HEEEJ",
            Content = "HEEEEEEEJ"
        };
        context.Add(project);
        await context.SaveChangesAsync();
    }
}
