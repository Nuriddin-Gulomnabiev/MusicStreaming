using AdminPanel.Application.Common.Interfaces;
using Domain.Entities.Artists;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
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

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<object> Get([FromServices] IAdminApplicationDbContext dbContext)
        {
            var a = dbContext.Artists.ToList();

            return a;
        }
    }
}