using Microsoft.AspNetCore.Mvc;

namespace Task45.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreeterController : ControllerBase
    {
        [HttpPost]
        public IActionResult Get([FromBody] Person person)
        {
            string greetname = string.IsNullOrEmpty(person.name) ? "anonymous" : person.name;
            return Ok($"hello {greetname}");
        }
    }

}
