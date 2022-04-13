using System.Text;
using SistemaDeCobranca.Data;
using SistemaDeCobranca.Domain;

namespace SistemaDeCobranca.Services
{
    public class ClientService
    {
        ClientRepository meuSistema = new ClientRepository();


        public int ListSize()
        {
            var qtd = meuSistema.GetAll().Count;
            return qtd;
        }

        public string Create(string nome, string fone)
        {
            int idClient = ListSize() + 1;
            meuSistema.Save(new Domain.Client(idClient, nome, fone));
            return "Cliente criado com sucesso.";
        }

        public string ListClients()
        {
            var builder = new StringBuilder();
            var listaClientes = meuSistema.GetAll();
            var qtdClientes = ListSize();

            if (qtdClientes == 0)
                builder.AppendLine("Lista vazia");
            else
            {
                foreach(Client cliente in listaClientes)
                {
                    builder.AppendLine($"Id: {cliente.Id} Nome: {cliente.Nome} Fone: {cliente.Fone}");
                }
            }
            return builder.ToString();   
        }

        public string DeleteClient(int idCliente)
        {

            var builder = new StringBuilder();

            if(ListSize().Equals(0))
            {
                builder.AppendLine("Lista vazia");
                return builder.ToString();
            }

            var cliente = meuSistema.GetById(idCliente);

            if(cliente == null)
            {
                builder.AppendLine("Id inexistente");
                return builder.ToString();
            }
            meuSistema.Delete(cliente);
            
            builder.AppendLine("Cliente excluído");
            return builder.ToString();
            
        }

        public string UpdateClient(int idCliente, string nome, string fone)
        { 
            var builder = new StringBuilder();

            if(ListSize().Equals(0))
            {
                builder.AppendLine("Lista vazia");
                return builder.ToString();
            }

            var cliente = meuSistema.GetById(idCliente);

            if(cliente == null)
            {
                builder.AppendLine("Id inexistente");
                return builder.ToString();
            }
            meuSistema.Update(new Client(idCliente,nome,fone));

            builder.AppendLine("Cliente Editado");
            return builder.ToString();

        }
        
    }
}