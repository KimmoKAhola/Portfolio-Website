using Microsoft.AspNetCore.Mvc;
using Project_2.Infrastructure;
using Project_2.Models;
using Project_2.Models.FormModels.Contact;
using Project_2.Models.ViewModels;
using Project_2.Models.ViewModels.GithubProjects;
using Project_2.Models.ViewModels.Weather;

namespace Project_2.Controllers;

public class HomeController(
    IHttpService<Root> weatherService,
    IHttpService<GithubProjectModel> projectService
) : Controller
{
    public async Task<IActionResult> Index()
    {
        // var weatherResult = await weatherService.Get();
        // var model = new WeatherModel { Info = result.Weather.First().Description };  //TODO
        var weatherModel = new WeatherModel { Info = "Warm as hell" };
        var githubProjectModels = await projectService.GetAll();

        var indexViewModel = new IndexViewModel
        {
            WeatherModel = weatherModel,
            GithubProjectModels = githubProjectModels,
            ListOfSkills = Parameters.Skills,
            ContactMeModel = new ContactMeModel()
        };
        return View(indexViewModel);
    }

    [HttpPost]
    public async Task<IActionResult> Submit(IndexViewModel indexViewModel)
    {
        indexViewModel.GithubProjectModels = await projectService.GetAll();
        // indexViewModel.WeatherModel.Info = "Warm as hell";
        indexViewModel.ListOfSkills = Parameters.Skills;
        if (!ModelState.IsValid)
        {
            return RedirectToAction("Index", indexViewModel);
        }

        var myEmail = Parameters.MyEmail;

        var mailtoLink =
            $"mailto:{Uri.EscapeDataString(myEmail)}"
            + $"?subject={Uri.EscapeDataString("Intresseanmälan")}"
            + $"&body={Uri.EscapeDataString($"Hello {indexViewModel.ContactMeModel.Fullname},\n\n{indexViewModel.ContactMeModel.Message}")}";
        return Redirect(mailtoLink);
    }
}
