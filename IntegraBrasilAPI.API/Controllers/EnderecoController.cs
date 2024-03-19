using Microsoft.AspNetCore.Mvc;

namespace IntegraBrasilAPI.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index() => Ok();
    }
}
