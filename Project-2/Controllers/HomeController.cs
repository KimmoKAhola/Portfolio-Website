using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Project_2.Infrastructure;
using Project_2.Models;
using Project_2.Models.FormModels.Contact;
using Project_2.Models.ViewModels;
using Project_2.Models.ViewModels.GithubProjects;
using Project_2.Models.ViewModels.Weather;

namespace Project_2.Controllers;

public class HomeController(
    IWeatherService weatherService,
    IGithubProjectService projectService,
    IMemoryCache memoryCache
) : Controller
{
    public async Task<IActionResult> Index()
    {
        var githubProjectModels = await projectService.Get();

        var gitHubProjectModelsSwedish = new List<GithubProjectModel>();
        foreach (var model in githubProjectModels)
        {
            model.SkillsList = model.Skills.Split(",").Select(x => x.Trim()).ToList();

            var swedishModel = new GithubProjectModel
            {
                Title = model.Title,
                Description = model.Description,
                Content = model.Content,
                Skills = model.Skills,
                SkillsList = model.SkillsList,
                ProjectURL = model.ProjectURL,
                ImageURL = model.ImageURL,
                LiveDemoURL = model.LiveDemoURL,
            };

            var descriptionParts = model.Description.Split(";");

            model.Description = descriptionParts.FirstOrDefault()?.Trim() ?? model.Description;

            swedishModel.Description =
                descriptionParts.ElementAtOrDefault(1)?.Trim() ?? model.Description;

            gitHubProjectModelsSwedish.Add(swedishModel);
        }

        var indexViewModel = new IndexViewModel
        {
            GithubProjectModels = githubProjectModels,
            GithubProjectModelsSwedish = gitHubProjectModelsSwedish,
            ListOfSkills = Parameters.Skills,
            ContactMeModel = new ContactMeModel { Message = "English here" }
        };
        return View(indexViewModel);
    }

    public async Task<IActionResult> Swedish()
    {
        var githubProjectModels = await projectService.Get();

        var gitHubProjectModelsSwedish = new List<GithubProjectModel>();
        foreach (var model in githubProjectModels)
        {
            model.SkillsList = model.Skills.Split(",").Select(x => x.Trim()).ToList();

            var swedishModel = new GithubProjectModel
            {
                Title = model.Title,
                Description = model.Description,
                Content = model.Content,
                Skills = model.Skills,
                SkillsList = model.SkillsList,
                ProjectURL = model.ProjectURL,
                ImageURL = model.ImageURL,
                LiveDemoURL = model.LiveDemoURL,
            };

            var descriptionParts = model.Description.Split(";");

            model.Description = descriptionParts.FirstOrDefault()?.Trim() ?? model.Description;

            swedishModel.Description =
                descriptionParts.ElementAtOrDefault(1)?.Trim() ?? model.Description;

            gitHubProjectModelsSwedish.Add(swedishModel);
        }

        var indexViewModel = new IndexViewModel
        {
            GithubProjectModels = githubProjectModels,
            GithubProjectModelsSwedish = gitHubProjectModelsSwedish,
            ListOfSkills = Parameters.Skills,
            ContactMeModel = new ContactMeModel
            {
                Message =
                    "Vi har blivit imponerade av dina färdigheter som programmerare och tror att du skulle vara en fantastisk tillgång för vårt team.\n\nVi skulle gärna vilja komma i kontakt med dig för att diskutera potentiella möjligheter.\n\nHör av dig så snart du kan!"
            }
        };
        return View(indexViewModel);
    }

    [HttpPost]
    public async Task<IActionResult> Submit(IndexViewModel indexViewModel, double lat, double lon)
    {
        indexViewModel.GithubProjectModels = await projectService.Get();
        var result = await weatherService.Get(lat, lon);
        var weatherModel = new WeatherModel { CurrentTemperature = result.Current.Temperature2m };
        indexViewModel.WeatherModel = weatherModel;
        indexViewModel.ListOfSkills = Parameters.Skills;
        if (!ModelState.IsValid)
        {
            return RedirectToAction("Index", indexViewModel);
        }

        indexViewModel.ContactMeModel.Message =
            "Vi har blivit imponerade av dina färdigheter som programmerare och tror att du skulle vara en fantastisk tillgång för vårt team.\n\nVi skulle gärna vilja komma i kontakt med dig för att diskutera potentiella möjligheter.\n\nHör av dig så snart du kan!";

        var myEmail = Parameters.MyEmail;

        var mailtoLink =
            $"mailto:{Uri.EscapeDataString(myEmail)}"
            + $"?subject={Uri.EscapeDataString("Intresseanmälan")}"
            + $"&body={Uri.EscapeDataString($"Hello Kimmo, my name is {indexViewModel.ContactMeModel.Fullname},\n\n{indexViewModel.ContactMeModel.Message}")}";
        return Redirect(mailtoLink);
    }

    [HttpPost]
    public async Task<IActionResult> SubmitSwedish(
        IndexViewModel indexViewModel,
        double lat,
        double lon
    )
    {
        indexViewModel.GithubProjectModels = await projectService.Get();
        var result = await weatherService.Get(lat, lon);
        var weatherModel = new WeatherModel { CurrentTemperature = result.Current.Temperature2m };
        indexViewModel.WeatherModel = weatherModel;
        indexViewModel.ListOfSkills = Parameters.Skills;
        if (!ModelState.IsValid)
        {
            return RedirectToAction("Index", indexViewModel);
        }

        indexViewModel.ContactMeModel.Message =
            "Vi har blivit imponerade av dina färdigheter som programmerare och tror att du skulle vara en fantastisk tillgång för vårt team.\n\nVi skulle gärna vilja komma i kontakt med dig för att diskutera potentiella möjligheter.\n\nHör av dig så snart du kan!";

        var myEmail = Parameters.MyEmail;

        var mailtoLink =
            $"mailto:{Uri.EscapeDataString(myEmail)}"
            + $"?subject={Uri.EscapeDataString("Intresseanmälan")}"
            + $"&body={Uri.EscapeDataString($"Hej Kimmo, {indexViewModel.ContactMeModel.Fullname} här!,\n\n{indexViewModel.ContactMeModel.Message}")}";
        return Redirect(mailtoLink);
    }

    [HttpGet]
    public async Task<JsonResult> GetWeather(double lat, double lon)
    {
        var cacheKey = $"Weather_{lat}_{lon}";

        if (memoryCache.TryGetValue(cacheKey, out var cachedWeather))
            return new JsonResult(cachedWeather);

        var result = await weatherService.Get(lat, lon);

        var cacheEntryOptions = new MemoryCacheEntryOptions
        {
            SlidingExpiration = TimeSpan.FromMinutes(15)
        };

        memoryCache.Set(cacheKey, result, cacheEntryOptions);

        return new JsonResult(result);
    }
}
