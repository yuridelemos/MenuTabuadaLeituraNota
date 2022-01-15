using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class TelaUsuario
    {
        public static void Chamar()
        {
            Console.WriteLine("===============Menu de Usuários===============");
            while (true)
            {
                string mensagem = "Digite uma das opções abaixo\n" +
                    "(1) - Cadastrar Usuários\n" +
                    "(2) - Listar Usuários\n" +
                    "(0) - Sair de Cadastro";
                Console.WriteLine(mensagem);

                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        return;
                    case 1:
                        Usuario usuario = new Usuario();

                        Console.WriteLine("Digite o nome do usuário: ");
                        usuario.Nome = Console.ReadLine();

                        Console.WriteLine("Digite o telefone do usuário: ");
                        usuario.Telefone = Console.ReadLine();

                        Console.WriteLine("Digite o CPF do usuário: ");
                        usuario.CPF = Console.ReadLine();
                        usuario.Gravar();
                        break;

                    case 2:
                        var usuarios = new Usuario().Ler();
                        foreach(var u in usuarios)
                        {
                            Console.WriteLine(u.Nome);
                            Console.WriteLine(u.Telefone);
                            Console.WriteLine(u.CPF);
                            Console.WriteLine("======================");
                        }
                        break;
                    default: 
                        Console.WriteLine("Opção digitada é invalida. Tente novamente.");
                        break;

                }
            }
        }
    }
}
