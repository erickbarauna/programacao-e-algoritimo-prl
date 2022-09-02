using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_Prl_081122
{
    class Program
    {
        static void Main(string[] args)
        {
            float QM;
            float QMx;

            float EM;

            Console.WriteLine("Digite a Quantidade Média: ");
            Console.SetCursorPosition(27, 0);
            QM = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Quantidade Maxima: ");
            Console.SetCursorPosition(28, 1);
            QMx = float.Parse(Console.ReadLine());

            EM = (QM + QMx) / 2;

            Console.WriteLine("O estoque médio é: " + EM);
            Console.ReadLine();
            Console.Clear();
        }
    }
}
