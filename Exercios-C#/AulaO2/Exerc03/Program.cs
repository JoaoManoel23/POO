using System;

namespace Exerc03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Hora hora = new Hora(23, 01, 03);

            Console.WriteLine(
                "Hora:"+hora.GetHora()+" "+
                "Minuto:"+hora.GetMinuto()+" "+
                "Segundo:"+hora.GetSegundo()
            );
            hora.VerificarHora();
        }
    }
}
