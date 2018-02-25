using Microsoft.AspNetCore.Mvc;

namespace OZE.WebApi.Controllers {
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        public IActionResult Get() {
            return Ok("Hello World");
        }
    }
}
