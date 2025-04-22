using Academia.Domain.Utils;

namespace Academia.Domain.ValueObjects
{
    public class CNPJ
    {
        public string Valor { get; private set; }

        public CNPJ(string valor)
        {
            if(!CNPJValidator.Validar(valor))
                throw new ArgumentException("CNPJ inválido.");

            Valor = valor;
        }

        public override string ToString() => Valor;
    }
}