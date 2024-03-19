using IntegraBrasilAPI.API.DTOs;
using IntegraBrasilAPI.API.Services.Interfaces;

namespace IntegraBrasilAPI.API.Services
{
    public class BancoService : IBancoService
    {
        public Task<ResponseGenerico<BancoResponse>> BuscarBancoPorCodigo(string codigo)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseGenerico<List<BancoResponse>>> BuscarBancos()
        {
            throw new NotImplementedException();
        }
    }
}
