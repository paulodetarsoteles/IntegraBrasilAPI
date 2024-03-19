namespace IntegraBrasilAPI.API.DTOs
{
    public class BancoResponse
    {
        public string Ispb { get; set; } = string.Empty;

        public string NomeAbreviado { get; set; } = string.Empty;

        public int Codigo { get; set; }

        public string? NomeCompleto {  get; set; }
    }
}
