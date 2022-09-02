using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_PRL_081822
{
    class Program
    {
        static void Main(string[] args)
        {

            double CF, PD, IMP;
            // CF = Custo de Fabricação / PD = Porcentagem ao Distribuidor / IMP = Impostos
          
            Console.WriteLine("Custo de Fabricação: ");
            Console.SetCursorPosition(21, 0);
            CF = double.Parse(Console.ReadLine());   

            Console.WriteLine("Porcentagem ao distribuidor: ");
            Console.SetCursorPosition(29, 1);
            PD = double.Parse(Console.ReadLine());
           
            PD = PD / 100;

            Console.WriteLine("Impostos: ");
            Console.SetCursorPosition(10, 2);
            IMP = double.Parse(Console.ReadLine());

            IMP = IMP / 100;

            double PC = CF + (CF * PD) + (CF * IMP);

            Console.WriteLine("\nO preço total para o consumidor, considerando os impostos de " + (IMP * 100) + "% e " + (PD * 100) + "% será: " + PC);
            Console.ReadLine();
        }
    }
}
