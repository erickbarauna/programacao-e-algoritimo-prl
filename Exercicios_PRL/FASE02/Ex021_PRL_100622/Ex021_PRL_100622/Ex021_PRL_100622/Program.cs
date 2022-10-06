using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ex021_PRL_100622
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int numero; // Variavel inteira - Entrada
                double n1, n2, n3; // Variaveis inteiras - Saída

                string resposta = "s"; // Variavel texto - Entrada

                while (resposta == "s")
                {
                    Console.Clear(); // Limpa tela
                    Console.WriteLine("Digite um número: "); // Interface 1
                    Console.SetCursorPosition(18, 0); // Posição 1
                    numero = int.Parse(Console.ReadLine()); // Entrada 1

                    n1 = (numero / 3) - 1; // Processo 1
                    n2 = (n1 + 1); // Processo 2
                    n3 = n1 + 2; // Processo 3

                    if (n1 + n2 + n3 < numero) // Condicional 1
                    {
                        Console.WriteLine("Não existe soma de números consecutivos para este número digitado!\n"); // saída 1
                        Thread.Sleep(1500);
                    }
                    else
                    {
                        Console.Write($"Resultado: {n1}"); // Saída 2
                        Thread.Sleep(800);
                        Console.Write($" + {n2}"); // Saída 2
                        Thread.Sleep(800);
                        Console.Write($" + {n3}"); // Saída 2
                        Thread.Sleep(1000);
                        Console.Write($" = {numero}\n\n"); // Saída 2
                        Thread.Sleep(1500);
                    }

                    string resposta2 = "";
                    int contador = 3;

                    while (resposta2 != "s" && resposta2 != "n")
                    {
                        Console.WriteLine("Quer continuar [S/N]? "); // Interface 2
                        Console.SetCursorPosition(22, contador); // Posição 2
                        resposta2 = Console.ReadLine();
                        resposta2 = resposta.ToLower();
                        resposta += resposta2;
                        contador++;

                        if (resposta2 == "n")
                        {
                            Environment.Exit(0);
                        }
                    }
                   
                }
            }
            catch
            {
                Console.WriteLine("Por favor digite um número para que possa ser testado!"); // Saída 4 
            }
            Console.ReadLine();
        }
    }
}
