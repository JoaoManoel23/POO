using System;

namespace Exerc02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Data data = new Data(40,14,-2003);

            
            Console.WriteLine(
                "Dia:"+data.GetDia()+" "+
                "Mês:"+data.GetMes()+" "+
                "Ano:"+data.GetAno()
            );
            data.VerificarData();
        }
    }
}
