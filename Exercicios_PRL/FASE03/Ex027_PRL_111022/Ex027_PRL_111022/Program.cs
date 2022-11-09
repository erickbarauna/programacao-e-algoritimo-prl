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


            Console.Clear();
            White();
            Linha();
            Console.WriteLine("\n<Opções de Figuras>");
            Linha();
            Console.WriteLine("\n1 - Triângulo");
            Console.WriteLine("2 - Quadrado");
            Console.WriteLine("3 - Retângulo");
            Linha();

            while (FiguraInt > 3 || FiguraInt < 1)
            {
                Console.WriteLine("\nDigite a figura desejada: ");
                Console.SetCursorPosition(26, contadorWhile1);
                FiguraStr = Console.ReadLine();
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
            Console.Write("! \nAgora selecione a opção desejada: ");
            Console.WriteLine("\n\n1 - Área");
            Console.WriteLine("2 - Perimetro");

            while (OpcaoInt > 2 || OpcaoInt < 1)
            {
                Console.WriteLine("\nDigite a opção: ");
                Linha();
                Console.SetCursorPosition(16, contadorWhile2);
                OpcaoStr = Console.ReadLine();

                contadorWhile2 += 4;

                if (int.TryParse(OpcaoStr, out OpcaoInt))
                {
                    switch (OpcaoInt)
                    {
                        case 1:
                            if (FiguraInt == 1)
                            {
                                while (ValorInt1 == 0)
                                {
                                    Console.WriteLine("\nDigite o valor da Base: ");
                                    Console.SetCursorPosition(24, contadorWhile2 - 2);
                                    ValorStr1 = Console.ReadLine();

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
                                    Console.WriteLine("\nDigite o valor da Altura: ");
                                    Console.SetCursorPosition(26, contadorWhile2 - 4);
                                    ValorStr2 = Console.ReadLine();

                                    if (int.TryParse(ValorStr2, out ValorInt2))
                                    {
                                        Resultado = (ValorInt1 * ValorInt2) / 2;
                                    }
                                    else
                                    {
                                        MsgErroNumero();
                                    }
                                    contadorWhile2 += 4;
                                }

                                Green();
                                Linha();
                                Console.WriteLine($"\nÁrea do Triângulo = {Resultado}");
                                Linha();
                            }
                            else if (FiguraInt == 2)
                            {
                                while (ValorInt1 == 0)
                                {
                                    Console.WriteLine("\nDigite o valor do Lado: ");
                                    Console.SetCursorPosition(24, contadorWhile2 - 2);
                                    ValorStr1 = Console.ReadLine();

                                    if (int.TryParse(ValorStr1, out ValorInt1))
                                    {
                                        Resultado = ValorInt1 * ValorInt1;
                                    }
                                    else
                                    {
                                        MsgErroNumero();
                                    }
                                    contadorWhile2 += 4;
                                }
                                Green();
                                Linha();
                                Console.WriteLine($"\nÁrea do Quadrado = {Resultado}");
                                Linha();

                            }
                            else if (FiguraInt == 3)
                            {
                                while (ValorInt1 == 0)
                                {
                                    Console.WriteLine("\nDigite o valor da Base: ");
                                    Console.SetCursorPosition(24, contadorWhile2 - 2);
                                    ValorStr1 = Console.ReadLine();

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
                                    Console.WriteLine("\nDigite o valor da Altura: ");
                                    Console.SetCursorPosition(26, contadorWhile2 - 4);
                                    ValorStr2 = Console.ReadLine();

                                    if (int.TryParse(ValorStr2, out ValorInt2))
                                    {
                                        Resultado = (ValorInt1 * ValorInt2);
                                    }
                                    else
                                    {
                                        MsgErroNumero();
                                    }
                                    contadorWhile2 += 4;
                                }

                                Green();
                                Linha();
                                Console.WriteLine($"\nÁrea do Retângulo = {Resultado}");
                                Linha();
                            }

                            break;

                        case 2:
                            if (FiguraInt == 1)
                            {
                                while (ValorInt1 == 0)
                                {
                                    Console.WriteLine("\nDigite o valor do 1° lado: ");
                                    Console.SetCursorPosition(27, contadorWhile2 - 2);
                                    ValorStr1 = Console.ReadLine();

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
                                    Console.WriteLine("\nDigite o valor do 2° lado: ");
                                    Console.SetCursorPosition(27, contadorWhile2 - 4);
                                    ValorStr2 = Console.ReadLine();

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
                                    Console.WriteLine("\nDigite o valor do 3° lado: ");
                                    Console.SetCursorPosition(27, contadorWhile2 - 6);
                                    ValorStr3 = Console.ReadLine();

                                    if (int.TryParse(ValorStr3, out ValorInt3))
                                    {
                                        Resultado = ValorInt1 + ValorInt2 + ValorInt3;
                                    }
                                    else
                                    {
                                        MsgErroNumero();
                                    }
                                    contadorWhile2 += 4;
                                }

                                Green();
                                Linha();
                                Console.WriteLine($"\nPerimêtro do Triângulo = {Resultado} ");
                                Linha();
                            }
                            else if (FiguraInt == 2)
                            {
                                while (ValorInt1 == 0)
                                {
                                    Console.WriteLine("\nDigite o valor do Lado: ");
                                    Console.SetCursorPosition(24, contadorWhile2 - 2);
                                    ValorStr1 = Console.ReadLine();

                                    if (int.TryParse(ValorStr1, out ValorInt1))
                                    {
                                        Resultado = ValorInt1 * 4;
                                    }
                                    else
                                    {
                                        MsgErroNumero();
                                    }
                                    contadorWhile2 += 4;
                                }

                                Green();
                                Linha();
                                Console.WriteLine($"\nPerimêtro do Quadrado = {Resultado}");
                                Linha();
                            }
                            else if (FiguraInt == 3)
                            {
                                while (ValorInt1 == 0)
                                {
                                    Console.WriteLine("\nDigite o valor da Base: ");
                                    Console.SetCursorPosition(24, contadorWhile2 - 2);
                                    ValorStr1 = Console.ReadLine();

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
                                    Console.WriteLine("\nDigite o valor da Altura: ");
                                    Console.SetCursorPosition(26, contadorWhile2 - 4);
                                    ValorStr2 = Console.ReadLine();

                                    if (int.TryParse(ValorStr2, out ValorInt2))
                                    {
                                        Resultado = (ValorInt1 * ValorInt2) + (ValorInt2 * 2);
                                    }
                                    else
                                    {
                                        MsgErroNumero();
                                    }
                                    contadorWhile2 += 4;
                                }

                                Green();
                                Linha();
                                Console.WriteLine($"\nPerimetro do Retângulo = {Resultado}");
                                Linha();
                            }
                            break;
                        default:
                            Red();
                            Console.WriteLine("\nDigite uma Opção Válida!");
                            White();
                            Linha();
                            Resultado = 0;
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
