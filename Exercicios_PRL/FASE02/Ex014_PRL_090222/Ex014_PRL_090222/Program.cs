using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex014_PRL_090222
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero;  // Variavel inteira - Entrada
            string Status = "";  // Variavel de texto - Saída

            Console.Clear();  // Limpa tela
            Console.WriteLine("Digite um número: ");  // Interface 1
            Console.SetCursorPosition(18, 0);  // Posição 1
            Numero = int.Parse(Console.ReadLine());  // Entrada 1

            if (Numero != 0)  // Condicional 1
            {
                if (Numero > 0)  // Condicional 2
                {
                    Status = "Positivo";  // Processo 1
                }
                else  // Negação Condicional 2
                {
                    Status = "Negativo";  // Processo 2
                }
            }
            else// Negação Condicional 1
            {
                Status = "Neutro";  // Processo 3
            }

            Console.WriteLine("Status: " + Status);  // Saída 1

            Console.ReadLine();        
        }
    }
}
