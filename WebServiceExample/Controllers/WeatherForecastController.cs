using Microsoft.AspNetCore.Mvc;

namespace WebServiceExample.Controllers
{
    [ApiController]
    [Route("api")]
    public class WeatherForecastController : ControllerBase
    {
        public struct User
        {
            public string Name { get; set; }
            public DateTime BirthDate { get; set; }
        }

        [HttpGet("test")]
        public User test()
        {
            User user = new User();
            user.Name = "Jan Skibidi";
            user.BirthDate = DateTime.Now;
            return user;
        }

        [HttpGet("helloworld")]
        public String helloworld()
        {
            return "Ahoj svìte";
        }
    }
}
