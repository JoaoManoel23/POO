using System;
using TesteAula02.Entities;

namespace TesteAula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Autor oAutor = new Autor(10,"João Manoel");
            Livro objLivro = new Livro(100,"C# POO",oAutor);

            Console.WriteLine(
                objLivro.GetId()+" - "+
                objLivro.GetTitulo()+ " - "+
                objLivro.GetValor()+ " Autor: "+
                objLivro.Autor.Nome);
            
            objLivro.SetValor(199);
            Console.WriteLine("valor do livro: " + objLivro.GetValor());

        }
    }
}
