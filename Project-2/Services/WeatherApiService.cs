using System.Globalization;
using System.Text.Json;
using Project_2.Infrastructure;
using Project_2.Models.ViewModels.Weather;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Project_2.Services;

public class WeatherApiService(HttpClient httpClient) : IWeatherService
{
    private readonly JsonSerializerOptions _jsonOptions =
        new() { PropertyNameCaseInsensitive = true };

    public async Task<Root> Get(double lat, double lon)
    {
        var latitude = lat.ToString(CultureInfo.InvariantCulture).Replace(',', '.');
        var longitude = lon.ToString(CultureInfo.InvariantCulture).Replace(',', '.');
        var httpResponse = await httpClient.GetAsync(
            $"{httpClient.BaseAddress}forecast?latitude={latitude}&longitude={longitude}&current=temperature_2m,is_day,weather_code"
        );
        try
        {
            httpResponse.EnsureSuccessStatusCode();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null!;
        }

        var result = await httpResponse.Content.ReadAsStringAsync();

        var weather = JsonSerializer.Deserialize<Root>(result, _jsonOptions);
        return weather!;
    }
}
