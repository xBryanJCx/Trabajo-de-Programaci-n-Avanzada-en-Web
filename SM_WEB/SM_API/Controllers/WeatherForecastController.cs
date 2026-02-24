using Microsoft.AspNetCore.Mvc;
using SM_API.Models;

    namespace SM_API.Controllers
    {
        [ApiController]
        [Route("[controller]")]
        public class WeatherForecastController : ControllerBase
        {
            [HttpGet(Name = "GetWeatherForecast")]
            public IActionResult Get()
            {
                return Ok();
            }
        }
    }