using Microsoft.AspNetCore.Mvc;
using Project_2.Infrastructure;
using Project_2.Models;
using Project_2.Models.FormModels.Contact;
using Project_2.Models.ViewModels;
using Project_2.Models.ViewModels.GithubProjects;
using Project_2.Models.ViewModels.Weather;

namespace Project_2.Controllers;

public class HomeController(IWeatherService weatherService, IGithubProjectService projectService)
    : Controller
{
    public async Task<IActionResult> Index()
    {
        var githubProjectModels = await projectService.Get();

        var indexViewModel = new IndexViewModel
        {
            GithubProjectModels = githubProjectModels,
            ListOfSkills = Parameters.Skills,
            ContactMeModel = new ContactMeModel()
        };
        return View(indexViewModel);
    }

    [HttpPost]
    public async Task<IActionResult> Submit(IndexViewModel indexViewModel)
    {
        indexViewModel.GithubProjectModels = await projectService.Get();
        var result = await weatherService.Get(1, 1);
        var weatherModel = new WeatherModel { CurrentTemperature = result.Current.Temperature2m }; //TODO
        indexViewModel.WeatherModel = weatherModel;
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

    [HttpGet]
    public async Task<JsonResult> GetWeather(double lat, double lon)
    {
        var result = await weatherService.Get(lat, lon);
        return new JsonResult(result);
    }
}
