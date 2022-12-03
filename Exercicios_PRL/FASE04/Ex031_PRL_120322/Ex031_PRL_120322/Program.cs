using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex031_PRL_120322
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Palavra; // Variável de Texto - Entrada
            string Maiusculo, Minusculo; // Variavel de Texto - Saída

            Console.Clear();
            Console.WriteLine("Digite uma palavra: "); // Interface 1
            Console.SetCursorPosition(21, 0); // Posição 1
            Palavra = Console.ReadLine(); // Entrada 1

            Maiusculo = Palavra.ToUpper(); // Processo 1
            Minusculo = Palavra.ToUpper(); // Processo 2

            Console.WriteLine("Maiusculo: " + Maiusculo); // Saída 1
            Console.WriteLine("Minusculo: " + Minusculo); // Saída 2

            Console.ReadLine();
        }
    }
}
