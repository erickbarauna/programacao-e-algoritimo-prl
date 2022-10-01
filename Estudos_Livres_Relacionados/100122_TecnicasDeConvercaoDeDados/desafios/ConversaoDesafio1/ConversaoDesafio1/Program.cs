using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoDesafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Regras 

            /*
            - Regra 1: Se o valor for alfanumérico, concatene-o para formar uma mensagem

            - Regra 2: Se o valor for numérico, adicione-o ao total

            - Regra 3: verifique se o resultado corresponde à seguinte saída: 
            */

            // Resultado

            /*
            Message: ABCDEF
            Total: 68.3 
            */


            string[] values = { "12,3", "45", "ABC", "11", "DEF" };

            decimal total = 0m;
            string message = "";

            foreach (var value in values)
            {
                decimal number;
                if (decimal.TryParse(value, out number))
                {
                    total += number;
                }
                else
                {
                    message += value;
                }
            }

            Console.WriteLine($"Message: {message}");
            Console.WriteLine($"Total: {total}");

            Console.ReadLine();
        }
    }
}
