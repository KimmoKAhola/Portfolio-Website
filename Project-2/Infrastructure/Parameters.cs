using Project_2.Models.ViewModels;

namespace Project_2.Infrastructure;

public static class Parameters
{
    public static readonly List<SkillModel> Skills =
    [
        new SkillModel
        {
            SkillName = "C#",
            IconUrl = """
                <img class="skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/csharp/csharp-original.svg" />
                """
        },
        new SkillModel
        {
            SkillName = "JAVA",
            IconUrl = """
                <img class="skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/java/java-original.svg" />
                """
        },
        new SkillModel
        {
            SkillName = "Python",
            IconUrl = """
                <img class="skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/python/python-original.svg" />
                """
        },
        new SkillModel
        {
            SkillName = "MS-SQL",
            IconUrl = """
                <img class="skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/azuresqldatabase/azuresqldatabase-original.svg" />
                """
        },
        new SkillModel
        {
            SkillName = "Pandas",
            IconUrl = """
                <img class="skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/pandas/pandas-original.svg" />
                """
        },
        new SkillModel
        {
            SkillName = "MatPlotLib",
            IconUrl = """
                <img class="skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/matplotlib/matplotlib-original.svg" />
                """
        },
        new SkillModel
        {
            SkillName = ".NET CORE",
            IconUrl = """
                <img class="skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/dotnetcore/dotnetcore-original.svg" />
                """
        },
        new SkillModel
        {
            SkillName = "Google",
            IconUrl = """
                <img class="skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/google/google-original.svg" />
                """
        },
        new SkillModel
        {
            SkillName = "Azure",
            IconUrl = """
                <img class="skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/azure/azure-original.svg" />
                """
        },
        new SkillModel
        {
            SkillName = "React",
            IconUrl = """
                <img class="skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/react/react-original.svg" />
                """
        },
        new SkillModel
        {
            SkillName = "Javascript",
            IconUrl = """
                <img class="skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/javascript/javascript-original.svg" />
                """
        },
        new SkillModel
        {
            SkillName = "HTML",
            IconUrl =
                """<img class="skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/html5/html5-original-wordmark.svg" />"""
        },
        new SkillModel
        {
            SkillName = "CSS",
            IconUrl =
                """<img class="skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/css3/css3-original-wordmark.svg" />"""
        },
        new SkillModel
        {
            SkillName = "SCSS",
            IconUrl =
                """<img class="skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/sass/sass-original.svg" />"""
        },
        new SkillModel
        {
            SkillName = "SWAGGER",
            IconUrl =
                """<img class="skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/swagger/swagger-original.svg" />"""
        },
        new SkillModel
        {
            SkillName = "OAUTH2",
            IconUrl =
                """<img class="skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/oauth/oauth-original.svg" />"""
        }
    ];

    public static readonly Uri GitHub = new("https://github.com/KimmoKAhola/");
    public static readonly Uri LinkedIn = new("https://www.linkedin.com/in/kimmo-ahola-0679b6290/");
    public static readonly Uri WilliamLinkedIn =
        new("https://www.linkedin.com/in/william-gross-602971290/");
    public static readonly Uri WilliamGithub = new("https://github.com/WILGROSS");
    public const string MyEmail = "Kahola@gmail.com";
    public static readonly Uri MyResume =
        new("https://kimmoprojectstorage.blob.core.windows.net/project/CV.pdf");

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
            },
            {
                "SWAGGER",
                """<img class="project-skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/swagger/swagger-original.svg" />"""
            },
            {
                "OAUTH2",
                """<img class="project-skill-icon" src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/oauth/oauth-original.svg" />"""
            }
        };

    public static readonly List<string> ReferenceQuotes =
    [
        """
            <i class="quote">"IT WAS AN <span style='text-decoration: underline;'>HONOR</span> TO DO CONSOLE.WRITELINE WITH YOU"</i>
            """,
        """
            <i class="quote">"I CREATE BUGS, HE <span style='text-decoration: underline;'>SQUASHES</span> THEM"</i>
            """
    ];
}
