using Microsoft.AspNetCore.Mvc;

namespace WebApiVersioningDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly AppVersionInfo _versionInfo;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public WeatherForecastController(AppVersionInfo versionInfo) => this._versionInfo = versionInfo;

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            var data = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();

            var result = new
            {
                VersionInfo = this._versionInfo,
                Data = data,
            };

            return Ok(result);
        }
    }
}