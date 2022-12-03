using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex033_PRL_120322
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Frase, Letra; // Variavel de Texto - Entrada
            int Tamanho, Contador = 1; // Variável Inteira - Saída 

            Console.Clear(); // Limpa tela
            Console.WriteLine("Digite uma frase: "); // Interface 1
            Console.SetCursorPosition(18, 0); // Posição 1
            Frase = Console.ReadLine(); // Entrada 1

            Tamanho = Frase.Length; // Processo 1

            for (int i = 0; i < Tamanho; i++) // Laço 1 - Para
            {
                Letra = Frase.Substring(i, 1); // Processo 2
                if (Letra == " ") Contador++; // Condicional 1 - Processo 3
            }

            Console.WriteLine("Número de palavra(s): " + Contador); // Saída 1

            Console.ReadLine();
        }
    }
}
