using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _092122_Matrizes_e_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] IDsdePedidosFalsos = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

            string possiveisPedidosFalso = "";

            foreach (string pedidos in IDsdePedidosFalsos)
            {
                if (pedidos.StartsWith("B"))
                {
                    possiveisPedidosFalso += $"{pedidos} ";
                }
            }

            Console.WriteLine($"Identificamos que os pedidos {possiveisPedidosFalso}podem ser falsos!");

            Console.ReadLine();
        }
    }
}
