﻿using Newtonsoft.Json;

namespace Project_2.Models.ViewModels.Weather;

public class Sys
{
    [JsonProperty("type")]
    public int Type { get; set; }

    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("country")]
    public string Country { get; set; }

    [JsonProperty("sunrise")]
    public int Sunrise { get; set; }

    [JsonProperty("sunset")]
    public int Sunset { get; set; }
}
