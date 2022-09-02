using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{

    class Program
    {

        // ENUM

        /*
        enum Cor { Azul = 3, Verde = 7, Amarelo, Vermelho }
        */


        // ENUM COM SWITCH

        /*
        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }
        */

        static void Main(string[] args)
        {
            // TIPOS DE VARIAVEIS

            /*
            int segundaGuerraMundial = 1942;
            string cor_favorita = "Vermelho";
            float velocidadeF1 = 243.65f;
            bool segundaGuerraMundialAconteceu = true;

            Console.WriteLine(segundaGuerraMundial);
            Console.WriteLine(cor_favorita);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(segundaGuerraMundialAconteceu);

            velocidadeF1 = 2323.45f;
            cor_favorita = "Roxo";

            Console.WriteLine(velocidadeF1);
            Console.WriteLine(cor_favorita);
            */

            /*
            var cor_favorita = "Vermelho";
            var modeloDoProduto = 2323;
            */

            /*
            dynamic cor_favorita = "Vermelho";

            Console.WriteLine(cor_favorita);

            cor_favorita = 21212121;

            Console.WriteLine(cor_favorita);

            cor_favorita = 42425.542f;

            Console.WriteLine(cor_favorita);

            Console.ReadLine();
            */

            /*
            const float PI = 3.14545432f;     não pode ser alterado
            */


            // ENTRADA DE DADOS

            /*
            string nome = "";

            Console.WriteLine("Escreva seu Nome: ");
            Console.SetCursorPosition(18, 0);    
            nome = Console.ReadLine();
            Console.WriteLine("Seu nome é: " + nome);

            Console.ReadLine();
            */


            // Operadores Aritiméticos

            /*
            int numeroQualquer = 20 + 20 - 80;
            int numeroMult = 10 * 89;
            int numeroDiv = 5 / 2; // não considera a casa decimal
            
            int teste = (2+2) * 10;

            Console.WriteLine(numeroQualquer);
            Console.WriteLine(numeroMult);
            Console.WriteLine(numeroDiv);
            Console.WriteLine(teste);
            Console.ReadLine();
            */


            // CONDIÇÕES

            /*
            string sexo = "";
            int idade = 0;

            Console.WriteLine("Preencha os dados e veja se tem os requisitos mínimos para entrar na festa de graça!\n");
            Console.WriteLine("Sexo [M]/[F]: ");
            Console.SetCursorPosition(14, 2);
            sexo = Console.ReadLine();
            sexo = sexo.ToUpper();

            Console.WriteLine("Idade: ");
            Console.SetCursorPosition(7, 3);
            idade = int.Parse(Console.ReadLine());

            if (sexo == "F" && idade >= 25)
            {
                Console.WriteLine("\nPode entrar de GRAÇA!");
            }
            else
            {
                Console.WriteLine("\nSó entra se PAGAR!");
            }
            Console.ReadLine();
            */


            // FUNÇÕES

            /*
            int valor = 0;
            Console.WriteLine("Digite um valor para ser analisado: ");
            Console.SetCursorPosition(36, 0);
            valor = int.Parse(Console.ReadLine());

            GerarPreco(valor);
            Console.ReadLine();
            */


            // RETORNO DE FUNÇÕES

            /*
            int soma1 = Somar(23, 34, 65);
            int soma2 = Somar(21, 43, 55);
            int soma3 = Somar(98, 67, 39);

            Console.WriteLine(soma1);   
            Console.WriteLine(soma2);
            Console.WriteLine(soma3);


            Console.ReadLine();
            */


            // ARRAY

            /*
            string[] produtos = new string[6]
            {
                "Sea of Thieves", // 0
                "FIFA", // 1
                "Minecraft", // 2
                "Half-Life", // 3
                "LOL",  // 4
                "CS"  //5
            };

            int[] valores = { 40, 50, 60, 70, 80, 20 };

            produtos[1] = "FIFA 2022";
            Console.WriteLine(produtos[1]); 
            Console.WriteLine(produtos[4]);
            Console.WriteLine(valores[5]);
            Console.ReadLine();
            */


            // SWITCH

            /*
            string cor = "Azul";

            switch (cor)
            {
                case "Vermelho":
                    Console.WriteLine("Sua cor favorita é Vermelho!");
                    break;
                case "Amarelo":
                    Console.WriteLine("Sua cor favorita é Amarelo!");
                    break;
                case "Azul":
                    Console.WriteLine("Sua cor favorita é Azul!");
                    break;
                default:
                    Console.WriteLine("Infelizmente não sei sua cor favorita!");
                    break;
            }
            Console.ReadLine();
            */


            // ENUM

            /*
            Cor corFavorita = Cor.Vermelho;
            Cor corFavoritaDaCarla = Cor.Azul; 

            Console.WriteLine((int)corFavorita);
            Console.WriteLine((Cor)7);
            Console.WriteLine((Cor)1);
            Console.WriteLine(corFavoritaDaCarla);  
            Console.ReadLine();
            */


            // ENUM COM SWITCH

            /*
            Console.WriteLine("Selecione uma das opções abaixo: ");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");

            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;


            switch (opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Você será direcionado para CRIAR algo!");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("Você será direcionado para DELETAR algo!");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Você será direcionado para EDITAR algo!");
                    break;
                case Opcao.Listar:
                    Console.WriteLine("Você será direcionado para LISTAR algo!");
                    break;
                case Opcao.Atualizar:
                    Console.WriteLine("Você será direcionado para ATUALIZAR algo!");
                    break;
                default:
                    Console.WriteLine("Digite um número VÁLIDO!");
                    break;
            }
            Console.ReadLine();
            */
        }

        /*
        // FUNÇÕES

        static void ExibirMsg()
        {
            Console.WriteLine("Esse sistema é show de bola!");
            Console.WriteLine("Estou usando funções");
            Console.WriteLine("Bem Vindo!");
        }

        static void GerarPreco(int preco)
        {
            Console.WriteLine("15% de " + preco + " é " + preco * 0.15);
            Console.WriteLine("25% de " + preco + " é " + preco*0.25);
            Console.WriteLine("35% de " + preco + " é " + preco*0.35);
        }
        */

        // RETORNO DE FUNÇÕES

        /*
        static int Somar(int a, int b, int c)
        {
            int resultadoFinal = a + b + c;
            return resultadoFinal;
        }
        */
    }
}