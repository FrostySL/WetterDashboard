using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Net.Http;
using WetterDashboard.Models.DTOs;

namespace WetterDashboard.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _httpClient;
        private readonly string? _apiKey;

        public WeatherService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _apiKey = configuration["WeatherApi:ApiKey"];
        }

        public Task<WeatherInfoDto> GetWeatherAsync(string city)
        {
            throw new NotImplementedException();
        }
    }
}