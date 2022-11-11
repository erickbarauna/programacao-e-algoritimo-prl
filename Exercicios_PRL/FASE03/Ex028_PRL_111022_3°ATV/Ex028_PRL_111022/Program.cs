using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex028_PRL_111022
{
    class Program
    {
        public static void White() // Função estatica 1
        {
            Console.ForegroundColor = ConsoleColor.White; // Processo 1
        }

        public static void Green() // Função estatica 2
        {
            Console.ForegroundColor = ConsoleColor.Green; // Processo 1
        }

        public static void Red() // Função estatica 3
        {
            Console.ForegroundColor = ConsoleColor.Red; // Processo 1
        }
        public static void Linha() // Função estatica 4
        {
            for (int i = 0; i < 25; i++) // Laço 1 Para
            {
                Console.Write("=="); // Saída 1
            }
        }
        public static void Interface() // Função interface 1
        {
            White();
            Console.WriteLine("\nEscolha os sabores:"); // Interface - Menu

            Console.WriteLine("\n1- Mussarela"); // Interface - Menu
            Console.WriteLine("2- Namorado"); // Interface - Menu
            Console.WriteLine("3- Quatro Queijos"); // Interface - Menu
            Console.WriteLine("4- Carne Seca"); // Interface - Menu
            Console.WriteLine("5- Portuguesa"); // Interface - Menu
            Linha();
        }

       
        static void Main(string[] args)
        {
            try
            {
                int TamanhoPizza = 0; // Variavel inteira
                int OpPizza = 0; // Variavel inteira
                int ValorPizza = 0; // Variavel inteira
                string Nome; // Variavel texto
                string Numero; // Variavel texto
                string Endereço; // Variavel texto

                White();
                Console.WriteLine("Esolha a pizza desejada:"); // Interface - Menu

                Linha();

                Console.WriteLine("\n1- Broto"); // Interface - Menu
                Console.WriteLine("2- Família (8 Pedaços)"); // Interface - Menu

                Linha();

                Console.WriteLine("\nDigite a opção de tamanho: "); // Interface 1
                Console.SetCursorPosition(27, 5); // Posição 1
                TamanhoPizza = int.Parse(Console.ReadLine()); // Entrada 1

                Linha();

                switch (TamanhoPizza) //Dispositivo de escolha 1
                {
                    case 1: // Opção 1
                        Interface();
                        Console.WriteLine("\nDigite a opção de Sabor: "); // Interface 2
                        Console.SetCursorPosition(25, 15); // Posição 2
                        OpPizza = int.Parse(Console.ReadLine()); // Entrada 2

                        if (OpPizza == 1) // Condicional 1
                            ValorPizza = 15;
                        else if (OpPizza == 2) // Condicional 2
                            ValorPizza = 18;
                        else if (OpPizza == 3) // Cpndicional 3
                            ValorPizza = 25;
                        else if (OpPizza == 4) // Condicional 4
                            ValorPizza = 22;
                        else if (OpPizza == 5) // Condicional 5
                            ValorPizza = 20;
                        else
                        {
                            Linha();
                            Red();
                            Console.WriteLine("\nDigite uma opção válida!"); // Saída 2
                        }

                        if (OpPizza > 0 && OpPizza < 6) // Condicional 6
                        {
                            Linha();
                            Console.WriteLine("\nDigite seu nome: "); // Condicional 7
                            Console.SetCursorPosition(17, 17); // Posição 2
                            Nome = Console.ReadLine(); // Entrada 3
                            Console.WriteLine("Digite seu telefone: "); // Condional 8
                            Console.SetCursorPosition(21, 18); // Posição 3
                            Numero = Console.ReadLine(); // Entrada 4
                            Console.WriteLine("Digite seu endereço: "); // Condicional 9
                            Console.SetCursorPosition(20, 19); // Posição 4
                            Endereço = Console.ReadLine(); // Entrada 5

                            Linha();
                            Green();
                            Console.WriteLine($"\nValor do Pedido: R${ValorPizza},00"); // Saída 3
                        }

                        break;
                    case 2: // Opção 2
                        Interface();
                        Console.WriteLine("\nDigite a opção de Sabor: "); // Interface 3
                        Console.SetCursorPosition(25, 15); // Posição 5
                        OpPizza = int.Parse(Console.ReadLine()); // Entrada 3

                        if (OpPizza == 1) // Condicional 10
                            ValorPizza = 29;
                        else if (OpPizza == 2) // Condicional 11
                            ValorPizza = 32;
                        else if (OpPizza == 3) // Condicional 12
                            ValorPizza = 38;
                        else if (OpPizza == 4) // Condicional 13
                            ValorPizza = 40;
                        else if (OpPizza == 5) // Condicional 14
                            ValorPizza = 37;
                        else
                        {
                            Linha();
                            Red();
                            Console.WriteLine("\nDigite uma opção válida!"); // Saída 4
                        }

                        if (OpPizza > 0 && OpPizza < 6) // Condicional 15
                        {
                            Linha();
                            Console.WriteLine("\nDigite seu nome: "); // Condicional 16
                            Console.SetCursorPosition(17, 17); // Posição 5
                            Nome = Console.ReadLine(); // Entrada 6
                            Console.WriteLine("Digite seu telefone: "); // Condicional 17
                            Console.SetCursorPosition(21, 18); // Posição 6
                            Numero = Console.ReadLine(); // Entrada 7
                            Console.WriteLine("Digite seu endereço: "); // Condicional 18
                            Console.SetCursorPosition(20, 20); // Posição 7
                            Endereço = Console.ReadLine(); // Entrada 8

                            Linha();
                            Green();
                            Console.WriteLine($"\nValor do Pedido: R${ValorPizza},00"); // Saída 5
                        }

                        break;
                    default:
                        Red();
                        Console.WriteLine("\nDigite uma opção válida!"); // Saída 6
                        break;
                }

                White();
                Linha();
            }
            catch
            {
                Linha();
                Red();
                Console.Write("\nDigite somente "); // Saída 7
                Green();
                Console.WriteLine("Números"); // Saída 8
                White();
                Linha();
            }
            Console.ReadLine();
        }
    }
}
