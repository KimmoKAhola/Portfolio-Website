using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Project_2.Models.ViewModels.Weather;

public class Root
{
    [JsonProperty("latitude")]
    public double Latitude { get; set; }

    [JsonProperty("longitude")]
    public double Longitude { get; set; }

    [JsonProperty("current")]
    [JsonPropertyName("current")]
    public Current Current { get; set; }
}
