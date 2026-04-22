using Microsoft.AspNetCore.Mvc;

namespace SistemadeTiquetess.src.modules.Aircrafts.UI;

[ApiController]
[Route("api/[controller]")]
public class AircraftsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAircrafts()
    {
        return Ok(new string[] { "Aircraft1", "Aircraft2" });
    }
}
