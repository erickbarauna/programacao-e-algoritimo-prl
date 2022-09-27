using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_While_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  instruções "do-while", "while" e "continue"

            Random random = new Random();
            int current = random.Next(1, 11);

            /* 01
            do
            {
                current = random.Next(1, 11);
                Console.WriteLine(current);
            } while (current != 7); // No momento q a condição for == a 7 o programa para
            */

            /* 02
            while (current >= 3) // Executa se a condição for menor q 3
            {
                Console.WriteLine(current);
                current = random.Next(1, 11);
            }
            Console.WriteLine($"Last number: {current}");
            */

            /* 03
            do
            {
                current = random.Next(1, 11);

                if (current >= 8) continue; // Pula o bloco de cód direto para o while, nesse caso, se o if for true, ele pulará o Console.WriteLine

                Console.WriteLine(current);
            } while (current != 7);
            */

            Console.ReadLine();
        }
    }
}
