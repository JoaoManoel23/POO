using System;

namespace Exerc01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculo calculo = new Calculo(10,10);

            Console.WriteLine(
                "Base:"+
                calculo.GetB()+" Altura:"+
                calculo.GetH()+" A area do triangulo é de:"+
                calculo.GetResul()
            );
        }
    }
}
