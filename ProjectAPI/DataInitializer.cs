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
            Description = "",
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
            Description = "Good blackjack game",
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
            Description = "",
            Content = "",
            Skills = ["C#", "MS-SQL", "Entity Framework"],
            ProjectURL = new Uri("https://github.com/KimmoKAhola/HotelApp"),
            ImageURL = new Uri(
                "https://kimmoprojectstorage.blob.core.windows.net/project/hotel.png"
            )
        };

        // var project1 = new GithubProject
        // {
        //     Title = "Console App",
        //     Description = "",
        //     Content = "",
        //     Skills = ["C#", "MS-SQL", "Entity Framework", "Design patterns"],
        //     ProjectURL = new Uri("https://github.com/KimmoKAhola/Projekt_1"),
        //     ImageURL = new Uri(
        //         "https://images.rawpixel.com/image_social_landscape/cHJpdmF0ZS9sci9pbWFnZXMvd2Vic2l0ZS8yMDIzLTA5L3JtNzA1ZGVzaWduLWVmZmVjdC10bnQtMDFlLmpwZw.jpg"
        //     )
        // };

        var silicon = new GithubProject
        {
            Title = "Silicon Design",
            Description = "",
            Content = "",
            Skills = ["HTML", "Figma", "CSS", "SCSS", "React", "Javascript"],
            ProjectURL = new Uri("https://github.com/KimmoKAhola/Silicon-Kimmo-Ahola"),
            ImageURL = new Uri(
                "https://kimmoprojectstorage.blob.core.windows.net/project/silicon.png"
            ),
            LiveDemoUrl = new Uri("https://silicon-kimmo-ahola.vercel.app/")
        };

        var bank = new GithubProject
        {
            Title = "Babun Bank",
            Description = "",
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
                "https://kimmoprojectstorage.blob.core.windows.net/project/bank.png"
            ),
            LiveDemoUrl = new Uri("https://babunbank.azurewebsites.net/")
        };

        var api = new GithubProject
        {
            Title = "RESTful API",
            Description = "MVC RESTful API",
            Content = "A RESTful API to do CRUD operations.",
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
                "https://kimmoprojectstorage.blob.core.windows.net/project/bank.png"
            ),
            LiveDemoUrl = new Uri("https://babun-api.azurewebsites.net/")
        };

        // var project2 = new GithubProject
        // {
        //     Title = "Web Portfolio",
        //     Description = "",
        //     Content = "",
        //     Skills =
        //     [
        //         "C#",
        //         "ASP.NET",
        //         "MVC",
        //         "RESTful API",
        //         "MS-SQL",
        //         "Entity Framework",
        //         "HTML",
        //         "CSS",
        //         "Javascript",
        //         "Consume External API"
        //     ],
        //     ProjectURL = new Uri("https://github.com/KimmoKAhola/Project-2"),
        //     ImageURL = new Uri(
        //         "https://kimmoprojectstorage.blob.core.windows.net/project/python.png"
        //     )
        // };

        // var python = new GithubProject
        // {
        //     Title = "Python Exam",
        //     Description = "",
        //     Content = "",
        //     Skills = ["Python", "Pandas", "Matplotlib", "Numpy",],
        //     ProjectURL = new Uri("https://github.com/KimmoKAhola/Programmera-mera-i-Python-A266TG"),
        //     ImageURL = new Uri(
        //         "https://images.rawpixel.com/image_social_landscape/cHJpdmF0ZS9sci9pbWFnZXMvd2Vic2l0ZS8yMDIzLTA5L3JtNzA1ZGVzaWduLWVmZmVjdC10bnQtMDFlLmpwZw.jpg"
        //     )
        // };

        context.Add(cashierSystem);
        context.Add(blackjack);
        context.Add(hotel);
        // context.Add(project1);
        context.Add(silicon);
        context.Add(bank);
        // context.Add(project2);
        // context.Add(python);

        await context.SaveChangesAsync();
    }
}
