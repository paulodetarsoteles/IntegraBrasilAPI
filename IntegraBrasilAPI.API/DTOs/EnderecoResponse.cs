using System.Text.Json.Serialization;

namespace IntegraBrasilAPI.API.DTOs
{
    public class EnderecoModel
    {
        public string Cep { get; set; } = string.Empty;

        public string Estado { get; set; } = string.Empty;

        public string Cidade { get; set; } = string.Empty;

        public string? Bairro { get; set; }

        public string? Rua { get; set; }

        [JsonIgnore]
        public string? Servico { get; set; }
    }
}
