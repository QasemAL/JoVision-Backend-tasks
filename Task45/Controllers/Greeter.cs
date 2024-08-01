using Microsoft.AspNetCore.Mvc;

namespace Task45.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreeterController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] string? name)
        {
            string greetname = string.IsNullOrEmpty(name) ? "anonymous" : name;
            return Ok($"hello {greetname}");
        }
    }
}
