using Project_2.Models.ViewModels.Weather;

namespace Project_2.Infrastructure;

public interface IWeatherService
{
    Task<Root> Get(double lat, double lon);
}
