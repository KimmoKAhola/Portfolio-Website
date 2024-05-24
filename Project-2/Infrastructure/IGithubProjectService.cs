using Project_2.Models.ViewModels.GithubProjects;

namespace Project_2.Infrastructure;

public interface IGithubProjectService
{
    Task<List<GithubProjectModel>> Get();
}
