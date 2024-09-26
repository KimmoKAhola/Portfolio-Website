using Project_2.Models.FormModels.Contact;
using Project_2.Models.ViewModels.GithubProjects;

namespace Project_2.Models.ViewModels;

public class IndexViewModel
{
    public WeatherModel? WeatherModel { get; set; }
    public List<GithubProjectModel>? GithubProjectModels { get; set; }
    public List<GithubProjectModel>? GithubProjectModelsSwedish { get; set; }
    public List<SkillModel>? ListOfSkills { get; set; }
    public ContactMeModel ContactMeModel { get; set; } = null!;
}
