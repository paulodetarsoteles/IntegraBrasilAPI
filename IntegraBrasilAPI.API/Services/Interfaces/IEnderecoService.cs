using IntegraBrasilAPI.API.DTOs;

namespace IntegraBrasilAPI.API.Services.Interfaces
{
    public interface IEnderecoService
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEndercoPorCEP(string cep);
    }
}
