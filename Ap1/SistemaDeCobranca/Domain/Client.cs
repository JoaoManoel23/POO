namespace SistemaDeCobranca.Domain
{
    public class Client
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Fone { get; set; }

        public Client(int id, string nome, string fone)
        {
            this.Id = id;
            this.Nome = nome;
            this.Fone = fone;
        }


    }
}