using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_PRL_081822
{
    class Program
    {
        static void Main(string[] args)
        {
            double HT, VHT, IMP;

            Console.WriteLine("Quantidade de horas trabalhadas no mês: ");
            Console.SetCursorPosition(40, 0);
            HT = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor da Hora Trabalhada: ");
            Console.SetCursorPosition(26, 1);
            VHT = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor do Imposto cobrado: ");
            Console.SetCursorPosition(26, 2);
            IMP = double.Parse(Console.ReadLine());

            IMP = IMP / 100;

            double SL = (HT * VHT) - (HT * IMP); 
            

            Console.WriteLine("\nO Salário Líquido do Funcionário, considerando um imposto de " + (IMP * 100) + "% será: R$" + SL);

            Console.ReadLine();
        }
    }
}
