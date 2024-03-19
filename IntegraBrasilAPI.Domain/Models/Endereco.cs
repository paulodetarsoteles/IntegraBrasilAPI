using System.Text.Json.Serialization;

namespace IntegraBrasilAPI.Domain.Models
{
    public class Endereco
    {
        [JsonPropertyName("cep")]
        public string Cep { get; set; } = string.Empty;

        [JsonPropertyName("state")]
        public string Estado { get; set; } = string.Empty;

        [JsonPropertyName("city")]
        public string Cidade { get; set; } = string.Empty;

        [JsonPropertyName("neighborhood")]
        public string? Bairro { get; set; }

        [JsonPropertyName("street")]
        public string? Rua { get; set; }

        [JsonPropertyName("service")]
        public string? Servico { get; set; }
    }
}
