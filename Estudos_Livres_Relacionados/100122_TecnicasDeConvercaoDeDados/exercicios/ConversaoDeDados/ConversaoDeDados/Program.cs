using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // conversão e conversão de tipos de dados
            /*01
            int myInt = 3;
            Console.WriteLine($"int: {myInt}");

            decimal myDecimal = myInt;
            Console.WriteLine($"decimal: {myDecimal}");
            */

            /*
            decimal myDecimal = 3.14m;
            Console.WriteLine($"decimal: {myDecimal}");

            int myInt = (int)myDecimal;
            Console.WriteLine($"int: {myInt}");
            */

            /*
            decimal myDecimal = 1.23456789m;
            float myFloat = (float)myDecimal;

            Console.WriteLine($"Decimal: {myDecimal}");
            Console.WriteLine($"Float: {myFloat}"); 
            */


            // Use ToString() para converter um número em uma string
            /*
            int first = 5;
            int second = 7;
            string message = first.ToString() + second.ToString();
            Console.WriteLine(message); 
            */


            // Convertendo explicitamente uma string em um número
            /*
            string first = "5";
            string second = "7";
            int sum = int.Parse(first) + int.Parse(second); // TryParse() é uma versão melhor do Parse() método.
            Console.WriteLine(sum);
            */


            // Conversão de dados usando a classe Convert
            /*
            string value1 = "5";
            string value2 = "7";
            int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
            Console.WriteLine(result);
            */

            /*
            O ToInt32()método possui 19 versões sobrecarregadas permitindo que
            ele aceite praticamente todos os tipos de dados, como veremos em breve.

            Usamos o Convert.ToInt32()método com uma string aqui, mas você
            provavelmente deve usar TryParse()quando possível.

            A classe Convert é melhor para converter números fracionários
            em números inteiros (int) porque ela arredonda da maneira que você esperaria.
            /*

            // Observação
            /*
            Por que o nome do método é ToInt32()? Por que não ToInt()?
            System.Int32 é o nome do tipo de dados subjacente na biblioteca
            de classes .NET que a linguagem de programação C# mapeia para
            a palavra-chave int. Como a Convertclasse também faz parte da Biblioteca
            de Classes .NET, ela é chamada pelo nome completo, não pelo nome C#.
            Ao definir tipos de dados como parte da Biblioteca de Classes .NET, várias
            linguagens .NET como Visual Basic, F#, IronPython e outras podem
            compartilhar os mesmos tipos de dados e as mesmas classes na Biblioteca
            de Classes .NET. No final deste módulo, postaremos alguns links
            para que você possa aprender mais sobre o Common Type System do .NET.
            */


            // Comparando a conversão de um decimal em um int
            /*
            int value = (int)1.5m; // casting truncates
            Console.WriteLine(value);  // Exibirá 1

            int value2 = Convert.ToInt32(1.5m); // converting rounds up
            Console.WriteLine(value2); // Exibirá 2
            */

            /*
            Ao converter, o valor do float é truncado, o que significa que o valor
            após o decimal é ignorado completamente. Poderíamos alterar
            o float literal para 1.999m, e o resultado da conversão seria o mesmo.

            Ao converter usando Convert.ToInt32(), o valor literal float é devidamente
            arredondado para 2. Se alterássemos o valor literal para 1.499m,
            ele seria arredondado para 1. Experimente alterando os valores no editor .NET. 
            */


            // Usar TryParse()
            /*
            O método TryParse() faz várias coisas simultaneamente:

            - Ele tenta analisar uma string no tipo de dados numérico fornecido.
            - Se for bem-sucedido, ele armazenará o valor convertido em um parâmetro out .
            - Ele retorna um bool para indicar se a ação foi bem-sucedida ou falhou. 
            */


            // TryParse() uma string em um int

            /*
            string value = "102"; // Ou "bad"
            int result = 0;
            if (int.TryParse(value, out result))
            {
                Console.WriteLine($"Measurement: {result}");
            }
            else
            {
                Console.WriteLine("Unable to report the measurement.");
            } 

            //Para demonstrar que o result que foi declarado anteriormente e preenchido pelo
            //outparâmetro também pode ser usado posteriormente em seu código,
            //adicione a seguinte linha de código abaixo do código que você escreveu na Etapa 1:
            
            if (result > 0)
                Console.WriteLine($"Measurement (w/ offset): {50 + result}");
            */

            /*
            O TryParse()método é uma ferramenta valiosa. Aqui estão algumas ideias
            rápidas para lembrar:

            - Use TryParse()ao converter uma string em um tipo de dados numérico.
            - TryParse()retorna truese a conversão for bem-sucedida,
            falsese não for bem-sucedida.
            - Um parâmetro out fornece um meio secundário de um método retornando
            um valor. Nesse caso, o parâmetro out retorna o valor convertido.
            - Use a palavra-chave outao passar um argumento para um método
            que tenha definido um parâmetro out.
 
            */
        }
    }
}
