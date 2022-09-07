using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formatacao_de_texto_expressoes_booleanas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            /* Console.WriteLine("a" == "a");  // True
            Console.WriteLine("a" == "A");  // False
            Console.WriteLine(1 == 2);  // False

            string myValue = "a";
            Console.WriteLine(myValue == "a");  // True */


            // 2
            /* Console.WriteLine("a" == "a "); // True */


            // 3
            /* string value1 = " a";
            string value2 = "A ";
            Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());  // True */


            // 4
            /* Console.WriteLine("a" != "a");  // False
            Console.WriteLine("a" != "A");  // True
            Console.WriteLine(1 != 2);  // True

            string myValue = "a";
            Console.WriteLine(myValue != "a");  // False */


            // 5
            /* Console.WriteLine(1 > 2);  // False
            Console.WriteLine(1 < 2);  // True
            Console.WriteLine(1 >= 1);  // True
            Console.WriteLine(1 <= 1);  // True */


            // 6
            /* string frase = "Eu não gosto de tomar banho!";

            Console.WriteLine(frase.Contains("não"));  // True 
            Console.WriteLine(!frase.Contains("não"));  // False */


            // 7
            /*
            // Exemplo 1
            int Compra = 1001;

            int Desconto = Compra > 1000 ? Compra - 100 : Compra - 50;

            Console.WriteLine($"Com o desconto aplicado, o valor de sua compra será: {Desconto}");

            // Exemplo 2
            int Conta = 350;

            Console.WriteLine($"De acordo com o valor da sua conta você receberá um desconto de: {(Conta > 250 ? 30 : 10)}%");
            */
        }
    }
}
