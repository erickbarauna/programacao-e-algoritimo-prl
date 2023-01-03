using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variaveis_constantes_aula08
{
    internal class Program
    {
        public const int SAIDA_PROGRAMA = 1;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine($"Digite {SAIDA_PROGRAMA} para sair do programa");
                int valor = int.Parse(Console.ReadLine());

                if(SAIDA_PROGRAMA == valor)
                {
                    break;
                }
            }
        }
    }
}
