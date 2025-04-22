namespace Academia.Domain.ValueObjects
{
    public class Pais
    {
        public string nome { get; private set; }
        public string sigla { get; private set; }

        public Pais(string nome, string sigla)
        {
            this.nome = nome;
            this.sigla = sigla;
        }
    }
}