using Microsoft.AspNetCore.Mvc;

namespace AspNetApiTemplate.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthcheckController : ControllerBase
{
    [HttpGet]
    public ActionResult Healthcheck() =>
        Ok("OK");
}
