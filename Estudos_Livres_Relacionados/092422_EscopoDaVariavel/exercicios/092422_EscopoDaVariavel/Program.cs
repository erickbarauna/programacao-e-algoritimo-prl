using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _092422_EscopoDaVariavel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BLOCOS DE CÓDIGO AFETAM O ESCOPO DE UMA VARIAVEL 

            /*
            Os blocos de código definem os limites de estruturas de nível superior,
            tais como namespaces, classes e métodos, assim como definem os
            limites das instruções de decisão e de iteração.
            Esses limites exigem consideração, porque afetam a visibilidade das variáveis
            e de outras estruturas maiores, assim como métodos e classes.
            Em alguns casos, palavras - chave adicionais como public e using devem ser usadas
            para adentrar os limites de outro bloco de código.Em outros casos,
            as estruturas definidas como irmãos dentro do mesmo bloco de código podem
            fazer referência umas às outras livremente.
            */

            /*
            bool flag = true;
            if (flag)
            {
               
                //Só é possível utilizar a variável int dentro deste if
                //Para usa-la fora será preciso declara-la fora do if

                int value = 10;

                Console.WriteLine($"Inside of code block: {value}");
            } 

            Console.WriteLine($"Outside of code block: {value}");
            */


            // REMOVER BLOCOS DE CÓDIGO EM INSTRUÇÕES IF
            /* 01
            bool flag = true;
            if (flag)
            {
                Console.WriteLine(flag);
            }
            */

            /*
            bool flag = true;
            if (flag)
                Console.WriteLine(flag);
            */

            /*
            bool flag = true;
            if (flag) Console.WriteLine(flag); 
            */


            /*02
            string name = "steve";
            if (name == "bob") Console.WriteLine("Found Bob");
            else if (name == "steve") Console.WriteLine("Found Steve");
            else Console.WriteLine("Found Chuck");
            */
        }    
    }
}
