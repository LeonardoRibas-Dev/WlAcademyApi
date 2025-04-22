namespace Academia.Domain.ValueObjects
{
    public class Endereco
    {
        public string rua { get; private set; }
        public string numero { get; private set; }
        public string bairro { get; private set; }
        public Cidade cidade { get; private set; }
        public string cep { get; private set; }

        public Endereco(string rua, string numero, string bairro, Cidade cidade, string cep)
        {
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
            this.cep = cep;
        }

    }
}