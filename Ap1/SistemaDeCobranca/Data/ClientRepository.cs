using System.Collections.Generic;
using SistemaDeCobranca.Domain;

namespace SistemaDeCobranca.Data
{
    public class ClientRepository
    {
        private List<Client> listClient = new List<Client>();

        public List<Client> GetAll()
        {
            return listClient;
        }

        public Client GetById(int idCliente)
        {
            return listClient.Find(p => p.Id == idCliente);
        }
        
        public Client GetByName(string nomeCliente)
        {
            return listClient.Find(p => p.Nome == nomeCliente);
        }

        public void Save(Client cliente)
        {
            listClient.Add(cliente);
        }

        public void Update(Client cliente)
        {
            var edit = GetById(cliente.Id);

            edit.Nome = cliente.Nome;
            edit.Fone = cliente.Fone;
        }

        public void Delete(Client cliente)
        {
            listClient.Remove(cliente);
        }

    }
}