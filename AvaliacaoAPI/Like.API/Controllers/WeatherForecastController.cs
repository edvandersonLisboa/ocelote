using Microsoft.AspNetCore.Mvc;

namespace Like.API.Controllers;

[ApiController]
[Route("api/v1/avaliacoes")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet("api")]
    public string Get()
    {
        return "essa api é de Like";
    }
}
