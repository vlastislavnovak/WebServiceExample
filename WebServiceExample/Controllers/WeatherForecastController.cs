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

        [HttpGet("get-user")]
        public IActionResult getUser(int id)
        {
            if (id == 1)
            {
                User user = new User();
                user.Name = "Jan Skibidi";
                user.BirthDate = DateTime.Now;
                return Ok(user);
            } else
            {
                return NotFound("Uživatel nebyl nalezen.");
            }
        }

        [HttpGet("helloworld")]
        public String helloworld()
        {
            return "Ahoj svìte";
        }
    }
}
