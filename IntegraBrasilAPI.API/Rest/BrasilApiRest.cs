using IntegraBrasilAPI.API.DTOs;
using IntegraBrasilAPI.API.Rest.Interfaces;
using IntegraBrasilAPI.Domain.Models;
using System.Dynamic;
using System.Text.Json;

namespace IntegraBrasilAPI.API.Rest
{
    public class BrasilApiRest : IBrasilApiRest
    {
        private readonly IConfiguration _configuration;

        public BrasilApiRest(IConfiguration configuration) =>
            _configuration = configuration;

        public async Task<ResponseGenerico<Endereco>> BuscarEndercoPorCEP(string cep)
        {
            try
            {
                string? url = _configuration.GetSection("BrasilApiUrl").Value ?? 
                    throw new Exception("Erro ao capturar url no arquivo de configuração.");

                HttpRequestMessage request = new(HttpMethod.Get, $"{url}cep/v1/{cep}");

                ResponseGenerico<Endereco> response = new();

                HttpClient client = new();

                HttpResponseMessage? responseBrasilApi = await client.SendAsync(request) ?? 
                    throw new Exception("Erro na resposta da API do parceiro.");

                string contentResponse = await responseBrasilApi.Content.ReadAsStringAsync();

                Endereco? objectResponse = JsonSerializer.Deserialize<Endereco>(contentResponse);

                response.CodigoHttp = responseBrasilApi.StatusCode;

                if (!responseBrasilApi.IsSuccessStatusCode)
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
                else
                    response.DadosRetorno = objectResponse;

                return response;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<ResponseGenerico<List<Banco>>> BuscarBancos()
        {
            try
            {
                string? url = _configuration.GetSection("BrasilApiUrl").Value ??
                    throw new Exception("Erro ao capturar url no arquivo de configuração.");

                HttpRequestMessage request = new(HttpMethod.Get, $"{url}banks/v1");

                ResponseGenerico <List<Banco>> response = new();

                HttpClient client = new();

                HttpResponseMessage? responseBrasilApi = await client.SendAsync(request) ??
                    throw new Exception("Erro na resposta da API do parceiro.");

                string contentResponse = await responseBrasilApi.Content.ReadAsStringAsync();

                List<Banco>? objectResponse = JsonSerializer.Deserialize<List<Banco>>(contentResponse);

                response.CodigoHttp = responseBrasilApi.StatusCode;

                if (!responseBrasilApi.IsSuccessStatusCode)
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
                else
                    response.DadosRetorno = objectResponse;

                return response;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<ResponseGenerico<Banco>> BuscarBancoPorCodigo(string codigo)
        {
            try
            {
                string? url = _configuration.GetSection("BrasilApiUrl").Value ??
                    throw new Exception("Erro ao capturar url no arquivo de configuração.");

                HttpRequestMessage request = new(HttpMethod.Get, $"{url}banks/v1/{codigo}");

                ResponseGenerico<Banco> response = new();

                HttpClient client = new();

                HttpResponseMessage? responseBrasilApi = await client.SendAsync(request) ??
                    throw new Exception("Erro na resposta da API do parceiro.");

                string contentResponse = await responseBrasilApi.Content.ReadAsStringAsync();

                Banco? objectResponse = JsonSerializer.Deserialize<Banco>(contentResponse);

                response.CodigoHttp = responseBrasilApi.StatusCode;

                if (!responseBrasilApi.IsSuccessStatusCode)
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
                else
                    response.DadosRetorno = objectResponse;

                return response;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
