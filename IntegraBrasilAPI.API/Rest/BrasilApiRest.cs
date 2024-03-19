using IntegraBrasilAPI.API.DTOs;
using IntegraBrasilAPI.API.Rest.Interfaces;
using IntegraBrasilAPI.Domain.Models;

namespace IntegraBrasilAPI.API.Rest
{
    public class BrasilApiRest : IBrasilApiRest
    {
        public Task<ResponseGenerico<Banco>> BuscarBancoPorCodigo(string codigo)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseGenerico<List<Banco>>> BuscarBancos()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseGenerico<Endereco>> BuscarEndercoPorCEP(string cep)
        {
            throw new NotImplementedException();
        }
    }
}
