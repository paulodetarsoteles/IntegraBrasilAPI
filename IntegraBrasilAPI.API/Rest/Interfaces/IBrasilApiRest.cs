using IntegraBrasilAPI.API.DTOs;
using IntegraBrasilAPI.Domain.Models;

namespace IntegraBrasilAPI.API.Rest.Interfaces
{
    public interface IBrasilApiRest
    {
        Task<ResponseGenerico<Endereco>> BuscarEndercoPorCEP(string cep);

        Task<ResponseGenerico<List<Banco>>> BuscarBancos();

        Task<ResponseGenerico<Banco>> BuscarBancoPorCodigo(string codigo);
    }
}
