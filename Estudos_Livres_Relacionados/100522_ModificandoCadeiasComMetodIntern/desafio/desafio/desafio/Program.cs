using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dado o ponto de partida na lista de códigos a seguir, você adicionará
            // código para extrair, substituir e remover partes do valor input para
            // produzir a saída desejada.

            // 1 - Defina a variável quantity como o valor extraído entre as marcas<span> e </ span >.
            // 2 - Defina a variável output como o valor de entrada e, em seguida, remova as marcas<div> e </ div >.
            // 3 - Substitua o caractere HTML &trade; por & reg; na variável output.

            /*
            const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            string quantity = "";
            string output = "";

            // Your work here

            Console.WriteLine(quantity);
            Console.WriteLine(output);
            */


            // Solução
            
            /*
            const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            string quantity = "";
            string output = "";

            // Your work here

            const string spanTag = "<span>";

            // Extract the quantity
            int quantityStart = input.IndexOf(spanTag);
            int quantityEnd = input.IndexOf("</span>");
            quantityStart += spanTag.Length;
            int quantityLength = quantityEnd - quantityStart;
            quantity = input.Substring(quantityStart, quantityLength);

            // Set output to input, replacing the trademark symbol with the registered trademark symbol
            output = input.Replace("&trade;", "&reg;");

            // Remove the opening <div> tag
            int divStart = input.IndexOf("<div");
            int divEnd = input.IndexOf(">");
            int divLength = divEnd - divStart;
            divLength += 1;
            output = output.Remove(divStart, divLength);

            // Remove the closing <div> tag
            int divCloseStart = output.IndexOf("</div");
            int divCloseEnd = output.IndexOf(">", divCloseStart);
            int divCloseLength = divCloseEnd - divCloseStart;
            divCloseLength += 1;
            output = output.Remove(divCloseStart, divCloseLength);

            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Output: {output}");
            */
        }
    }
}
