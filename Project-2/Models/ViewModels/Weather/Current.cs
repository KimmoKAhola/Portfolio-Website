using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Project_2.Models.ViewModels.Weather;

public class Current
{
    [JsonProperty("temperature_2m")]
    [JsonPropertyName("temperature_2m")]
    public double Temperature2m { get; set; }

    [JsonProperty("interval")]
    [JsonPropertyName("interval")]
    public double Test { get; set; }

    [JsonProperty("is_day")]
    [JsonPropertyName("is_day")]
    public int IsDay { get; set; }

    [JsonProperty("weather_code")]
    [JsonPropertyName("weather_code")]
    public int WeatherCode { get; set; }
}
