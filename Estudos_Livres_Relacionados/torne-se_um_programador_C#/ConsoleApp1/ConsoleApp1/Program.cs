using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] Matriz = new int[5, 4];

            Matriz[0,0] =  1;
            Matriz[0,1] =  2;
            Matriz[0,2] =  3;
            Matriz[0,3] =  4;

            Matriz[1,0] =  5;
            Matriz[1,1] =  6;
            Matriz[1,2] =  7;
            Matriz[1,3] =  8;

            Matriz[2,0] =  9;
            Matriz[2,1] =  10;
            Matriz[2,2] =  11;
            Matriz[2,3] =  12;

            Matriz[3,0] =  13;
            Matriz[3,1] =  14;
            Matriz[3,2] =  15;
            Matriz[3,3] =  16;

            Matriz[4,0] =  17;
            Matriz[4,1] =  18;
            Matriz[4,2] =  19;
            Matriz[4,3] =  20;

            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine(Matriz[i, i]);
            }

            

            Console.ReadLine();
        }
    }
}
