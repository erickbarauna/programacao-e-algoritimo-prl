using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoDesafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Desafio

            /*
            int value1 = 12;
            decimal value2 = 6.2m;
            float value3 = 4.3f;

            // Your code here to set result1
            Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

            // Your code here to set result2
            Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

            // Your code here to set result3
            Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
   


            Modifique o código acima para exibir a seguinte saída: 
            
            Divide value1 by value2, display the result as an int: 2
            Divide value2 by value3, display the result as a decimal: 1.4418604651162790697674418605
            Divide value3 by value1, display the result as a float: 0.3583333
            */


            // Solução

            int valor1 = 12;
            decimal valor2 = 6.2m;
            float valor3 = 4.3f;

            // Your code here to set result1

            int result1 = Convert.ToInt32(valor1 / valor2);

            Console.WriteLine($"Divida valor1 por valor2, exiba o resultado como um inteiro: {result1}");

            // Your code here to set result2

            decimal result2 = valor2 / (decimal)valor3;

            Console.WriteLine($"Divida valor2 por valor3, exiba o resultado como um decimal: {result2}");

            // Your code here to set result3

            float result3 = valor3 / valor1;

            Console.WriteLine($"Divida value3 por value1, exiba o resultado como um float: {result3}");

            Console.ReadLine();
        }
    }
}
