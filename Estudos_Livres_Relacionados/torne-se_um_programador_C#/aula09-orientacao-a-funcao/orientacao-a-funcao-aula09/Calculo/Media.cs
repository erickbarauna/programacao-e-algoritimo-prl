using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    internal class Media
    {
        public static void Aluno()
        {
            Console.Write("Digite o nome do Aluno: ");
            string nome = Console.ReadLine();
            int qtdNotas = 3;
            Console.WriteLine($"Digite as {qtdNotas} notas do aluno {nome}");
            List<int> notas = new List<int>();

            int totalNotas = 0;

            for (int i = 0; i < qtdNotas; i++)
            {
                Console.WriteLine($"Digite a {i + 1}° Nota do ALuno:");
                int nota = int.Parse(Console.ReadLine());
                totalNotas += nota;
                notas.Add(nota);
            }

            int media = totalNotas / notas.Count;
            Console.WriteLine($"A média do aluno {nome} é: {media}");
            Console.WriteLine("Suas notas são:\n");

            foreach (int nota in notas)
            {
                Console.WriteLine($"Nota: {nota}\n");
            }
        }
    }
}
