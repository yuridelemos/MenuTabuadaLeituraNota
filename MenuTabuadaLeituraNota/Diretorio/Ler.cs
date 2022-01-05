using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diretorio
{
    internal class Ler
    {
        private static string caminhoArquivo()
        {
            return ConfigurationManager.AppSettings["CaminhoArquivos"];
        }
        public static void Arquivos(int posicao)
        {
            string localArquivo = caminhoArquivo() + "arq" + posicao + ".txt";
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
            string localArquivo2 = caminhoArquivo() + "arq" + (posicao + 1) + ".txt";
            if (File.Exists(localArquivo2))
            {
                Arquivos(posicao + 1);
            }


        } 
    }
}
