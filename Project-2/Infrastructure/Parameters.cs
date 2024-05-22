using Project_2.Models.ViewModels;

namespace Project_2.Infrastructure;

public static class Parameters
{
    public static readonly List<SkillModel> Skills =
    [
        new SkillModel
        {
            SkillName = "C#",
            Description = "Best language",
            IconUrl = """
                <img class="skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/csharp/csharp-original.svg" />
                """
        },
        new SkillModel
        {
            SkillName = "JAVA",
            Description = "I spit on it",
            IconUrl = """
                <img class="skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/java/java-original.svg" />
                """
        },
        new SkillModel
        {
            SkillName = "Python",
            Description = "Love to hate it",
            IconUrl = """
                <img class="skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/python/python-original.svg" />
                """
        },
        new SkillModel
        {
            SkillName = "MS-SQL",
            Description = "I like databases",
            IconUrl = """
                <img class="skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/azuresqldatabase/azuresqldatabase-original.svg" />
                """
        },
        new SkillModel
        {
            SkillName = "Pandas",
            Description = "I like csv files",
            IconUrl = """
                <img class="skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/pandas/pandas-original.svg" />
                """
        },
        new SkillModel
        {
            SkillName = "MatPlotLib",
            Description = "Who doesn't like a good graph?",
            IconUrl = """
                <img class="skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/matplotlib/matplotlib-original.svg" />
                """
        },
        new SkillModel { SkillName = "Fluff", Description = "I ran out of skills" }
    ];

    public static readonly Uri GitHub = new("https://github.com/KimmoKAhola/");
    public static readonly Uri LinkedIn = new("https://www.linkedin.com/in/kimmo-ahola-0679b6290/");
}
