using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class TelaClientes
    {
        public static void Chamar()
        {
            Console.WriteLine("===============Cadastro de clientes =============");
            while (true)
            {
                string mensagem = "Digite uma das opções abaixo\n" +
                    "(1) - Cadastrar clientes\n" +
                    "(2) - Listar Clientes\n" +
                    "(0) - Sair do Cadastro\n";
                Console.WriteLine(mensagem);

                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        return;
                    case 1:
                        var cliente = new Cliente();

                        Console.WriteLine("Digite o nome do cliente: ");
                        cliente.Nome = Console.ReadLine();

                        Console.WriteLine("Digite o telefone do cliente: ");
                        cliente.Telefone = Console.ReadLine();

                        Console.WriteLine("Digite o CPF do cliente: ");
                        cliente.CPF = Console.ReadLine();
                        cliente.Gravar();
                        break;
                    case 2:
                        var clientes = Cliente.LerClientes();
                        foreach(Cliente c in clientes)
                        {
                            Console.WriteLine(c.Nome);
                            Console.WriteLine(c.Telefone);
                            Console.WriteLine(c.CPF);
                            Console.WriteLine("======================");
                        }
                        break;
                    default:
                        Console.WriteLine("Opção difigtada é inválida");
                        break;

                }
            }

        }
    }
}
