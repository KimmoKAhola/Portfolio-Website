namespace Project_2.Models.ViewModels.GithubProjects;

public class GithubProjectModel
{
    public string Title { get; init; } = null!;
    public string Description { get; set; } = null!;
    public string Content { get; init; } = null!;
    public string Skills { get; init; }

    public List<string> SkillsList { get; set; } = [];
    public Uri ProjectURL { get; init; } = null!;
    public Uri ImageURL { get; init; } = null!;
    public Uri? LiveDemoURL { get; init; }
}
