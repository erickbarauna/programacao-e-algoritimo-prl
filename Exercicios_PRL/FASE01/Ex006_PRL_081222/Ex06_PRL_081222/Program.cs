using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_PRL_081222
{
    class Program
    {
        static void Main(string[] args)
        {
            double V1;
            // Valor 1

            double V2;
            // Valor 2

            Console.WriteLine("Digite o primeiro valor: ");
            Console.SetCursorPosition(25, 0);
            V1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            Console.SetCursorPosition(25, 1);
            V2 = double.Parse(Console.ReadLine());

            double SO = (V1 + V2) * 0.2;
            // Soma 

            double PR = (V1 / V2) * 0.3;
            // Produto

            double QD = ((V1 * V1) + (V2 * V2)) * 0.4;
            // Quadrado

            Console.WriteLine("\n20% da soma dos valores é: " + SO + " \n30% do produto dos valores é: " + PR + " \n40% do quadrado dos valores é: " + QD);

            Console.ReadLine();
        }
    }
}
