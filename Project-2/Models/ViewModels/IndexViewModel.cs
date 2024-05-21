using Project_2.Models.FormModels.Contact;
using Project_2.Models.ViewModels.GithubProjects;

namespace Project_2.Models.ViewModels;

public class IndexViewModel
{
    public WeatherModel WeatherModel { get; init; } = null!;
    public List<GithubProjectModel> GithubProjectModels { get; init; } = null!;
    public List<SkillModel> ListOfSkills { get; init; } = null!;
    public ContactMeModel ContactMeModel { get; init; } = null!;
}
