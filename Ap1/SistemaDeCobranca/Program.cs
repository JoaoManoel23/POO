using System;
using SistemaDeCobranca.Controllers;

namespace SistemaDeCobranca
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientController control = new ClientController(); 

            control.Menu();
        }
    }
}
