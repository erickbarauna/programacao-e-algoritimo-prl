using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesEmMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inverter cada palavra de uma mensagem
            /*
            string pangram = "The quick brown fox jumps over the lazy dog";

            Se você tiver êxito, deverá ver a seguinte saída:

            ehT kciuq nworb xof spmuj revo eht yzal god
            */


            // Solução

            string pangram = "The quick brown fox jumps over the lazy dog";

            string[] message = pangram.Split(' ');
            string[] newMessage = new string[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                char[] letters = message[i].ToCharArray();
                Array.Reverse(letters);
                newMessage[i] = new string(letters);
            }

            string result = String.Join(" ", newMessage);
            Console.WriteLine(result);

            Console.ReadLine();
         }
    }
}
