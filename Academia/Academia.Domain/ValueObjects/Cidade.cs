namespace Academia.Domain.ValueObjects
{
    public class Cidade
    {
        public string nome { get; private set; }
        public int IBGE { get; private set; }
        public Estado estado { get; private set; }

        public Cidade(string nome, int IBGE, Estado estado)
        {
            this.nome = nome;
            this.IBGE = IBGE;
            this.estado = estado;
        }
    }
}