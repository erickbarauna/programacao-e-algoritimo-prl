using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex011_PRL_090122
{
    class Program
    {
        static void Main(string[] args)
        {
            double Numero;  // Variavel real - Entrada

            Console.Clear();  // Limpa tela 
            Console.WriteLine("Digite um número: ");  // Interface 1
            Console.SetCursorPosition(18,0);  // Posição 1
            Numero = Convert.ToDouble(Console.ReadLine());  // Entrada 1

            if (Numero > 100)  // Condocional 1
            {
                Console.WriteLine("Número digitado: " + Numero);  // Saída 1
            }

            Console.ReadLine();
        }
    }
}
