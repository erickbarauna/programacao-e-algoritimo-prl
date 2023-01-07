using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    internal class Tabuada
    {
        public static void Calcular(int numero)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{numero} X {i} = {numero * i}");
            }
            Console.WriteLine("==========");
        }
    }
}
