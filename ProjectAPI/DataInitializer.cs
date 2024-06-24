using DataAccessLayer.Data;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectAPI;

public class DataInitializer(ProjectDbContext context)
{
    public async Task SeedData()
    {
        try
        {
            await context.Database.MigrateAsync();
        }
        catch { }
        if (context.Projects.Any())
            return;

        var cashierSystem = new GithubProject
        {
            Title = "Cashier Console App",
            Description =
                "A cashier management console application. Built with heavy focus on OOP and design pattern principles.",
            Content = "",
            Skills = ["C#"],
            ProjectURL = new Uri("https://github.com/KimmoKAhola/KassaSystemet"),
            ImageURL = new Uri(
                "https://kimmoprojectstorage.blob.core.windows.net/project/cashier.png"
            )
        };

        var blackjack = new GithubProject
        {
            Title = "Blackjack",
            Description = "A blackjack game with heavy focus on OOP. Built using Console.Write.",
            Content = "Play until you lose all your money",
            Skills = ["C#"],
            ProjectURL = new Uri("https://github.com/KimmoKAhola/Blackjack"),
            ImageURL = new Uri(
                "https://kimmoprojectstorage.blob.core.windows.net/project/blackjack.png"
            )
        };

        var hotel = new GithubProject
        {
            Title = "Hotel Console App",
            Description = "A hotel managament console application. Utilizes entity framework.",
            Content = "",
            Skills = ["C#", "MS-SQL", "Entity Framework"],
            ProjectURL = new Uri("https://github.com/KimmoKAhola/HotelApp"),
            ImageURL = new Uri(
                "https://kimmoprojectstorage.blob.core.windows.net/project/hotel.png"
            )
        };

        var silicon = new GithubProject
        {
            Title = "Silicon Design",
            Description = "A website designed with React and SCSS.",
            Content = "",
            Skills = ["HTML", "Figma", "CSS", "SCSS", "React", "Javascript"],
            ProjectURL = new Uri("https://github.com/KimmoKAhola/Silicon-Kimmo-Ahola"),
            ImageURL = new Uri(
                "https://kimmoprojectstorage.blob.core.windows.net/project/silicon.webp"
            ),
            LiveDemoURL = new Uri("https://silicon-kimmo-ahola.vercel.app/")
        };

        var bank = new GithubProject
        {
            Title = "Babun Bank",
            Description = "A banking application built with ASP.NET MVC.",
            Content = "",
            Skills =
            [
                "C#",
                "ASP.NET",
                "MVC",
                "RESTful API",
                "MS-SQL",
                "Entity Framework",
                "HTML",
                "CSS",
                "Javascript"
            ],
            ProjectURL = new Uri("https://github.com/KimmoKAhola/BabunBank"),
            ImageURL = new Uri(
                "https://kimmoprojectstorage.blob.core.windows.net/project/bank.webp"
            ),
            LiveDemoURL = new Uri("https://babunbank.azurewebsites.net/")
        };

        var api = new GithubProject
        {
            Title = "RESTful API",
            Description =
                "A RESTful API for the Babun Bank. Utilizes JWT tokenization and swagger documentation.",
            Content = "",
            Skills =
            [
                "C#",
                "ASP.NET",
                "MVC",
                "RESTful API",
                "MS-SQL",
                "Entity Framework",
                "JWT",
                "OAUTH2",
                "OPEN API",
                "Swagger"
            ],
            ProjectURL = new Uri("https://github.com/KimmoKAhola/BabunBank"),
            ImageURL = new Uri(
                "https://kimmoprojectstorage.blob.core.windows.net/project/api.webp"
            ),
            LiveDemoURL = new Uri("https://babun-api.azurewebsites.net/swagger/index.html")
        };

        var portfolio = new GithubProject
        {
            Title = "web portfolio",
            Description = "Retro inspired web portfolio",
            Content = "",
            Skills = ["C#", "ASP.NET", "Swagger", "Entity Framework", "MS-SQL"],
            ImageURL = new Uri(
                "https://kimmoprojectstorage.blob.core.windows.net/project/portfolio.webp"
            ),
            ProjectURL = new Uri("https://github.com/KimmoKAhola/Project-2")
        };

        context.Add(cashierSystem);
        context.Add(blackjack);
        context.Add(hotel);
        context.Add(silicon);
        context.Add(bank);
        context.Add(api);
        context.Add(portfolio);

        await context.SaveChangesAsync();
    }
}
