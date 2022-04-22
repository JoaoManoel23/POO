using System.Globalization;
using System;
using SistemaDeCobranca.Services;

namespace SistemaDeCobranca.Controllers
{
    public class ClientController
    {
        
        ClientService service = new ClientService();
        CobrancaService serviceCobra = new CobrancaService();

        public void Menu()
        {

            string op = string.Empty;

            while (op != "0"){
                Console.WriteLine("Digite 1 para adicionar um novo cliente");
                Console.WriteLine("Digite 2 para listar os clientes");
                Console.WriteLine("Digite 3 para excluir um cliente");
                Console.WriteLine("Digite 4 para editar um cliente");
                Console.WriteLine("Digite 5 para adicionar uma cobrança ao cliente");

                Console.WriteLine("Digite 0 para sair da aplicação");
                op = Console.ReadLine();

                switch (op)
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "1":
                        Console.WriteLine("Digite o nome do cliente");
                        string nome = Console.ReadLine().Trim();
                        
                        Console.WriteLine("Digite o número do cliente");
                        string fone = Console.ReadLine().Trim();

                        string ret = service.Create(nome, fone);

                        Console.WriteLine(ret);
                        break;
                    case "2":
                        Console.WriteLine(service.ListClients());
                        break;
                    case "3":
                        Console.WriteLine("Digite o id do cliente");
                        var todosClientes = service.ListClients();
                        if(todosClientes.Contains("vazia"))
                        {
                            Console.WriteLine(todosClientes);
                            Menu();
                        }
                        else
                        {
                            Console.WriteLine(todosClientes);
                        }
                        string idCliente = Console.ReadLine();
                        int idClienteInt = Convert.ToInt32(idCliente);

                        var del = service.DeleteClient(idClienteInt);
                        Console.WriteLine(del);
                        break;
                    case "4":
                        Console.WriteLine("Digite o id do cliente");
                        todosClientes = service.ListClients();
                        if(todosClientes.Contains("vazia"))
                        {
                            Console.WriteLine(todosClientes);
                            Menu();
                        }
                        else
                        {
                            Console.WriteLine(todosClientes);
                        }
                        string idClienteEdit = Console.ReadLine();
                        int idClienteEditInt = Convert.ToInt32(idClienteEdit);

                        Console.WriteLine("Digite o novo nome do cliente");
                        string novoNome = Console.ReadLine().Trim();

                        Console.WriteLine("Digite o novo número do cliente");
                        string novoFone = Console.ReadLine().Trim();

                        var edit = service.UpdateClient(idClienteEditInt, novoNome, novoFone);
                        Console.WriteLine(edit);
                        break;
                    case "5":
                        Console.WriteLine("Digite o id do cliente");
                        todosClientes = service.ListClients();
                        if(todosClientes.Contains("vazia"))
                        {
                            Console.WriteLine(todosClientes);
                            Menu();
                        }
                        else
                        {
                            Console.WriteLine(todosClientes);
                        }
                        string idClienteCobra = Console.ReadLine();
                        int idClienteCobraInt = Convert.ToInt32(idClienteCobra);

                        Console.WriteLine("Digite a data de emissão da cobrança");
                        string dataEmi = Console.ReadLine().Trim();
                        DateTime dataEmid = Convert.ToDateTime(dataEmi);

                        Console.WriteLine("Digite a data de vencimento da cobrança");
                        string dataVenc = Console.ReadLine().Trim();
                        DateTime dataVencd =  Convert.ToDateTime(dataVenc);

                        Console.WriteLine("Digite o valor da cobrança");
                        string valor = Console.ReadLine().Trim();
                        int valorInt = Convert.ToInt32(valor);

                        Console.WriteLine("Digite a data de pagamento da cobrança");
                        string dataPag = Console.ReadLine().Trim();
                        DateTime dataPagd = Convert.ToDateTime(dataPag);

                        var cobra = serviceCobra.CreateCobra(dataEmid,dataVencd,valorInt,dataPagd,idClienteCobraInt);
                        Console.WriteLine(cobra);
                        break;
                    default:
                        Console.WriteLine("inválido");
                        continue;
                }
            }
        }  
        
    }
}