using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diretorio
{
    internal class Ler
    {
        public static void Arquivos(int posicao)
        {
            string localArquivo = @"C:\arquivos\arq" + posicao + ".txt";
            Console.WriteLine($"\nLendo arquivo{localArquivo}");
            if (File.Exists(localArquivo))
            {
                using (StreamReader arquivo = File.OpenText(localArquivo))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
            string localArquivo2 = @"C:\arquivos\arq" + (posicao + 1) + ".txt";
            if (File.Exists(localArquivo2))
            {
                Arquivos(posicao + 1);
            }


        } // Pesquisar uma maneira de puxar um arquivo do pc

    }
}
