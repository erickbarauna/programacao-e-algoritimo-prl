using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Ex037_PRL_120222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string CPF, POS; // Variveis de Texto entrada
            int Tamanho, Verificar = 0, Resto = 0, Multiplicador = 11, Soma = 0; // Variveis de Saida
            int[] num = new int[14]; // Vetor inteiro de 14 Indices

            Console.Clear(); // Limpa Tela
            Console.WriteLine("Digite um CPF: "); //Interface 1
            Console.SetCursorPosition (15, 0); // Posição 1

            CPF = (Console.ReadLine()); // Entrada 1 Tamanho CPF.Length; // Processo 1
            Tamanho = CPF.Length; // Processo 1

            for (int i = 0; i < Tamanho; i++) // Laçol Para
            {
                POS = CPF.Substring(i, 1); // Processo 2

                if (POS == "." || POS == "-") // Condicional 1
                {
                    num[i] = 0; // Processo 3
                }
                else // Negação Condicional 1{
                {
                    num[i] = int.Parse(POS) * Multiplicador; // Processo 4
                    Multiplicador--; // Processo 5
                }
            }

            for (int j = 0; j < 13; j++) // Laço 2 - Para
            {
                Soma = Soma + num[j]; // Processo 6
            }

            Resto = Soma % 11; // Processo 7
            Verificar = 11 - Resto; // Processo 8

            if (Resto <= 1) Verificar = 0; //Condicional 2 - Processo 9

            if (Verificar == num[13]) // Condicional 3
            {
                Console.WriteLine("CPF: " + CPF + " Válido"); // Saída 1
            }
            else // Negação Condicional 3
            {
                Console.WriteLine("CPF: " + CPF + " Inválido"); // Saída 2
            }

            Console.ReadLine();
        }
    }
}
