using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacaoEmMatrizes2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Segundo desafio
            /*
            imprima cada ID de pedido que começa com a letra "B".
            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

            A saída deve corresponder ao seguinte:

            B123
            B177
            B179
            */


            // Solução

            string orderStream = "B123-C234-A345+C15-B177 G3003-C235-B179";
            string[] items = orderStream.Split('-', ' ', '+');

            foreach (var item in items)
            {
                if (item.StartsWith("B"))
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadLine();
        }
    }
}
