using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX16_PRL_090922
{
    class Program
    {
        static void Main(string[] args)
        {
            double NO;  // Variavel real - Entrada
            string ST = "";  // Variavel texto - Saída

            try
            {
                Console.Clear();  // Limpa tela
                Console.WriteLine("Digite a nota: ");  // Interface 1
                Console.SetCursorPosition(15, 0);  // Posição 1
                NO = double.Parse(Console.ReadLine());  // Entrada 1

                if (NO < 5)  // Condicional 1
                {
                    ST = "Reprovado";  //  Processo 1
                }
                if (NO >= 5 && NO < 7)  // COndicional 2
                {
                    ST = "Exame";  // Processo 2
                }
                if (NO >= 7)  // Condicional 3
                {
                    ST = "Aprovado";  // Processo 3
                }
                Console.WriteLine($"Nota: {NO} Classificação: {ST}");  // Saída 1
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Digite um valor válido!");  // Saída 2
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Execute novamente!");
                Console.ReadLine();
            }
        }
    }
}
