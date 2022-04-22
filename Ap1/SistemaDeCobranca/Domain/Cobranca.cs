using System;

namespace SistemaDeCobranca.Domain
{
    public class Cobranca
    {
        public Cobranca(int id, DateTime dataEmi, DateTime dataVenc, int valor, DateTime dataPag, Client cliente)
        {
            Id = id;
            DataEmi = dataEmi;
            DataVenc = dataVenc;
            Valor = valor;
            DataPag = dataPag;
            Cliente = cliente;

        }

        public int Id{get; set; }
        public DateTime DataEmi { get; set; }
        public DateTime DataVenc { get; set; }
        public int Valor { get; set; }
        public DateTime DataPag { get; set; }
        public Client Cliente { get; set; }

    }
}