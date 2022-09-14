using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _091222_OperadoresBasicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // OPERADORES MATEMÁTICOS
            /*01
            int sum = 7 + 5;
            int difference = 7 - 5;
            int product = 7 * 5;
            int quotient = 7 / 5;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);
            */
            /*02
            decimal decimalQuotient1 = 7.0m / 5;
            decimal decimalQuotient2 = 7 / 5.0m;
            decimal decimalQuotient3 = 7.0m / 5.0m;
            Console.WriteLine("Decimal quotient: " + decimalQuotient1);
            */

            // CONVERSÃO DE TIPOS DE DADOS
            /*
            int first = 7;
            int second = 5;
            decimal quotient = (decimal)first / (decimal)second;
            Console.WriteLine(quotient);
            */

            // RESTO DA DIVISÃO
            /*
            Console.WriteLine("Modulus of 200 / 5 : " + (200 % 5));
            Console.WriteLine("Modulus of 7 / 5 : " + (7 % 5));

            int value = 1;
            Console.WriteLine("Fourth: " + (++value));
            */


            // Conversão de fahrenheit para celsius
            /*
            int fahrenheit = 94;
            decimal celsius = (fahrenheit - 32m) * (5m / 9m);

            Console.WriteLine($"A temperatura é {celsius:N2} Celsius.");
            Console.ReadLine();
            */
        }
    }
}
