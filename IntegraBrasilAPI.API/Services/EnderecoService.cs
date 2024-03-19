using AutoMapper;
using IntegraBrasilAPI.API.DTOs;
using IntegraBrasilAPI.API.Rest.Interfaces;
using IntegraBrasilAPI.API.Services.Interfaces;

namespace IntegraBrasilAPI.API.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApiRest _brasilApi;

        public EnderecoService(IMapper mapper, IBrasilApiRest brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<EnderecoResponse>> BuscarEndercoPorCEP(string cep)
        {
            var endereco = await _brasilApi.BuscarEndercoPorCEP(cep);

            return _mapper.Map<ResponseGenerico<EnderecoResponse>>(endereco);
        }
    }
}
