using System.Text.Json;
using Project_2.Controllers;
using Project_2.Infrastructure;
using Project_2.Models.ViewModels.Weather;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Project_2.Services;

public class WeatherApiService(HttpClient httpClient) : IHttpService<Root>
{
    private readonly JsonSerializerOptions _jsonOptions =
        new() { PropertyNameCaseInsensitive = true };

    public async Task<Root> Get(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<Root> Get()
    {
        // weather?lat={lat}&lon={lon}&appid={API key}
        var apiKey = "0593294451c469d0423a6d4c703c14bd";
        var url = $"weather?q=Uppsala&appid={apiKey}";
        var httpResponse = await httpClient.GetAsync(url);
        try
        {
            httpResponse.EnsureSuccessStatusCode();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null!; //TODO make this nicer
        }

        var result = await httpResponse.Content.ReadAsStringAsync();

        var weather = JsonSerializer.Deserialize<Root>(result, _jsonOptions);
        return weather;
    }

    public async Task<List<Root>> GetAll()
    {
        throw new NotImplementedException();
    }
}
