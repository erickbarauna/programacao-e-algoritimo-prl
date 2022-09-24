using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _092422_desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Neste desafio, você usará as técnicas aprendidas neste módulo.
                Seu objetivo é fazer melhorias em um código mal formatado e mal comentado
                para melhorar sua legibilidade. 
            */



            /*
                O código abaixo inverte uma cadeia de caracteres,
                procura a quantidade de vezes que aparecem a letra "o"
                e imprime uma mensagem com o resultado na tela. 
            */

            string str = "A rápida raposa marrom pula sobre o cachorro preguiçoso.";
            
            char[] charMessage = str.ToCharArray();
            Array.Reverse(charMessage);

            int contador = 0;
            
            foreach (char valor in charMessage)
            {
                if (valor == 'o')
                { 
                    contador++;
                } 
            }
            
            string new_message = new String(charMessage);
            
            Console.WriteLine(new_message);
            Console.WriteLine($"\nA letra 'o' aparece {contador} vezes.");


            Console.ReadLine();
        }
    }
}
