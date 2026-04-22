using Microsoft.AspNetCore.Mvc;

namespace SistemadeTiquetess.src.modules.Airlines.UI;

[ApiController]
[Route("api/[controller]")]
public class AirlinesController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAirlines()
    {
        return Ok(new string[] { "Airline1", "Airline2" });
    }
}
