using System;

namespace Dotnet_React
{
    // A model for the demo project which models the weather for a given day.
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
        public string Precipitation { get; set; }
    }
}
