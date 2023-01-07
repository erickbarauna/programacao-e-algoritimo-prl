using Funcoes;
using Calculo;
using Diretorio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace orientacao_a_funcao_aula09
{
    internal class Program
    {

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
                    "\n3 - Calcular média de alunos\n";

                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == SAIDA_ARQUIVO)
                {
                    break;
                }
                else if (valor == LER_ARQUIVO)
                {
                    Arquivo.Ler(1);
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("\nDigite o número da tabuada: ");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.Calcular(numero);
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Media.Aluno();
                }
                else
                {
                    Console.WriteLine("\nOpção inválida");
                }

                Console.ReadLine();
            }
        }
    }
}
