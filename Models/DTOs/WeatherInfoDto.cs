using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WetterDashboard.Models.DTOs
{
    public class WeatherInfoDto
    {
        public string? Temperature { get; set; }
        public string? Description { get; set; }
        public string? FeelsLike { get; set; }
        public string? Humidity { get; set; }
        public string? WindSpeed { get; set; }
    }
}
