using Newtonsoft.Json;

namespace Project_2.Models.ViewModels.Weather;

public class Clouds
{
    [JsonProperty("all")]
    public int All { get; set; }
}
