using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex019_PRL_092222_2_ATV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int OP = 0;  // Variavel inteira - Entrada
            double LadoQuad, BaseTrian, AlturaTrian = 0;  // Variavel real - Entrada
            double Resultado = 0;  // Variavel inteira - Saída

            try
            {
                Console.Clear();  // Limpa tela
                Console.WriteLine("Escolha a figura desejada para calcular a área: ");  // Interface 1
                Console.WriteLine("1 - Quadrado.");  // Interface 2
                Console.WriteLine("2 - Triângulo.");  // Interface 3
                Console.WriteLine("Digite a figura desejada: ");  // Interface 4
                Console.SetCursorPosition(26, 3);  // Posição 1
                OP = int.Parse(Console.ReadLine());  // Entrada 1

                switch (OP)  // Dispositivo de escolha
                {
                    case 1:  // Opção 1

                        Console.WriteLine("Digite o valor do lado: ");  // Interface 5
                        Console.SetCursorPosition(24, 4);  // Posição 2
                        LadoQuad = double.Parse(Console.ReadLine());  // Entrada 2

                        Resultado = LadoQuad * LadoQuad;  // Processo 1

                        Console.WriteLine("O valor da área do Quadrado é: " + Resultado);  // Saída 1
                        break;

                    case 2:  // Opção 2

                        Console.WriteLine("Digite o valor da base: "); // Interface 6
                        Console.SetCursorPosition(24, 4); // Posição 3
                        BaseTrian = double.Parse(Console.ReadLine());  // Entrada 3

                        Console.WriteLine("Digite o valor da altura: ");  // Interface 7
                        Console.SetCursorPosition(26, 5);  // Posição 4
                        AlturaTrian = double.Parse(Console.ReadLine());  // Entrada 4

                        Resultado = (BaseTrian * AlturaTrian) / 2;   // Processo 2

                        Console.WriteLine("O valor da área do Triângulo é: " + Resultado);  // Saída 2
                        break;

                    default:

                        Console.WriteLine("Digite uma opção válida!");  // Saída 3
                        break;

                }
            }
            catch
            {
                Console.WriteLine("Digite um número válido!");  // Saída 4
            }
            Console.ReadLine();
        }
    }
}
