using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex022_PRL_100722
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero; // Variavel inteira - Entrada
            double media = 0; // Variavel real - Saída
            int tamanho = 0; // Variavel inteira - Entrada
            double soma = 0; // Variavel real - Entrada

            Console.Clear(); // Limpa tela
            Console.WriteLine("Digite o tamanho da lista: "); // Interface 1
            Console.SetCursorPosition(27, 0); // Posição 1
            tamanho = int.Parse(Console.ReadLine()); // Entrada 1

            for (int i = 1; i <= tamanho; i++) // Consdicional 1
            {
                Console.WriteLine($"Digite o {i}° número: "); // Interface 2
                Console.SetCursorPosition(19, i); // Posição 2
                numero = int.Parse(Console.ReadLine()); // Entrada 2
                soma += numero; // Processo 1
            }

            media = soma / tamanho; // Proceso 2
            Console.WriteLine($"A média dos {tamanho} numeros é: {media}"); // Saída 1
            Console.ReadLine();
        }
    }
}
