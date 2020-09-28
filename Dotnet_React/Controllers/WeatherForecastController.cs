using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Dotnet_React.Controllers
{

    // File Summary: Our API controller that our front end will make calls to.

    // In-Class Practice:
    // - Add a precipitation summary to the data. (Random selection of: Rain, Snow, Sleet, Hail, Cats and Dogs)
    // - Ensure that it is functional on the output page.

    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static readonly string[] Precipitations = new[]
        {
           "Rain"," Snow", "Sleet", "Hail", "Cats", "Dogs"
        };
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)],
                Precipitation = Precipitations[rng.Next(Precipitations.Length)]
            })
            .ToArray();
        }
    }
}
