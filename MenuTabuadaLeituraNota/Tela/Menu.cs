using Calculo;
using Classes;
using Diretorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela
{
    internal class Menu
    {
        //CONSTANTES
        public const int SAIR_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int MEDIA_ALUNO = 3;
        public const int CADASTRAR_CLIENTES = 4;
        public const int CADASTRAR_USUARIOS = 5;
        public static void Principal()
        {
            while (true)
            {
                Console.WriteLine("-------------------- Menu de escolhas -------------------- \n" +
                    "(1) - Leitura de arquivos \n" +
                    "(2) - Tabuada \n" +
                    "(3) - Media de nota \n" +
                    "(4) - Cadastrar clientes \n" +
                    "(5) - Cadastrar usuários \n" +
                    "(0) - Sair do programa");
                int escolhaMenu = int.Parse(Console.ReadLine());


                switch (escolhaMenu)
                {
                    case LER_ARQUIVOS:
                        Ler.Arquivos(1);
                        break;
                    case TABUADA:
                        Console.WriteLine("----------------OPÇÃO TABUADA----------------");
                        Console.Write("Digite o número da tabuada: ");
                        int numero = int.Parse(Console.ReadLine());
                        Tabuada.Conta(numero);
                        break;
                    case MEDIA_ALUNO:
                        Media.Nota();
                        break;
                    case CADASTRAR_CLIENTES:
                        TelaClientes.Chamar();
                        break;
                    case CADASTRAR_USUARIOS:
                        TelaUsuario.Chamar();
                        break;
                    case SAIR_PROGRAMA:
                        return;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }

                Console.WriteLine("\nDeseja limpar a tela?");
                int limpaTela = int.Parse(Console.ReadLine());
                if (limpaTela == 1)
                {
                    Console.Clear();
                }
            }
        }

    }
}
