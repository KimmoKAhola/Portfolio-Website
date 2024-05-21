using Newtonsoft.Json;

namespace Project_2.Models.ViewModels.Weather;

public class Wind
{
    [JsonProperty("speed")]
    public double Speed { get; set; }

    [JsonProperty("deg")]
    public int Deg { get; set; }
}
