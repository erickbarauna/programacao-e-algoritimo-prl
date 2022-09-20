using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _091722_LógicaDeDecisaoCom_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ROLA 3 DADOS E EXIBE A PONTUAÇÃO DE ACORDO COM AS REGRAS E GANHA PRÊMIOS
            /*
            Random dado = new Random();
         
            int rolagem1 = dado.Next(1, 7);
            int rolagem2 = dado.Next(1, 7);
            int rolagem3 = dado.Next(1, 7);

            int total = rolagem1 + rolagem2 + rolagem3;

            Console.WriteLine($"Resultado dos 3 dados rolados: {rolagem1}, {rolagem2}, {rolagem3}");
            Thread.Sleep(2000);

            if (rolagem1 == rolagem2 && rolagem1 == rolagem3)
            {
                Console.WriteLine("Você rolou 3 dados IGUAIS! +6 de bônus no total!");
                total += 6;
                Thread.Sleep(2600);
            }
            else if (rolagem1 == rolagem2 || rolagem1 == rolagem3 || rolagem2 == rolagem3)
            {
                Console.WriteLine("Você rolou 2 dados iguais! +2 de bônus no total!");
                total += 2;
                Thread.Sleep(2600);
            }
            

            Console.WriteLine($"\nTotal: {total}");
            Thread.Sleep(2000);


            if (total > 15)
            {
                Console.WriteLine("Você ganhou um CARRO!");
            }
            else if (total > 9)
            {
                Console.WriteLine("Você ganhou um LAPTOP!");
            }
            else if (total == 7)
            {
                Console.WriteLine("Você ganhou uma VIAGEM!");
            }
            else
            {
                Console.WriteLine("Você ganhou um GATINHO!");
            }

            Console.ReadLine();
            */


            // APRIMORAMENTO DE TAXA DE RENOVAÇÃO DE ASSINATURAS

            Random dia = new Random();
            int diasAteVencimento = dia.Next(12);  // Gera um n° aleatório que será o tempo de assinatura
            int percentualDeDesconto = 0;  // Porcentagem que será aplicada se a assinatura for renovada de acordo com os dias restantes


            if (diasAteVencimento == 0)
            {
                Console.WriteLine("Sua assinatura expirou.");
            }
            else if (diasAteVencimento == 1)
            {
                percentualDeDesconto = 20;
                Console.WriteLine($"Sua assinatura expira em {diasAteVencimento} dia!");
            }
            else if (diasAteVencimento < 6)
            {
                percentualDeDesconto = 10;
                Console.WriteLine($"Sua assinatura expira em {diasAteVencimento}.");
            }
            else if (diasAteVencimento < 11)
            {
                Console.WriteLine("Sua assinatura expirará em breve. Renove agora!");
            }

            if (percentualDeDesconto > 0)
            {
                Console.WriteLine($"Renove agora e economize {percentualDeDesconto}%.");
            }

            Console.ReadLine(); 
        }
    }
}
