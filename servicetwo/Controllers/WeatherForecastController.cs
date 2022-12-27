using Microsoft.AspNetCore.Mvc;

namespace servicetwo.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Auto = new[]
    {
        "McLaren", "Ferrari", "Mercedes", "Ford", "Porshe", "Kamaz", "Toyota", "HotWheels", "Subaru", "Scorpion"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                SpeedKMH = Random.Shared.Next(220, 308),
                Auto = Auto[Random.Shared.Next(Auto.Length)]
            })
            .ToArray();
    }
}