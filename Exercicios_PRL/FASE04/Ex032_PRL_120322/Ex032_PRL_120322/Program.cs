using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex032_PRL_120322
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Palavra; // Variável de Texto - Entrada 
            int Tamanho; // Variável inteira - Saída 

            Console.Clear();
            Console.WriteLine("Digite uma palavra: "); // Interface 1
            Console.SetCursorPosition(21, 0); // Posição 1
            Palavra = Console.ReadLine(); // Entrada 1

            Tamanho = Palavra.Length; // Processso 1

            Console.WriteLine("Número de caracteres: " + Tamanho); // Saída 1

            Console.ReadLine();
        }
    }
}
