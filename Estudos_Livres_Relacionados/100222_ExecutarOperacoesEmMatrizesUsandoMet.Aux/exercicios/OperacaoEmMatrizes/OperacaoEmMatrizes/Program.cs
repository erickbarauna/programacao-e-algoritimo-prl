using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacaoEmMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sort() e Reverse()
            /* .Sort()
            string[] pallets = { "B14", "A11", "B12", "A13" };

            Console.WriteLine("Ordenando...");
            Array.Sort(pallets); // Ordena os itens na matriz de maneira alfanumérica.
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
            */

            /* .Reverse()
            Console.WriteLine("");
            Console.WriteLine("Reversed...");
            Array.Reverse(pallets);
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
            */

            /* .Clear .TOLower .Length
            string[] pallets = { "B14", "A11", "B12", "A13" };
            Console.WriteLine("");

            Console.WriteLine($"Before: {pallets[0].ToLower()}");
            Array.Clear(pallets, 0, 2);
            if (pallets[0] != null)
                Console.WriteLine($"After: {pallets[0].ToLower()}");

            Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
            */

            /* .Resize()
            string[] pallets = { "B14", "A11", "B12", "A13" };
            Console.WriteLine("");

            Array.Clear(pallets, 0, 2);
            Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }


            // Nesse caso (abaixo), estamos redimensionando a matriz pallets de quatro
            // elementos para 6.Os novos elementos são adicionados
            // ao final dos elementos atuais.Os dois novos elementos
            // serão nulos até atribuirmos um valor a eles.

            Console.WriteLine("");
            Array.Resize(ref pallets, 6);
            Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

            pallets[4] = "C01";
            pallets[5] = "C02";

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }


            //Por outro lado (abaixo), podemos remover elementos da matriz usando Array.Resize():

            Console.WriteLine("");
            Array.Resize(ref pallets, 3);
            Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
            */

            Console.ReadLine();
        }
    }
}
