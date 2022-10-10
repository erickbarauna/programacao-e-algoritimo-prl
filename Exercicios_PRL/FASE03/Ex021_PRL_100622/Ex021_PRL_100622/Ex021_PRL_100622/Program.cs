using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex017_PRL_091522
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = ""; // Variavel texto - Entrada
            double n1, n2, n3; // Variaveis inteiras - Saída
            int resultado = 0; // Variavel inteira - Saída

            string resposta = "s"; // Variavel texto - Entrada

            while (resposta == "s") // Condicional 1
            {
                Console.Clear(); // Limpa tela
                Console.WriteLine("Digite um número: "); // Interface 1
                Console.SetCursorPosition(18, 0); // Posição 1
                value = Console.ReadLine(); // Entrada 1

                if (int.TryParse(value, out resultado)) // Condicional 2
                {
                    n1 = (resultado / 3) - 1; // Processo 1
                    n2 = (n1 + 1); // Processo 2
                    n3 = n1 + 2; // Processo 3

                    if (resultado % 3 != 0) // Condicional 3
                    {
                        Console.WriteLine("Não existe soma de números consecutivos para este número digitado!\n"); // saída 1
                        Thread.Sleep(1500); // Tempo de espera 
                    }
                    else // Negação de Condicional 1
                    {
                        Console.Write($"Resultado: {n1}"); // Saída 2
                        Thread.Sleep(800); // Tempo de espera
                        Console.Write($" + {n2}"); // Saída 3
                        Thread.Sleep(800); // Tempo de espera
                        Console.Write($" + {n3}"); // Saída 4
                        Thread.Sleep(1000); // Tempo de espera
                        Console.Write($" = {resultado}\n\n"); // Saída 5
                        Thread.Sleep(1500); // Tempo de espera
                    }
                }
                else // Negação de Condicional 2
                {
                    Console.WriteLine("Por favor digite um número para que possa ser testado!\n"); // Saída 6
                    Thread.Sleep(1500); // Tempo de espera
                }

                string resposta2 = ""; // Variavel texto - Entrada
                int contador = 3; // Variavel inteira

                while (resposta2 != "s") // Condicional 4
                {
                    Console.WriteLine("Quer continuar [S/N]? "); // Interface 2
                    Console.SetCursorPosition(22, contador); // Posição 2
                    resposta2 = Console.ReadLine(); // Entrada 2
                    resposta2 = resposta2.ToLower(); // Processo 4
                    resposta = resposta2; // Processo 5
                    contador++; // Processo 6

                    if (resposta != "n" && resposta != "s") // Condicional 5
                    {
                        contador += 2; // Processo 7
                        Console.WriteLine("\nDigite apenas S ou N!"); // Saída 7
                    }
                    else if (resposta == "n") // Condicional 6
                    {
                        Thread.Sleep(700); // Tempo de espera
                        Console.WriteLine("Encerrando..."); // Saída 8
                        Thread.Sleep(1800); // Tempo de espera
                        Environment.Exit(0); // Sair do console
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
