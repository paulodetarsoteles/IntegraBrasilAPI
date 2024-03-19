using IntegraBrasilAPI.API.DTOs;

namespace IntegraBrasilAPI.API.Services.Interfaces
{
    public interface IBancoService
    {
        Task<ResponseGenerico<List<BancoResponse>>> BuscarBancos();

        Task<ResponseGenerico<BancoResponse>> BuscarBancoPorCodigo(string codigo);
    }
}
