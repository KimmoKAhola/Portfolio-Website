using Project_2.Models.FormModels.Contact;
using Project_2.Models.ViewModels.GithubProjects;

namespace Project_2.Models.ViewModels;

public class IndexViewModel
{
    public WeatherModel WeatherModel { get; set; } = null!;
    public List<GithubProjectModel> GithubProjectModels { get; set; } = null!;
    public List<SkillModel> ListOfSkills { get; set; } = null!;
    public ContactMeModel ContactMeModel { get; set; } = null!;
}
