using System.Collections.Generic;
using SistemaDeCobranca.Domain;

namespace SistemaDeCobranca.Data
{
    public class CobrancaRepository
    {
        private List<Cobranca> listCobranca = new List<Cobranca>();
        private List<Client> listClient;
        public List<Cobranca> GetAll()
        {
            return listCobranca;
        }
        public void SaveCobra(Cobranca cobranca)
        {
            listCobranca.Add(cobranca);
        }
        public Client GetById(int idCliente)
        {
            return listClient.Find(p => p.Id == idCliente);
        }
    }
}