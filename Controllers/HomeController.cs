using Microsoft.AspNetCore.Mvc;
namespace API_Interactive_Lab_1.Controllers
{
    [ApiController]
    [Route("")]
    //[Route("/")]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Welcome to the DrinksAPI!";
        }
    }
}