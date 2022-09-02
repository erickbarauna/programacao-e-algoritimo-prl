using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX03_PRL_081122
{
    class Program
    {
        static void Main(string[] args)
        {
            float P1;
            float P2;
            float P3;
            float PF;

            Console.WriteLine("Digite o valor da P1: ");
            Console.SetCursorPosition(22, 0);
            P1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da P2: ");
            Console.SetCursorPosition(22, 1);
            P2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da P3: ");
            Console.SetCursorPosition(22, 2);
            P3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da PF: ");
            Console.SetCursorPosition(22, 3);
            PF = float.Parse(Console.ReadLine());

            float MP = (P1 + P2 + P3) / 3;
            float MF = (MP + (2 * PF)) / 3;

            Console.WriteLine("\nValor da média final: " + MF);

            Console.ReadLine();
            Console.Clear();
        }
    }
}
