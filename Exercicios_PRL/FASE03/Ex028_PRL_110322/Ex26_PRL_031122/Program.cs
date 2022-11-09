using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ex26_PRL_031122.Program;

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

        public static void MsgErroNumero()
        {
            Blue();
            Console.Write("\nPor favor, digite apenas ");
            Green();
            Console.Write("Números");
            Blue();
            Console.Write("!\n");
            White();
            Linha();
        }

        static void Main(string[] args)
        {
            string FiguraStr = "";
            int FiguraInt = 0;
            int contadorWhile1 = 7;

            string[] Figuras = new string[] { "Triângulo", "Quadrado", "Retângulo" };

            string OpcaoStr = "";
            int OpcaoInt = 0;
            int contadorWhile2 = 7;

            string ValorStr1 = "";
            int ValorInt1 = 0;

            string ValorStr2 = ""; 
            int ValorInt2 = 0;

            string ValorStr3 = "";
            int ValorInt3 = 0;

            double Resultado = 0;


            Console.Clear(); // Limpar Tela
            White();
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
                    MsgErroNumero();
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

            while (OpcaoInt > 2 || OpcaoInt < 1)
            {
                Console.WriteLine("\nDigite a opção: "); // Interface
                Linha();
                Console.SetCursorPosition(16, contadorWhile2); // Posição 2 
                OpcaoStr = Console.ReadLine(); // Entrada 2

                contadorWhile2 += 4;

                if (int.TryParse(OpcaoStr, out OpcaoInt))
                {
                    switch (OpcaoInt) // Dispositivo de Escolha 1
                    {
                        case 1:
                            if (FiguraInt == 1) // Condicional 1
                            {
                                while (ValorInt1 == 0)
                                {
                                    Console.WriteLine("\nDigite o valor da Base: "); // Interface
                                    Console.SetCursorPosition(24, contadorWhile2 - 2); // Posição 3
                                    ValorStr1 = Console.ReadLine(); // Entrada 1

                                    if (int.TryParse(ValorStr1, out ValorInt1))
                                    {

                                    }
                                    else
                                    {
                                        MsgErroNumero();
                                    }
                                    contadorWhile2 += 4;
                                }

                                while (ValorInt2 == 0)
                                {
                                    Console.WriteLine("\nDigite o valor da Altura: "); // Interface 
                                    Console.SetCursorPosition(26, contadorWhile2 - 4); // Posição 4
                                    ValorStr2 = Console.ReadLine(); // Entrada 2

                                   if (int.TryParse(ValorStr2, out ValorInt2))
                                    {
                                        Resultado = (ValorInt1 * ValorInt2) / 2; // Processo 1
                                    }
                                    else
                                    {
                                        MsgErroNumero();
                                    }
                                   contadorWhile2 += 4;
                                }

                                Green();
                                Linha();
                                Console.WriteLine($"\nÁrea do Triângulo = {Resultado}"); // Saída
                                Linha();
                            }
                            else if (FiguraInt == 2) // Outra Opção 1 - 1
                            {
                                while (ValorInt1 == 0)
                                {
                                    Console.WriteLine("\nDigite o valor do Lado: "); // Interface
                                    Console.SetCursorPosition(24, contadorWhile2 - 2); // Posição 5
                                    ValorStr1 = Console.ReadLine(); // Entrada 3

                                    if (int.TryParse(ValorStr1, out ValorInt1))
                                    {
                                        Resultado = ValorInt1 * ValorInt1; // Processo 2
                                    }
                                    else
                                    {
                                        MsgErroNumero();
                                    }
                                    contadorWhile2 += 4;
                                }
                                Green();
                                Linha();
                                Console.WriteLine($"\nÁrea do Quadrado = {Resultado}"); // Saida 2
                                Linha();

                            }
                            else if (FiguraInt == 3) // Outra Opção 2 - Condicional 1
                            {
                                while (ValorInt1 == 0)
                                {
                                    Console.WriteLine("\nDigite o valor da Base: "); // Interface
                                    Console.SetCursorPosition(24, contadorWhile2 - 2); // Posição 6
                                    ValorStr1 = Console.ReadLine(); // Entrada 4

                                    if (int.TryParse(ValorStr1, out ValorInt1))
                                    {

                                    }
                                    else
                                    {
                                        MsgErroNumero();
                                    }
                                    contadorWhile2 += 4;
                                }

                                while (ValorInt2 == 0)
                                {
                                    Console.WriteLine("\nDigite o valor da Altura: "); // Interface
                                    Console.SetCursorPosition(26, contadorWhile2 - 4); // Posição 7
                                    ValorStr2 = Console.ReadLine(); // Entrada 5

                                    if (int.TryParse(ValorStr2, out ValorInt2))
                                    {
                                        Resultado = (ValorInt1 * ValorInt2); // Processo 3
                                    }
                                    else
                                    {
                                        MsgErroNumero();
                                    }
                                    contadorWhile2 += 4;
                                }

                                Green();
                                Linha();
                                Console.WriteLine($"\nÁrea do Retângulo = {Resultado}"); // Saída 3
                                Linha();
                            }

                            break;

                        case 2:
                            if (FiguraInt == 1) // Condicional 2
                            {
                                while (ValorInt1 == 0)
                                {
                                    Console.WriteLine("\nDigite o valor do 1° lado: "); // Interface
                                    Console.SetCursorPosition(27, contadorWhile2 - 2); // Posição 8
                                    ValorStr1 = Console.ReadLine(); // Entrada 5

                                    if (int.TryParse(ValorStr1, out ValorInt1))
                                    {

                                    }
                                    else
                                    {
                                        MsgErroNumero();
                                    }
                                    contadorWhile2 += 4;
                                }

                                while (ValorInt2 == 0)
                                {
                                    Console.WriteLine("\nDigite o valor do 2° lado: "); // Interface
                                    Console.SetCursorPosition(27, contadorWhile2 - 4); // Posição 9
                                    ValorStr2 = Console.ReadLine(); // Entrada 6

                                    if (int.TryParse(ValorStr2, out ValorInt2))
                                    {
                                        
                                    }
                                    else
                                    {
                                        MsgErroNumero();
                                    }
                                    contadorWhile2 += 4;
                                }

                                while (ValorInt3 == 0)
                                {
                                    Console.WriteLine("\nDigite o valor do 3° lado: "); // Interface
                                    Console.SetCursorPosition(27, contadorWhile2 - 6); // Posição 10
                                    ValorStr3 = Console.ReadLine(); // Entrada 7

                                    if (int.TryParse(ValorStr3, out ValorInt3))
                                    {
                                        Resultado = ValorInt1 + ValorInt2 + ValorInt3; // Processo 4
                                    }
                                    else
                                    {
                                        MsgErroNumero();
                                    }
                                    contadorWhile2 += 4;
                                }

                                Green();
                                Linha();
                                Console.WriteLine($"\nPerimêtro do Triângulo = {Resultado} "); // Saída 4
                                Linha();
                            }
                            else if (FiguraInt == 2)  // Outra Opção 1 - Condicional 2
                            {
                                while (ValorInt1 == 0)
                                {
                                    Console.WriteLine("\nDigite o valor do Lado: "); // Interface 
                                    Console.SetCursorPosition(24, contadorWhile2 - 2); // Posição 11
                                    ValorStr1 = Console.ReadLine(); // Entrada 8

                                    if (int.TryParse(ValorStr1, out ValorInt1))
                                    {
                                        Resultado = ValorInt1 * 4; // Processo 5
                                    }
                                    else
                                    {
                                        MsgErroNumero();
                                    }
                                    contadorWhile2 += 4;
                                }

                                Green();
                                Linha();
                                Console.WriteLine($"\nPerimêtro do Quadrado = {Resultado}"); // Saída 5
                                Linha();
                            }
                            else if (FiguraInt == 3) // Outra Opção 2 - COndicional 2
                            {
                                while (ValorInt1 == 0)
                                {
                                    Console.WriteLine("\nDigite o valor da Base: "); // Interface
                                    Console.SetCursorPosition(24, contadorWhile2 - 2); // Posição 12
                                    ValorStr1 = Console.ReadLine(); // Entrada 9

                                    if (int.TryParse(ValorStr1, out ValorInt1))
                                    {

                                    }
                                    else
                                    {
                                        MsgErroNumero();
                                    }
                                    contadorWhile2 += 4;
                                }
                                
                                while (ValorInt2 == 0)
                                {
                                    Console.WriteLine("\nDigite o valor da Altura: "); // Interface
                                    Console.SetCursorPosition(26, contadorWhile2 - 4); // Posição 13
                                    ValorStr2 = Console.ReadLine(); // Entrada 10
                                    
                                    if (int.TryParse(ValorStr2, out ValorInt2))
                                    {
                                        Resultado = (ValorInt1 * ValorInt2) + (ValorInt2 * 2); // Processo 6
                                    }
                                    else
                                    {
                                        MsgErroNumero();
                                    }
                                    contadorWhile2 += 4;
                                }
                                
                                Green();
                                Linha();
                                Console.WriteLine($"\nPerimetro do Retângulo = {Resultado}"); // Saída 6
                                Linha();
                            }
                            break;
                        default: // Opção Padrão
                            Red();
                            Console.WriteLine("\nDigite uma Opção Válida!"); // Saída 7
                            White();
                            Linha();
                            Resultado = 0; // Processo 7
                            break;
                    }
                }
                else
                {
                    MsgErroNumero();
                }
            }

            Console.ReadLine();
        }
    }
}
