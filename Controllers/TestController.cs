using Microsoft.AspNetCore.Mvc;

namespace k401_third.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
  

    [HttpGet("hello")]
    public IActionResult Get()
    {
        return Ok("Salam");
    }
}
