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

        var project = new GithubProject
        {
            Title = "Blackjack",
            Description = "Good blackjack game",
            Content = "Play until you lose all your money",
            Skills = ["C#", "Console.WriteLine"],
            ProjectURL = new Uri("https://github.com/KimmoKAhola/Blackjack"),
            ImageURL = new Uri(
                "https://images.rawpixel.com/image_social_landscape/cHJpdmF0ZS9sci9pbWFnZXMvd2Vic2l0ZS8yMDIzLTA5L3JtNzA1ZGVzaWduLWVmZmVjdC10bnQtMDFlLmpwZw.jpg"
            )
        };

        var project2 = new GithubProject
        {
            Title = "Babun Bank",
            Description = "MVC bank project",
            Content = "Can display users, accounts, customers. Login as admin, cashier.",
            Skills = ["C#", "ASP.NET", "MVC", "RESTful API"],
            ProjectURL = new Uri("https://github.com/KimmoKAhola/BabunBank"),
            ImageURL = new Uri(
                "https://images.rawpixel.com/image_social_landscape/cHJpdmF0ZS9sci9pbWFnZXMvd2Vic2l0ZS8yMDIzLTA5L3JtNzA1ZGVzaWduLWVmZmVjdC10bnQtMDFlLmpwZw.jpg"
            )
        };
        context.Add(project);
        context.Add(project2);
        await context.SaveChangesAsync();
    }
}
