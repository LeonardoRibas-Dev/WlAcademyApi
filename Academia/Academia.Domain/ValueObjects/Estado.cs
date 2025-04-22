namespace Academia.Domain.ValueObjects
{
    public class Estado
    {
        public string nome { get; private set; }
        public string sigla { get; private set; }
        public Pais pais { get; private set; }

        public Estado(string nome, string sigla, Pais pais)
        {
            this.nome = nome;
            this.sigla = sigla;
            this.pais = pais;
        }
    }
}