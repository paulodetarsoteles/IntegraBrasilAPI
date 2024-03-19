using Microsoft.AspNetCore.Mvc;

namespace IntegraBrasilAPI.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BancoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index() => Ok();
    }
}
