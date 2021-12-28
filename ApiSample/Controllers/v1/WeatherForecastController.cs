using ApiSample.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiSample.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class WeatherForecastController : ControllerMain
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly INotifier _notifier;

        public WeatherForecastController(INotifier notifier, ILogger<WeatherForecastController> logger) : base(notifier, logger)
        {
            _logger = logger;
            _notifier = notifier;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public ActionResult Get()
        {
            _logger.LogInformation("test of log");

            //NotifyError("test de erro");

            var c = new WeatherForecastController(_notifier, _logger);
            c.ModelState.AddModelError("Error","Fake Error");

            var result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();

            return CustomResponse(c.ModelState);
            //return CustomResponse(result);

            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();
        }
    }
}