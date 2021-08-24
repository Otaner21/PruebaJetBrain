using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RenatoObli.EntityFrameworkCore;

namespace RenatoObli.HttpAPi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Br", "Chilly", "frio", "Mil", "Wam", "Blmy", "Ho", "Swltering", "Sorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly Context _context;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, Context context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var forecast = new List<WeatherForecast>();
            if (!_context.WeatherForecasts.Any())
            {
                var rng = new Random();
                forecast.AddRange(Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                }));
                _context.WeatherForecasts.AddRange(forecast);
                _context.SaveChanges();
            }
            else
            {
                forecast.AddRange(_context.WeatherForecasts);
            }

            return forecast;
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
            
        }

        [HttpPut("{Id}")]
        public void Put(int id, [FromBody] string value)
        {
            
        }

        [HttpDelete("{Id}")]
        public void Delete(int id)
        {
            
        } 
    }
}