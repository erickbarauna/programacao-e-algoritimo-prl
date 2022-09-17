using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex018_PRL_091622
{
    class Program
    {
        static void Main(string[] args)
        {
            double VALOR1, VALOR2 = 0;  // Variavel real - Entrada
            int OPCAO = 0; // Variavel inteira - Entrada
            double RESULTADO = 0;  // Variavel real - Saída

            Console.Clear();  // Limpa tela
            Console.WriteLine("Digite o 1° Valor: ");  // Interface 1
            Console.SetCursorPosition(19, 0);  // Posição 1
            VALOR1 = double.Parse(Console.ReadLine()); // Entrada 1

            Console.WriteLine("Digite o 2° Valor: ");  // Interface 2
            Console.SetCursorPosition(19, 1);  // Posição 2
            VALOR2 = double.Parse(Console.ReadLine()); // Entrada 2

            Console.WriteLine("Escola uma das opções:" +  // Interface 2
            "\n1. Adição" +
            "\n2. Multiplicação" +
            "\n3. Subtração" +
            "\n4. Divisão" +
            "\n5. Resto da Divisão" +
            "\n6. Potênciação" +
            "\n7. Raiz");

            Console.WriteLine("Digite a opção desejada: ");  // Interface 3
            Console.SetCursorPosition(25, 10);  // Posição 3
            OPCAO = int.Parse(Console.ReadLine());  // Entrada 3

            switch (OPCAO)  // Dispositivo de escolha 
            {
                case 1:  // Opção  1
                    RESULTADO = VALOR1 + VALOR2;
                    break;
                case 2:  // Opção 2
                    RESULTADO = VALOR1 * VALOR2;
                    break;
                case 3:  // Opção 3
                    RESULTADO = VALOR1 - VALOR2;
                    break;
                case 4:  // Opção 4
                    RESULTADO = VALOR1 / VALOR2;
                    break;
                case 5:  // Opção 5
                    RESULTADO = VALOR1 % VALOR2;
                    break;
                case 6:  // Opção 6
                    RESULTADO = Math.Pow(VALOR1, VALOR2);
                    break;
                case 7:  // Opção 7
                    RESULTADO = Math.Sqrt(VALOR1);
                    break;
                default: 
                    Console.WriteLine("Digite uma opção válida!");  // Saída 1
                    break;
            }

            Console.WriteLine($"Resultado: {RESULTADO}");  // Saída 2
            Console.ReadLine();
        }
    }
}
