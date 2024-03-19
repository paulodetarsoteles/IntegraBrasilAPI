using IntegraBrasilAPI.API.Services.Interfaces;
using IntegraBrasilAPI.API.Utils;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace IntegraBrasilAPI.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService) => _enderecoService = enderecoService;

        [HttpGet]
        public IActionResult Index() => Ok();

        [HttpGet("BuscarEnderecoPorCep/{cep}")]
        public async Task<IActionResult> BuscarEnderecoPorCep([FromRoute] string cep)
        {
            try
            {
                if (!Validators.ValidatorCep(cep))
                    return BadRequest(new { message = $"Erro no CEP informado. {cep}" });

                var response = await _enderecoService.BuscarEndercoPorCEP(cep);

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
