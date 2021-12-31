using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    class Media
    {
        public static void Nota()
        {
            Console.Write("Digite o nome do aluno: ");
            string nomeAluno = Console.ReadLine();
            double qtdNotas = 3;

            Console.WriteLine($"Digite as {qtdNotas} notas do aluno {nomeAluno}");

            List<double> notas = new List<double>();
            double notaTotal = 0;
            for (int i = 1; i <= qtdNotas; i++)
            {
                Console.Write($"Digite a {i} nota: ");
                double nota = double.Parse(Console.ReadLine());
                notaTotal += nota;
                notas.Add(nota);
            }
            double media = notaTotal / notas.Count;
            Console.WriteLine($"A media do {nomeAluno} é {media:F2}");
            Console.WriteLine("Suas notas são: ");
            foreach (double i in notas)
            {
                Console.Write($"Nota: {i}\n");
            }
            //Fazer com lista
        }
    }
}
