using Microsoft.AspNetCore.Mvc;

namespace Project_X.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "Hello from API!" });
        }
    }
}
