﻿using Newtonsoft.Json;

namespace Project_2.Models.ViewModels.Weather;

public class Root
{
    [JsonProperty("coord")]
    public Coord Coord { get; set; }

    [JsonProperty("weather")]
    public List<Weather> Weather { get; set; }

    [JsonProperty("base")]
    public string Base { get; set; }

    [JsonProperty("main")]
    public Main Main { get; set; }

    [JsonProperty("visibility")]
    public int Visibility { get; set; }

    [JsonProperty("wind")]
    public Wind Wind { get; set; }

    [JsonProperty("clouds")]
    public Clouds Clouds { get; set; }

    [JsonProperty("dt")]
    public int Dt { get; set; }

    [JsonProperty("sys")]
    public Sys Sys { get; set; }

    [JsonProperty("timezone")]
    public int Timezone { get; set; }

    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("cod")]
    public int Cod { get; set; }
}
