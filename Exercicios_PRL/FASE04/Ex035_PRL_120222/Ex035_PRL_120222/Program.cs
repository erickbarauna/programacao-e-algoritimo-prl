using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Permite abrir e fechar arquivo

namespace Ex035_PRL_120222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var writer = new StreamWriter("Ex35.txt"))
            // Grava arquivo dentro do projeto 
            {
                // Percorre o laço
                for (int i = 0; i < 10; i++)
                {
                    // Escreve uma string formatada no arquivo
                    writer.Write("{0:0.0}", i);
                }
            }
        }
    }
}
