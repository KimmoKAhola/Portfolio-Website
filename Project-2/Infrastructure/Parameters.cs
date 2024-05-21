using Project_2.Models.ViewModels;

namespace Project_2.Infrastructure;

public class Parameters
{
    public static readonly List<SkillModel> Skills =
    [
        new SkillModel { SkillName = "C#", Description = "Best language" },
        new SkillModel { SkillName = "JAVA", Description = "I spit on it" },
        new SkillModel { SkillName = "Python", Description = "Love to hate it" },
        new SkillModel { SkillName = "MS-SQL", Description = "I like databases" },
        new SkillModel { SkillName = "Pandas", Description = "I like csv files" },
        new SkillModel { SkillName = "MatPlotLib", Description = "Who doesn't like a good graph?" },
        new SkillModel { SkillName = "Fluff", Description = "I ran out of skills" }
    ];

    public static readonly Uri GitHub = new Uri("https://github.com/KimmoKAhola/");
    public static readonly Uri LinkedIn = new Uri(
        "https://www.linkedin.com/in/kimmo-ahola-0679b6290/"
    );
}
