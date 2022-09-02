using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_PRL_081222
{
    class Program
    {
        static void Main(string[] args)
        {
            double TC;

            Console.WriteLine("Digite a Temperatura em C°: ");
            Console.SetCursorPosition(28, 0);
            TC = double.Parse(Console.ReadLine());

            double TF = 1.8 * TC + 32;

            Console.WriteLine("A temperatura convertida para Farenheit é: " + TF);

            Console.ReadLine();
        }
    }
}
