using Microsoft.AspNetCore.Mvc;
using API_Interactive_Lab_1.Models;
using System.Xml.Linq;

namespace API_Interactive_Lab_1.Controllers
{
    [ApiController]
    [Route("coffee")]
    public class CoffeeController : ControllerBase
    {
        [HttpGet]
        [Route("lover")]
        public string Get()
        {
            return "I like coffee!";
        }

        [HttpGet("{name}")]
        public Coffee Get(string? name)
        {
            var coffeeList = new CoffeeList();
            return coffeeList.GetCoffee(name);
        }
    }
}