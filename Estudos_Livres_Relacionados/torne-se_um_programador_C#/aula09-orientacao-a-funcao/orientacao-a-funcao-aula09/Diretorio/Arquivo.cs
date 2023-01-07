using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Diretorio
{
    internal class Arquivo
    {
        public static void Ler(int numeroArquivo)
        {
            string arquivoComCaminho = $@"C:\Arquivos\arq{numeroArquivo}.txt";

            if (File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    Console.WriteLine("\n====================");
                    Console.WriteLine($"Arquivo {numeroArquivo}.");
                    Console.WriteLine("====================");

                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                        Thread.Sleep(300);
                    }
                }
            }

            string arquivoComCaminho2 = $@"C:\Arquivos\arq{numeroArquivo + 1}.txt";

            if (File.Exists(arquivoComCaminho2))
            {
                Ler(numeroArquivo + 1);
            }
        }
    }
}
