using System.Text.Json.Serialization;

namespace IntegraBrasilAPI.Domain.Models
{
    public class Banco
    {
        [JsonPropertyName("ispb")]
        public string Ispb { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string Nome { get; set; } = string.Empty;

        [JsonPropertyName("code")]
        public int Codigfo { get; set; }

        [JsonPropertyName("fullname")]
        public string? NomeCompleto { get; set; }
    }
}
