using AutoMapper;
using IntegraBrasilAPI.API.DTOs;
using IntegraBrasilAPI.API.Rest.Interfaces;
using IntegraBrasilAPI.API.Services.Interfaces;

namespace IntegraBrasilAPI.API.Services
{
    public class BancoService : IBancoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApiRest _brasilApi;

        public BancoService(IMapper mapper, IBrasilApiRest brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<List<BancoResponse>>> BuscarBancos()
        {
            var bancos = await _brasilApi.BuscarBancos();

            return _mapper.Map<ResponseGenerico<List<BancoResponse>>>(bancos);
        }

        public async Task<ResponseGenerico<BancoResponse>> BuscarBancoPorCodigo(string codigo)
        {
            var banco = await _brasilApi.BuscarBancoPorCodigo(codigo);

            return _mapper.Map<ResponseGenerico<BancoResponse>>(banco);
        }
    }
}
