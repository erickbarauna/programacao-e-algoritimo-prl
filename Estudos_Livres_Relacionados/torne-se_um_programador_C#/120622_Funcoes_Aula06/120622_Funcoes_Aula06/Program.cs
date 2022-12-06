using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _120622_Funcoes_Aula06
{
    class Program
    {
        static int CalcularSoma()
        {
            int a = 1;
            int b = 2;
            int c = a + b;

            return c;
        }

        public static void MostrarMensagemNaTela()
        {
            Console.WriteLine("Hi guys!");
        }

        public static void Tabuada(int numero)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{numero} X {i} = {numero*i}");
            }
            Console.WriteLine("==========");
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CalcularSoma());
            MostrarMensagemNaTela();

            Tabuada(7);
            Tabuada(8);
            Tabuada(9);

            Console.ReadLine();
        }
    }
}
