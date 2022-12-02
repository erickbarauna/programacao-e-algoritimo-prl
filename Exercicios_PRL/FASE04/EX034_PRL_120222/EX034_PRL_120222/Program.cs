using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Permite abrir e fechar arquivo

namespace EX034_PRL_120222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1: Escreve uma linha para um arquivo novo
            using (StreamWriter writer = new StreamWriter("C:\\Arquivos\\Ex34.txt", true))
            {
                Console.Write("Digite um texto: ");
                Console.SetCursorPosition(17, 0);
                writer.WriteLine(Console.ReadLine());
            }
            // 2: Anexa uma linha no arquivo novo
            using (StreamWriter writer = new StreamWriter(@"C:\\Arquivos\\Ex34.txt", true))
            {
                writer.WriteLine("Resultado da gravação do texto");
            }
        }
    }
}
