using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex022b_PRL_100722
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero; // Variavel Real - Entrada
            int tamanho; // Variavel inteira - Entrada

            double soma = 0; // Variavel - Real
            int contador = 1; // Variavel - Inteira

            double media; // Variavel real- Saída

            Console.Clear(); // Limpa tela
            Console.WriteLine("Digite o tamanho da lista: "); // Interface 1
            Console.SetCursorPosition(26, 0); // Posição 1
            tamanho = int.Parse(Console.ReadLine()); // Entrada 1

            while (contador <= tamanho)
            {
                Console.WriteLine("Digite um número: [   ]"); // Interface 2
                Console.SetCursorPosition(20, contador); // Posição 2
                numero = int.Parse(Console.ReadLine()); // Entrada 2
                soma += numero; // Processo 1
                contador++; // Processo 2
            }

            media = soma / tamanho; // Processo 3
            Console.WriteLine($"Média: {media}"); // Saída 1
            Console.ReadLine();
        }
    }
}
