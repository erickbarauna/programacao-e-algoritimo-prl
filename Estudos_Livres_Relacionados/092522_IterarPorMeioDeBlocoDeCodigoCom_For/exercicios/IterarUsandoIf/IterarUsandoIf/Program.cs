using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterarUsandoIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INSTRUÇÃO FOR BÁSICA

            /*
            A seguinte listagem de código é uma instrução for simples que percorre
            seu bloco de código dez vezes, imprimindo o valor atual de i:
            */

            /*
            Um conjunto de parênteses que define as condições da iteração for. 
            Ele contém três partes distintas, separadas pelo fim do operador
            de instrução, um ponto e vírgula. Determinados como inicializador,
            condição, iterador (entre os parênteses após o for), e corpo (bloco dee código
            executado após cada iteração).
            */


            /* Contagem progressiva
             
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            */


            /* Contagem regressiva
             
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            */


            /* Contagem progressiva de 3 em 3
             
            for (int i = 0; i < 10; i += 3)
            {
                Console.WriteLine(i);
            }
            */


            /* Saindo prematuramente da intrução for com a palavra-chave break
             
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 7) break;
            }
            */


            /* Percorrer cada elemento de uma matriz
             
            string[] names = { "Alex", "Eddie", "David", "Michael" };
            for (int i = names.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }
            */


            /* Limitação da instrução foreach
             
            string[] names = { "Alex", "Eddie", "David", "Michael" };
            foreach (var name in names)
            {
                // Can't do this:
                if (name == "David") name = "Sammy";
                // não é possível reatribuir o valor de name porque
                // ele faz parte da implementação interna da iteração foreach.
            }
            */


            /* Superar a limitação da instrução foreach usando a instrução for
           
            string[] names = { "Alex", "Eddie", "David", "Michael" };
            for (int i = 0; i < names.Length; i++)
                if (names[i] == "David") names[i] = "Sammy";

            foreach (var name in names) Console.WriteLine(name);
            */
        }
    }
}
