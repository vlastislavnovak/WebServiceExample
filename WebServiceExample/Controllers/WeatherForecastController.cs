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
            user.Name = "Jan Novák";
            user.BirthDate = DateTime.Now;
            return user;
        }

        [HttpGet("helloworld")]
        public String helloworld()
        {
            return "Ahoj svìte";
        }

        [HttpGet("test3")]
        public String test3()
        {
            return "Ahoj uivateli";
        }

        // Nové metody
        [HttpGet("greet")]
        public string Greet(string name)
        {
            return $"Ahoj, {name}!";
        }

        [HttpGet("calculate-age")]
        public int CalculateAge(int birthYear)
        {
            var birthDate = new DateTime(birthYear, 1, 1);
            var today = DateTime.Today;
            var age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age)) age--;
            return age;
        }


        [HttpGet("add-numbers")]
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}
