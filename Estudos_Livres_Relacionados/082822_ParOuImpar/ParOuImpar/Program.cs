using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParOuImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double NumeroDeEntrada;  // Variavel real Entrada


            Console.Clear();  // Limpa tela
            Console.WriteLine("Digite um número e descubra se ele é par ou impar: ");  // Interface 1
            Console.SetCursorPosition(51, 0);  // Posição 1
            NumeroDeEntrada = Convert.ToDouble(Console.ReadLine());  // Entrada 1


            if (NumeroDeEntrada % 2 == 0){  // Processo 1
                Console.WriteLine("\n" + NumeroDeEntrada + " é PAR!");  // Saída 1
            }
            else
            {
                Console.WriteLine("\n" + NumeroDeEntrada + " é IMPAR");  // Saída 2
            }


            Console.ReadLine(); 
        }
    }
}
