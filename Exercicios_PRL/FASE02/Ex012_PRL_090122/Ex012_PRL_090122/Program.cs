using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex012_PRL_090122
{
    class Program
    {
        public static ConsoleColor ConsoleColor { get; private set; }

        static void Main(string[] args)
        {
            double Numero1;  // Variavel real - Entrada
            double Numero2;  // Variavel real - Entrada
            double Maior;  // Variavel real - Saída

            Console.Clear();  // Limpa Tela
            Console.WriteLine("Digite o número 1: ");  // Interface 1
            Console.SetCursorPosition(19, 0);  // Posição 1
            Numero1 = Convert.ToDouble(Console.ReadLine());  // Entrada 1

            Console.WriteLine("Digite o número 2: ");  // Interface 2
            Console.SetCursorPosition(19,1);  // Posição 2
            Numero2 = Convert.ToDouble(Console.ReadLine());  // Entrada 2


            if (Numero1 > Numero2)  // Condicional 1
            {
                Maior = Numero1;  // Processo 1
            }
            else // Negação condicional 1
            {
                Maior = Numero2;  // Processo 2
            }

            Console.WriteLine("Maior: " + Maior);  // Saída 1

            Console.ReadLine();               
        }
    }
}
