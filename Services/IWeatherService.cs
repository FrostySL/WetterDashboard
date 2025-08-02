using WetterDashboard.Models.DTOs;

namespace WetterDashboard.Services
{
    public interface IWeatherService
    {
        Task<WeatherInfoDto> GetWeatherAsync(string city);
    }
}