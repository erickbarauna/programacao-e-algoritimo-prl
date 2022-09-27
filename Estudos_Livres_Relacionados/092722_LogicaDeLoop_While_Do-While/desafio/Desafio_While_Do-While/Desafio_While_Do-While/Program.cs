using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_While_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Desafio de batalha em RPG

            /*
             Na maioria dos jogos de RPG, o personagem do jogador luta contra personagens
             que não são jogadores, que geralmente são monstros ou bandidos.
             Normalmente, uma batalha consiste em cada caractere gerando um valor aleatório
             por meio de dados, e esse valor é subtraído da pontuação de integridade do oponente.
             Quando a integridade de um personagem chega a zero, ele morre ou perde.

             Neste desafio, vamos reduzir essa interação à sua essência.
             Um herói e um monstro começam com a mesma pontuação de integridade.
             Durante a rodada do herói, ele gerará um valor aleatório que será subtraído
             da integridade do monstro. Se a integridade do monstro for maior que zero,
             ela terá sua rodada e atacará o herói. Desde que tanto o herói quanto o monstro
             tenham integridade maior que zero, a batalha continuará.
            */

            // Regras do Jogo

            /*
             O herói e o monstro começarão com dez pontos de integridade
             Todos os ataques serão um valor entre 1 e 10
             O herói atacará primeiro
             Imprima a quantidade de integridade que o monstro perdeu e a integridade que resta a ele
             Se a integridade do monstro for maior que zero, ele poderá atacar o herói
             Imprima a quantidade de integridade que o herói perdeu e a integridade que resta a ele
             Continue esta sequência de ataque até que a integridade do monstro ou do herói seja zero ou menos
             Imprima quem foi o vencedor
            */


            // Minha Solução no dia 27/09/22
            
            int heroi = 10;
            int monstro = 10;

            Random rand = new Random(); 

            while (heroi > 0 && monstro > 0)
            {
                int heroiAtaque = rand.Next(1, 11);

                monstro -= heroiAtaque;
                Console.WriteLine($"O monstro foi danificado e perdeu {heroiAtaque} de vida e agora restam {monstro} pontos de vida.");

                if (monstro > 0)
                {
                    int mostroAtaque = rand.Next(1, 11);
                    heroi -= mostroAtaque;

                    Console.WriteLine($"O heroi foi danificado e perdeu {mostroAtaque} de vida e agora restam {heroi} pontos de vida.");
                }
            }

            if (heroi > 0)
                Console.WriteLine("O herói venceu!");
            else
                Console.WriteLine("O monstro venceu!");

            Console.ReadLine();


            // Uma das Possíveis Correções

            /*
            int hero = 10;
            int monster = 10;

            Random dice = new Random();

            do
            {
                int roll = dice.Next(1, 11);
                monster -= roll;
                Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

                if (monster <= 0) continue; // Importante

                roll = dice.Next(1, 11);
                hero -= roll;
                Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

            } while (hero > 0 && monster > 0);

            Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!"); // Importante
            */
        }
    }
}
