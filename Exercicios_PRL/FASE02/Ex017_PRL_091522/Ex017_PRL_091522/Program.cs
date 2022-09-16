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
            int n1, n2, n3;  // Varialvel inteira - Entrada

            int maior = 0;  // Varialvel inteira - Saída
            int meio = 0;  // Varialvel inteira - Saída
            int menor = 0;  // Varialvel inteira - Saída

            try
            {
                Console.Clear(); // Limpa tela
                Console.WriteLine("Digite o 1° número: ");  // Interface 1
                Console.SetCursorPosition(20, 0);  // Posição 1
                n1 = int.Parse(Console.ReadLine());  // Entrada 1


                Console.WriteLine("Digite o 2° número: ");  // Interface 2
                Console.SetCursorPosition(20, 1);  // Posição 2
                n2 = int.Parse(Console.ReadLine());  // Entrada 2


                Console.WriteLine("Digite o 3° número: ");  // Interface 3
                Console.SetCursorPosition(20, 2);  // Posição 3
                n3 = int.Parse(Console.ReadLine());  // Entrada 3


                if (n1 != n2 & n1 != n3 & n2 != n3)  // Condicional 1
                {
                    if (n1 < n2 & n1 < n3 & n2 < n3)  // Condicional 2
                    {
                        menor = n1;  // Processo 1
                        meio = n2;  // Processo 2
                        maior = n3;  // Processo 3
                    }

                    if (n1 < n2 & n1 < n3 & n3 < n2)  // Condicional 3
                    {
                        menor = n1;  // Processo 4
                        meio = n3;  // Processo 5
                        maior = n2;  // Processo 6
                    }

                    if (n2 < n1 & n2 < n3 & n1 < n3)  // Condicional 4
                    {
                        menor = n2;  // Processo 7
                        meio = n1;  // Processo 8
                        maior = n3;  // Processo 9
                    }

                    if (n2 < n1 & n2 < n3 & n3 < n1)  // Condicional 5
                    {
                        menor = n2;  // Processo 10
                        meio = n3;  // Processo 11
                        maior = n1;  // Processo 12
                    }

                    if (n3 < n1 & n3 < n2 & n2 < n1)  // Condicional 6
                    {
                        menor = n3;  // Processo 13
                        meio = n1;  // Processo 14
                        maior = n2;  // Processo 15
                    }

                    if (n3 < n1 & n3 < n2 & n2 < n1)  // Condicional 7
                    {
                        menor = n3;  // Processo 16
                        meio = n2;  // Processo 17
                        maior = n1;  // Processo 18
                    }

                    Console.WriteLine($"Ordem: {menor}, {meio}, {maior}");  // Saída
                    Console.ReadLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Digite um número válido!");  // Saída 2
                Console.ReadLine();
            }
        }
    }
}
