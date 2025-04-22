using Academia.Domain.ValueObjects;

namespace Academia.Domain.Entities
{
    public class Academia
    {
        public int id { get; private set;}
        public string razaoSocial { get; private set; }
        public string nomeFantasia { get; private set; }
        public CNPJ CNPJ { get; private set; }
        public Endereco endereco { get; private set; }

        public Academia(string razaoSocial, string nomeFantasia, CNPJ CNPJ, Endereco endereco)
        {
            if (string.IsNullOrEmpty(razaoSocial))
                throw new ArgumentException("Razão Social não pode ser vazia.");
            if (string.IsNullOrEmpty(nomeFantasia))
                throw new ArgumentException("Nome Fantasia não pode ser vazio.");
            if (endereco == null)   
                throw new ArgumentNullException(nameof(endereco), "Endereço não pode ser nulo.");

            this.razaoSocial = razaoSocial;
            this.nomeFantasia = nomeFantasia;
            this.CNPJ = CNPJ;
            this.endereco = endereco;
        }

    }
}