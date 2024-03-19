using IntegraBrasilAPI.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace IntegraBrasilAPI.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [HttpGet]
        public IActionResult Index() => Ok();

        [HttpGet("BuscarEnderecoPorCep/{cep}")]
        public async Task<IActionResult> BuscarEnderecoPorCep([FromRoute] string cep)
        {
            if (cep == null || cep.Any(x => char.IsLetter(x)))
                return BadRequest();

            var response = await _enderecoService.BuscarEndercoPorCEP(cep);

            if (response.CodigoHttp != HttpStatusCode.OK)
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);

            return Ok(response.DadosRetorno);
        }
    }
}
