using Microsoft.AspNetCore.Mvc;

namespace k401_third.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
  

    [HttpGet("login")]
    public IActionResult Get()
    {
        return Ok("Sagol");
    }
}
