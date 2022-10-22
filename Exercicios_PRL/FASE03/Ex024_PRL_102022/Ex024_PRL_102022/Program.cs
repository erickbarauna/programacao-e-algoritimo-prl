using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex024_PRL_102022
{
    class Program
    {
        static long Fatorial(int N) // função - Fatorial
        {
            if (N <= 1) // Condicional 1
            {
                return 1; // Retorna para o código
            }
            else
            {
                return N * Fatorial(N - 1); // Retorna para o código
            }
        }
        static void Main(string[] args)
        {
            int Numero; // Variavel inteira - Entrada

            Console.Clear(); // Limpa tela
            Console.WriteLine("Digite um número para fatorar: [      ]"); // Interface 1
            Console.SetCursorPosition(32, 0); // Posição 1
            Numero = int.Parse(Console.ReadLine()); // Entrada 1

            Console.ForegroundColor = ConsoleColor.Green; // Cor Letra

            for (int i = 0; i <= Numero; i++)
            {
                Console.WriteLine("{0}! = {1}", i, Fatorial(i)); // Criando lista no Console - Saída 1
            }
            Console.ReadLine();
        }
    }
}
