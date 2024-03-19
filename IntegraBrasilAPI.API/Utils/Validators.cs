using System.Runtime.ConstrainedExecution;

namespace IntegraBrasilAPI.API.Utils
{
    public static class Validators
    {
        public static bool ValidatorCep(string? cep)
        {
            if (string.IsNullOrEmpty(cep) || cep.Length != 8)
                return false;

            char[] letras = cep.ToCharArray();

            foreach (char c in letras)
                if (!char.IsNumber(c))
                    return false;

            return true;
        }

        public static bool ValidatorBankCode(string? code)
        {
            if (string.IsNullOrEmpty(code) || code.Length > 3)
                return false;

            char[] letras = code.ToCharArray();

            foreach (char c in letras)
                if (!char.IsNumber(c))
                    return false;

            return true;
        }
    }
}
