namespace Academia.Domain.Utils
{
    public static class CNPJValidator
    {
        public static bool Validar(string cnpj)
        {
            // Verifica se o CNPJ é nulo ou vazio ou tem espaços em branco
            if (string.IsNullOrWhiteSpace(cnpj))
                return false;
            
            // Remove caracteres não numéricos
            cnpj = new string(cnpj.Where(char.IsDigit).ToArray());

            // Verifica se o CNPJ tem 14 dígitos e não é uma sequência de dígitos iguais
            // Ex: 11111111111111, 22222222222222, etc.
            if (cnpj.Length != 14 || new string(cnpj[0], cnpj.Length) == cnpj)
                return false;

            // Verifica se o CNPJ é válido usando o algoritmo de validação
            // O CNPJ é composto por 12 dígitos + 2 dígitos verificadores
            // O primeiro dígito verificador é calculado a partir dos 12 primeiros dígitos
            int[] multiplicador1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            // O segundo dígito verificador é calculado a partir dos 13 primeiros dígitos
            string temp = cnpj.Substring(0, 12);
            int soma = 0;

            // Calcula o primeiro dígito verificador
            // Multiplica cada dígito pelo seu respectivo peso e soma os resultados
            for (int i = 0; i < 12; i++)
                soma += int.Parse(temp[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;
            temp += resto.ToString();

            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(temp[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;
            string digitosVerificadores = temp.Substring(12) + resto.ToString();

            // Verifica se os dígitos verificadores calculados são iguais aos dígitos verificadores do CNPJ
            // O CNPJ é considerado válido se os dígitos verificadores calculados forem iguais --
            // -- aos dígitos verificadores do CNPJ
            return cnpj.EndsWith(digitosVerificadores);
        }
    }
}