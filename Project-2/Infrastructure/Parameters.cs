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
        new SkillModel
        {
            SkillName = ".NET CORE",
            Description = "The .NET Framework",
            IconUrl = """
                <img class="skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/dotnetcore/dotnetcore-original.svg" />
                """
        },
        new SkillModel
        {
            SkillName = "Google",
            Description = "Google first",
            IconUrl = """
                <img class="skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/google/google-original-wordmark.svg" />
                """
        },
        new SkillModel
        {
            SkillName = "Azure",
            Description = "Pushing sites to azure services",
            IconUrl = """
                <img class="skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/azure/azure-original.svg" />
                """
        },
        new SkillModel
        {
            SkillName = "React",
            Description = "Creating websites using React",
            IconUrl = """
                <img class="skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/react/react-original.svg" />
                """
        },
        new SkillModel
        {
            SkillName = "Javascript",
            Description = "Please no",
            IconUrl = """
                <img class="skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/javascript/javascript-original.svg" />
                """
        }
    ];

    public static readonly Uri GitHub = new("https://github.com/KimmoKAhola/");
    public static readonly Uri LinkedIn = new("https://www.linkedin.com/in/kimmo-ahola-0679b6290/");
    public const string MyEmail = "Kahola@gmail.com";
    public static readonly Uri MyResume = new Uri(
        "https://kimmoprojectstorage.blob.core.windows.net/project/CV.pdf"
    );

    public static readonly Dictionary<string, string> Icons =
        new()
        {
            {
                "C#",
                """<img class="project-skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/csharp/csharp-original.svg" />"""
            },
            {
                "REACT",
                """<img class="project-skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/react/react-original.svg" />"""
            },
            {
                "JAVASCRIPT",
                """<img class="project-skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/javascript/javascript-original.svg" />"""
            },
            {
                "AZURE",
                """<img class="project-skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/azure/azure-original.svg" />"""
            },
            {
                "JAVA",
                """<img class="project-skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/java/java-original.svg" />"""
            },
            {
                "PYTHON",
                """<img class="project-skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/python/python-original.svg" />"""
            },
            {
                "MS-SQL",
                """<img class="project-skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/azuresqldatabase/azuresqldatabase-original.svg" />"""
            },
            {
                "PANDAS",
                """<img class="project-skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/pandas/pandas-original.svg" />"""
            },
            {
                "MATPLOTLIB",
                """<img class="project-skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/matplotlib/matplotlib-original.svg" />"""
            },
            {
                ".NET CORE",
                """<img class="project-skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/dotnetcore/dotnetcore-original.svg" />"""
            },
            {
                "Javascript",
                """<img class="project-skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/javascript/javascript-original.svg" />"""
            },
            {
                "FIGMA",
                """<img class="project-skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/figma/figma-original.svg" />"""
            },
            {
                "HTML",
                """<img class="project-skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/html5/html5-original-wordmark.svg" />"""
            },
            {
                "CSS",
                """<img class="project-skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/css3/css3-original-wordmark.svg" />"""
            },
            {
                "SCSS",
                """<img class="project-skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/sass/sass-original.svg" />"""
            }
        };

    public static readonly List<string> ReferenceQuotes =
    [
        // "\"It was a joy to do Console.WriteLine with you\" - William Gross",
        """
                <i class="quote">"IT WAS A <span style='text-decoration: underline;'>JOY</span> TO DO CONSOLE.WRITELINE WITH YOU" - WILLIAM GROSS</i>
            """,
        "\"I create bugs, he squashes them\" - William Gross"
    ];
}
