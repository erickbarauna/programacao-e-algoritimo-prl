using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace permissoesComplicadas_090722
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Admin \n- Gerente \n- Outro \nDigite uma das opções para continuar: ");
            Console.SetCursorPosition(38, 3);
            string entrada = Console.ReadLine();


            Console.WriteLine("Digite seu nível [0/100]: ");
            Console.SetCursorPosition(26, 4);
            int nivel = int.Parse(Console.ReadLine());


            string permissao = entrada.Trim().ToLower();
            Console.WriteLine();


            if (permissao.Contains("admin"))
            {
                if (nivel > 55)
                {
                    Console.WriteLine("Bem-vindo, usuário superadministrador.");
                }
                else
                {
                    Console.WriteLine("Bem-vindo, usuário administrador.");
                }
            }
            else if (permissao.Contains("gerente"))
            {
                if (nivel >= 20)
                {
                    Console.WriteLine("Entre em contato com um administrador para obter acesso.");
                }
                else
                {
                    Console.WriteLine("Você não tem privilégios suficientes.");
                }
            }
            else
            {
                Console.WriteLine("Você não tem privilégios suficientes.");
            }


            Console.ReadLine();
        }
    }
}
