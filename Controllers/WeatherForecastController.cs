using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace _20200730_EX_CREATE_API_VSCODE.Controllers
{
    [ApiController]
    [Route("[Controllers]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing",
            "Bracing",
            "Chilly",
            "Cool",
            "Mild",
            "Warm",
            "Balmy",
            "Hot",
            "Sweltering",
            "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
       
        [HttpGet]
        [Route("WeatherForecast")]
        public IEnumerable<Models.WeatherForecastModel> GetWeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 10).Select(index => new Models.WeatherForecastModel
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
} 