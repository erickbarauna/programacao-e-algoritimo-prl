using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex013_PRL_090222
{
    class Program
    {
        static void Main(string[] args)
        {
            double SBase;  // Variavel real - 
            double Graf;  // Variavel real - 
            double SB;  // Variavel real -
            double SL;  // Variavel real -
            double IR;  // Variavel real -

            Console.Clear();  // Limpa tela
            Console.WriteLine("Digite o salário base: ");  // Interface 1
            Console.SetCursorPosition(23, 0);  // Posição 1
            SBase = Convert.ToDouble(Console.ReadLine());  // Entrada 1

            Console.WriteLine("Digite a Gratificação: ");  // Interface 2
            Console.SetCursorPosition(23, 1); // Posição 2
            Graf = Convert.ToDouble(Console.ReadLine());  // Entrada 2

            SB = SBase + Graf;  // Processo 1

            if (SB > 2000)  // Condicional 1
            {
                IR = SB * 0.15;  // Processo 2
            }
            else  // Negação Condicional
            {
                IR = SB * 0.11;  // Processo 3
            }

            SL = SB - IR; // Processo 4

            Console.WriteLine("Salário Base: " + SB);  // Saída 1
            Console.WriteLine("Salário Bruto: " + SB);  // Saída 2
            Console.WriteLine("Imposto de Renda: " + IR); // Saída 3
            Console.ForegroundColor = ConsoleColor.Green;  // Muda cor da fonte
            Console.WriteLine("Salário Líquido: " + SL);  // Saída 4

            Console.ReadLine();
        }
    }
}
