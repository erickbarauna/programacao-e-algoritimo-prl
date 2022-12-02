using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Permite abrir e fechar arquivo

namespace Ex036_PRL_120222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            Console.Clear();
            Console.WriteLine("Escolha a opção desejada: ");
            Console.WriteLine("1 - Escrever texto ");
            Console.WriteLine("2 - Ler texto");
            Console.WriteLine("3 - Ler todo texto");
            Console.WriteLine("Digite a opção desejada: ");
            Console.SetCursorPosition(25, 4);

            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    using (StreamWriter writer = new StreamWriter("Ex36.txt", true))
                    {
                        Console.WriteLine("Digite um texto: ");
                        Console.SetCursorPosition(17, 5);
                        writer.WriteLine(Console.ReadLine());
                        Console.WriteLine("=========================");
                    }
                    break;

                case 2:
                    using (StreamReader reader = new StreamReader("Ex36.txt"))
                    {
                        string linha;
                        linha  = reader.ReadLine();
                        Console.WriteLine(linha);
                        Console.WriteLine("=========================");
                    }
                    break;

                case 3:
                    using (StreamReader sr = new StreamReader("Ex36.txt"))
                    {
                        string linha;

                        while ((linha = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(linha);
                        }
                        Console.WriteLine("=========================");
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}
