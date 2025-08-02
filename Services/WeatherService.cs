using WetterDashboard.Models.DTOs;

namespace WetterDashboard.Services
{
    public class WeatherService : IWeatherService
    {
        public Task<WeatherInfoDto> GetWeatherAsync(string city)
        {
            throw new NotImplementedException();
        }
    }
}