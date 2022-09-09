using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex015c_PRL_090822
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero;  // Variável inteira - entrada

            Console.Clear();  // Limpa tela
            Console.WriteLine("Digite um número: ");  // Interface 1
            Console.SetCursorPosition(18, 0);  // Posição 1
            Numero = int.Parse(Console.ReadLine());  // Entrada 1

            if (Numero > 50 && Numero <= 90)  // Condicional 1
            {
                Console.WriteLine($"Número: {Numero}");  // Saída 1
            }
            else  // Negação de condicional
            {

            }

            Console.ReadLine();
        }
    }
}
