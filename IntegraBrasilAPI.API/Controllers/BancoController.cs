using IntegraBrasilAPI.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace IntegraBrasilAPI.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BancoController : ControllerBase
    {
        private readonly IBancoService _bancoService;

        public BancoController(IBancoService bancoService) => _bancoService = bancoService;

        [HttpGet]
        public IActionResult Index() => Ok();

        [HttpGet("BuscarBancos")]
        public async Task<IActionResult> BuscarBancos()
        {
            try
            {
                var response = await _bancoService.BuscarBancos();

                if (response.CodigoHttp != HttpStatusCode.OK)
                    return StatusCode((int)response.CodigoHttp, response.ErroRetorno);

                return Ok(response.DadosRetorno);
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> BuscarBancoPorCodigo([FromRoute] string codigo)
        {
            try
            {
                if (codigo == null || codigo.Any(x => char.IsLetter(x)))
                    return BadRequest();

                var response = await _bancoService.BuscarBancoPorCodigo(codigo);

                if (response.CodigoHttp != HttpStatusCode.OK)
                    return StatusCode((int)response.CodigoHttp, response.ErroRetorno);

                return Ok(response.DadosRetorno);
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
