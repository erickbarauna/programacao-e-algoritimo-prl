using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_PRL_081922
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double MOTO, AUTO, BIKE, METROS; // Variaveis real Entrada
            double KM; // Variavel real Saída


            Console.Clear(); // Limpa tela
            Console.WriteLine("Digite o percurso da Moto em metros: "); // Interface 1
            Console.SetCursorPosition(37, 0); // Posição 1
            MOTO = double.Parse(Console.ReadLine()); // Entrada 1

            Console.Clear(); // Limpa tela
            Console.WriteLine("Digite o percurso do Automóvel em metros: "); // Interface 2
            Console.SetCursorPosition(42, 0); // Posição 2
            AUTO = double.Parse(Console.ReadLine()); // Entrada 2

            Console.Clear(); // Limpa tela
            Console.WriteLine("Digite o percurso da Bicicleta em metros: "); // Interface 3
            Console.SetCursorPosition(42, 0); // Posição 3
            BIKE = double.Parse(Console.ReadLine()); // Entrada 3

            METROS = MOTO + AUTO + BIKE; // Processo 1
            KM = METROS / 1000; // Processo 2

            Console.Clear(); // Limpa tela
            Console.WriteLine("A soma dos percursos em metros convertido para" +
            " Quilômetros será: " + KM + "Km"); // Saída 1

            Console.ReadLine();
        }
    }
}
