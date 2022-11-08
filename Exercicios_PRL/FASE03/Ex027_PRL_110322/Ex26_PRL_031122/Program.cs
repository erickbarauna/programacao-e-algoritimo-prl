using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex26_PRL_031122
{
    class Program
    {
        public static void Linha()
        {
            for (int z = 1; z <= 25; z++)
            {
                Console.Write("==");
            }
        }

        public static void Red()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public static void Green()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public static void White()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Blue()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        static void Main(string[] args)
        {
            string FiguraStr = "";
            int FiguraInt = 0;
            int contadorWhile1 = 7;

            string[] Figuras = new string[] { "Triângulo", "Quadrado", "Retângulo"};

            int Op = 0;
            int contadorWhile2 = 7; 

            double Resultado = 0;
            
            int Valor1, Valor2, Valor3 = 0;

            Console.Clear(); // Limpar Tela
            Linha();
            Console.WriteLine("\n<Opções de Figuras>"); // Interface
            Linha();
            Console.WriteLine("\n1 - Triângulo"); // Interface - Menu
            Console.WriteLine("2 - Quadrado"); // Interface - Menu
            Console.WriteLine("3 - Retângulo"); // Interface - Menu
            Linha();

            while (FiguraInt > 3 || FiguraInt < 1)
            {
                Console.WriteLine("\nDigite a figura desejada: ");
                Console.SetCursorPosition(26, contadorWhile1); // Posição 1
                FiguraStr = Console.ReadLine(); // Entrada 1
                Linha();

                if (int.TryParse(FiguraStr, out FiguraInt))
                {
                    if (FiguraInt > 3 || FiguraInt < 1)
                    {
                        Red();
                        Console.WriteLine("\nOps! Digite uma das 3 opções possíveis!");
                        White();
                        Linha();
                    }
                }
                else
                {
                    Blue();
                    Console.Write("\nPor favor, digite apenas ");
                    Green();
                    Console.Write("números");
                    Blue();
                    Console.Write("!\n");
                    White();
                    Linha();
                }
                contadorWhile1 += 4;
            }

            Console.Clear();
            Linha();
            Console.Write($"\nVocê escolheu a figura ");
            Green();   
            Console.Write(Figuras[FiguraInt - 1]);
            White();
            Console.Write("! \nAgora selecione a opção desejada: "); // Interface
            Console.WriteLine("\n\n1 - Área"); // Interface - Menu
            Console.WriteLine("2 - Perimetro"); // Interface - Menu

            while (Op < 1 || Op > 2)
            {
                Console.WriteLine("\nDigite a opção: "); // Interface
                Linha();
                Console.SetCursorPosition(16, contadorWhile2); // Posição 2 
                Op = int.Parse(Console.ReadLine()); // Entrada 2

                contadorWhile2 += 2;
            }
            

            /*
            Console.Clear(); // Limpar Tela
            Linha();
            Console.WriteLine("\n<Opções de Figuras>"); // Interface
            Linha();
            Console.WriteLine("\n1 - Triângulo"); // Interface - Menu
            Console.WriteLine("2 - Quadrado"); // Interface - Menu
            Console.WriteLine("3 - Retângulo"); // Interface - Menu
            Linha();
            Console.WriteLine("\nDigite a figura desejada: ");
            Console.SetCursorPosition(26, 7); // Posição 1
            Figura = int.Parse(Console.ReadLine()); // Entrada 1
            Linha();
            Console.WriteLine("\nSelecionar a opção desejada: "); // Interface
            Console.WriteLine("\n1 - Área"); // Interface - Menu
            Console.WriteLine("2 - Perimetro"); // Interface - Menu
            Console.WriteLine("\nDigite a opção: "); // Interface
            Console.SetCursorPosition(16, 14); // Posição 2 
            Op = int.Parse(Console.ReadLine()); // Entrada 2
            Linha();
            switch (Op) // Dispositivo de Escolha 1
            {
                case 1:
                    if (Figura == 1) // Condicional 1
                    {
                        Console.WriteLine("\nDigite o valor da Base: "); // Interface
                        Console.SetCursorPosition(24, 16); // Posição 3
                        Valor1 = int.Parse(Console.ReadLine()); // Entrada 1

                        Console.WriteLine("\nDigite o valor da Altura: "); // Interface 
                        Console.SetCursorPosition(26, 17); // Posição 4
                        Valor2 = int.Parse(Console.ReadLine()); // Entrada 2
                        Resultado = (Valor1 * Valor2) / 2; // Processo 1
                    }
                    else if (Figura == 2) // Outra Opção 1 - 1
                    {
                        Console.WriteLine("\nDigite o valor do Lado: "); // Interface
                        Console.SetCursorPosition(24, 16); // Posição 5
                        Valor1 = int.Parse(Console.ReadLine()); // Entrada 3

                        Resultado = Valor1 * Valor1; // Processo 2

                        Console.WriteLine("Area do Quadrado: " + Resultado); // Saida 2
                        Linha();
                    }
                    else if (Figura == 3) // Outra Opção 2 - Condicional 1
                    {
                        Console.WriteLine("\nDigite o valor da Base: "); // Interface
                        Console.SetCursorPosition(26, 16); // Posição 6
                        Valor1 = int.Parse(Console.ReadLine()); // Entrada 4

                        Console.WriteLine("Digite o valor da Altura: "); // Interface
                        Console.SetCursorPosition(26, 17); // Posição 7
                        Valor2 = int.Parse(Console.ReadLine()); // Entrada 5

                        Resultado = (Valor1 * Valor2); // Processo 3

                        Console.WriteLine("Área do Retângulo: " + Resultado); // Saída 3
                        Linha();
                    }

                    break;

                case 2:
                    if (Figura == 1) // Condicional 2
                    {
                        Console.WriteLine("\nDigite o valor do 1° lado: "); // Interface
                        Console.SetCursorPosition(27, 16); // Posição 8
                        Valor1 = int.Parse(Console.ReadLine()); // Entrada 5

                        Console.WriteLine("Digite o valor do 2° lado: "); // Interface
                        Console.SetCursorPosition(27, 17); // Posição 9
                        Valor1 = int.Parse(Console.ReadLine()); // Entrada 6

                        Console.WriteLine("Digite o valor do 3° lado: "); // Interface
                        Console.SetCursorPosition(27, 18); // Posição 10
                        Valor2 = int.Parse(Console.ReadLine()); // Entrada 7

                        Resultado = Valor1 + Valor2 + Valor3; // Processo 4

                        Console.WriteLine("Perimêtro do Triângulo: " + Resultado); // Saída 4
                        Linha();
                    }
                    else if (Figura == 2)  // Outra Opção 1 - Condicional 2
                    {
                        Console.WriteLine("\nDigite o valor do Lado: "); // Interface 
                        Console.SetCursorPosition(24, 16); // Posição 11
                        Valor1 = int.Parse(Console.ReadLine()); // Entrada 8

                        Resultado = Valor1 * 4; // Processo 5

                        Console.WriteLine("Perimêtro do Quadrado: " + Resultado); // Saída 5
                        Linha();
                    }
                    else if (Figura == 3) // Outra Opção 2 - COndicional 2
                    {
                        Console.WriteLine("\nDigite o valor da Base: "); // Interface
                        Console.SetCursorPosition(24, 16); // Posição 12
                        Valor1 = int.Parse(Console.ReadLine()); // Entrada 9

                        Console.WriteLine("Digite o valor da Altura"); // Interface
                        Console.SetCursorPosition(26, 17); // Posição 13
                        Valor2 = int.Parse(Console.ReadLine()); // Entrada 10
                        Resultado = (Valor1 * Valor2) + (Valor2 * 2); // Processo 6

                        Console.WriteLine("Perimetro do Retângulo: " + Resultado); // Saída 6
                        Linha();
                    }
                    break;
                default: // Opção Padrão
                    Console.WriteLine("Valor digitado não é válido!"); // Saída 7
                    Resultado = 0; // Processo 7
                    break; 
            }
            */
            Console.ReadLine();
        }
    }
}
