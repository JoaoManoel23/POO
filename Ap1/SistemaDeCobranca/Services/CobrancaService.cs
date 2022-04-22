using System; 
using System.Text;
using SistemaDeCobranca.Data;
using SistemaDeCobranca.Domain;

namespace SistemaDeCobranca.Services
{
    public class CobrancaService
    {
        CobrancaRepository meuSistemaCobra = new CobrancaRepository();
        ClientRepository meuSistema;
        


        public int ListSize()
        {
            var qtd = meuSistemaCobra.GetAll().Count;
            return qtd;
        }
        
        public string CreateCobra(DateTime dataEmi,DateTime dataVenc, int valor, DateTime dataPag,int idCliente)
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
            int idCobranca = ListSize()+1;
            meuSistemaCobra.SaveCobra(new Domain.Cobranca(idCobranca,dataEmi,dataVenc,valor,dataPag,cliente));
            
            builder.AppendLine("Cobranca adicionada");
            return builder.ToString();
        }
    }
}