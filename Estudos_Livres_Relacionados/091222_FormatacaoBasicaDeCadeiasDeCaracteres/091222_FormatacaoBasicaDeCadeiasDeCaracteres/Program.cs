using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _091222_FormatacaoBasicaDeCadeiasDeCaracteres
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Sequências de escape de caractere
            /*
            Console.WriteLine("Hello\nWorld!");
            Console.WriteLine("Hello\tWorld!");
            Console.WriteLine("Hello \"World\"!"); // usar sem as \ vai dar erro
            Console.WriteLine("c:\\source\\repos"); // usar apenas uma \ pode dar erro
            */


            // Literal de cadeia de caracteres textual
            /*
            Console.WriteLine(@"   c:\source\repos     // o @ manterá todo o espaço em branco e os caracteres
                  (""this is where your code goes"")");
            */


            // Caracteres de escape Unicode
            /*
            // Kon'nichiwa World
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
            */


            // Exemplo
            /*
            Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tComplete!");
            Console.WriteLine("\nOutput Directory:\t");
            Console.Write(@"c:\invoices");

            // To generate Japanese invoices:
            // Nihon no seikyū-sho o seisei suru ni wa:
            Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            Console.WriteLine(@"c:\invoices\app.exe -j");
            */


            // Combinar literais textuais e interpolação de cadeia de caracteres
            /*
            string projectName = "First-Project";
            Console.WriteLine($@"C:\Output\{projectName}\Data");
            */


            // Desafio
            /*
            string projectName = "ACME";
            string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
            Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
            string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
            Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");
            */
        }
    }
}
