using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    internal class Tabuada
    {
        public static void Conta(int numero)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("-------------------TABUADA-------------------");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} X {i} = {i * numero}");
            }
            Console.WriteLine("---------------------------------------------");
        }
    }
}
