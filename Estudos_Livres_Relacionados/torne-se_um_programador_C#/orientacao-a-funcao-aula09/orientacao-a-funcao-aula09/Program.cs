﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace orientacao_a_funcao_aula09
{
    internal class Program
    {
        public static void Tabuada(int numero)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{numero} X {i} = {numero * i}");
            }
            Console.WriteLine("==========");
        }

        private static void LerArquivo(int numeroArquivo)
        {
            string arquivoComCaminho = $@"C:\Arquivos\arq{numeroArquivo}.txt";

            if (File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    Console.WriteLine("====================");
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
                LerArquivo(numeroArquivo + 1);
            }
        }

        public const int SAIDA_ARQUIVO = 0;
        public const int LER_ARQUIVO = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        static void Main(string[] args)
        {
            while (true)
            {
                string mensagem = "Olá usuário, bem vindo ao programa, utilizando programação funcional.\n" +
                    "\nDigite uma das opções abaixo:\n" +
                    "\n0 - Sair do programa" +
                    "\n1 - Para ler arquivos" +
                    "\n2 - Para executar a tubuada" +
                    "\n3 - Calcular média de alunos";

                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == SAIDA_ARQUIVO)
                {
                    break;
                }
                else if (valor == LER_ARQUIVO)
                {
                    LerArquivo(1);
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("Digite o número da tabuada: ");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada(numero);
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Console.WriteLine("Calcular média");
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }

                Console.ReadLine();
            }
        }
    }
}
