using Newtonsoft.Json;

namespace Project_2.Models.ViewModels.Weather;

public class Coord
{
    [JsonProperty("lon")]
    public double Lon { get; set; }

    [JsonProperty("lat")]
    public int Lat { get; set; }
}
