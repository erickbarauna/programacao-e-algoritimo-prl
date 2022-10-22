using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex023_PRL_102022
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanho; // Variavel inteira - Entrada
            int Op; // Variavel inteira - Entrada
            int contador = 0; // Variavel inteira - Saída

            Console.Clear(); // Limpa Tela
            Console.WriteLine("\nDigite o tamanho: "); // Interface 1
            Console.SetCursorPosition(18, 1); // Posição 1
            tamanho = int.Parse(Console.ReadLine()); // Entrada 1

            Console.WriteLine("\n1 - Contador Para"); // Interface - Menu
            Console.WriteLine("2 - Contador Enquanto"); // Interface - Menu

            Console.WriteLine("\nDigite a opção: "); // Interface 2
            Console.SetCursorPosition(16, 6); // Posição 2
            Op = int.Parse(Console.ReadLine()); // Entrada 2

            switch (Op) // Dispositivo de Escolha 1
            {
                case 1: // Opção 1
                    for (int i = 0; i < tamanho; i++) // Laço 1 - Para
                    {
                        Console.WriteLine($"Número: {i}"); // Saída 2 
                    }
                    break;

                case 2: // Opção 2
                    while (contador < tamanho) // Laço 2 - Enquanto
                    {
                        Console.WriteLine($"Numero: {contador}"); // Saída 2
                        contador++; // Processo 1
                    }
                    break;

                default:
                    Console.WriteLine("O valor digitado não é válido!"); // Opção Padrão
                    contador = 0; // Processo 5
                    break;
            }
            Console.ReadLine();
        }
    }
}
