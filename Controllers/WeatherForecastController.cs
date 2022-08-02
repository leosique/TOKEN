using Microsoft.AspNetCore.Mvc;

namespace Token.Controllers;

[ApiController]
[Route("main")]
public class MainController : ControllerBase
{
    [HttpGet("key")]
    public string GetKey([FromServices]CryptoService crypto)
    {
        return crypto.GetInternalKey(TimeSpan.FromSeconds(1),24);
    }
}
