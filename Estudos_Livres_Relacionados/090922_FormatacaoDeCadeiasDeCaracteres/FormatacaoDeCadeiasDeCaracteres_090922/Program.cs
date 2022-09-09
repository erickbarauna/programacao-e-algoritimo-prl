using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatacaoDeCadeiasDeCaracteres_090922
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FORATAÇÃO COMPOSTA
            /* 01
            string first = "Hello";
            string second = "World";
            string result = string.Format("{0} {1}!", first, second);
            Console.WriteLine(result);
            */

            /* 02
            string first = "Hello";
            string second = "World";
            Console.WriteLine("{1} {0}!", first, second);
            Console.WriteLine("{0} {0} {0}!", first, second);
            */

            // INTERPOLAÇÃO DE CADEIA DE CARACTERES
            /*01
            string first = "Hello";
            string second = "World";
            Console.WriteLine($"{first} {second}!");
            Console.WriteLine($"{second} {first}!");
            Console.WriteLine($"{first} {first} {first}!");
            */

            /*02
            int faturaNumero = 1201;
            decimal produtoMedicao = 25.4568m;
            decimal subtotal = 2750.00m;
            decimal impostoPorcentagem = .15825m;
            decimal total = 3185.19m;

            Console.WriteLine($"Número da Fatura: {faturaNumero}");
            Console.WriteLine($"         Medição: {produtoMedicao:N3} mg");
            Console.WriteLine($"       Sub Total: {subtotal:C}");
            Console.WriteLine($"         Imposto: {impostoPorcentagem:P2}");
            Console.WriteLine($"           Total: {total:C}");
            */


            // MOEDA DE FORMATAÇÃO
            /*
            decimal price = 123.45m;
            int discount = 50;
            Console.WriteLine($"Price: {price:C} (Save {discount:C})");
            */


            // FORMATAÇÃO DE NÚMEROS
            /* 01
            decimal measurement = 123456.78912m;
            Console.WriteLine($"Measurement: {measurement:N} units");
            */

            /* 02
            decimal measurement = 123456.78912m;
            Console.WriteLine($"Measurement: {measurement:N4} units");
            */

            // FORMATAÇÃO DE PERCENTUAIS
            /*
            decimal tax = .36785m;
            Console.WriteLine($"Tax rate: {tax:P2}");
            */


            // PREENCHIMENTO E ALINHAMENTO
            /* 01 - PadLeft adiciona espaços em branco ao lado esquerdo
            string input = "Pad this";
            Console.WriteLine(input.PadLeft(12));
            */

            /*02 - PadRight adiciona espaços em branco ao lado direito
            string input = "Pad this";
            Console.WriteLine(input.PadRight(12));
            */

            /*03 - Preechimento sobrecarregado - Nesse exemplo, adiciona-se traços no espaço em branco
            string input = "Pad this";
            Console.WriteLine(input.PadLeft(12, '-'));
            Console.WriteLine(input.PadRight(12, '-'));
            */

            // PREENCHIMENTO E ALINHAMENTO
            /*
            string paymentId = "769";
            string payeeName = "Mr. Stephen Ortega";
            string paymentAmount = "$5,000.00";

            var formattedLine = paymentId.PadRight(6);
            formattedLine += payeeName.PadRight(24);
            formattedLine += paymentAmount.PadLeft(10);

            Console.WriteLine("1234567890123456789012345678901234567890");
            Console.WriteLine(formattedLine);
            */

            // EXEMPLO GERAL

            /*
            string customerName = "Mr. Jones";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;

            Console.WriteLine($"Dear {customerName},");
            Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
            Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
            Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

            Console.WriteLine("Here's a quick comparison:\n");

            string comparisonMessage = "";

            comparisonMessage = currentProduct.PadRight(20);
            comparisonMessage += $"{currentReturn:P}".PadRight(10);
            comparisonMessage += $"{currentProfit:C}".PadRight(20);

            comparisonMessage += "\n";
            comparisonMessage += newProduct.PadRight(20);
            comparisonMessage += $"{newReturn:P}".PadRight(10);
            comparisonMessage += $"{newProfit:C}".PadRight(20);

            Console.WriteLine(comparisonMessage);
            */
        }
    }
}
