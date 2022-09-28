using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_DadosCorretos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Noções básicas
            /*
            - int para a maioria dos números inteiros
            - decimal para números que representam dinheiro
            - bool para valores true ou false
            - string para valor alfanumérico 

            - byte para trabalhar com os dados codificados
            provenientes de outros sistemas de computação ou
            que usam diferentes conjuntos de caracteres.
            - double para trabalhar com fins geométricos ou científicos.
            double é usado com frequência ao criar jogos que envolvem movimento.
S           - ystem.StringBuilder para criar uma cadeia de caracteres
            de vários literais ou outras variáveis.
            - System.DateTime para um valor de data e hora específico.
            - System.TimeSpan para um intervalo de anos/mês/dias/horas/minutos/
            segundos/milissegundos.
            */

            // TIPOS INTEGRAIS

            // Tipos integrais com sinal

            /*
             Um tipo com sinal usa seus bytes para representar uma quantidade
            igual de números positivos e negativos. O exercício a seguir exporá
            você aos tipos integrais com sinal em C#.
            */

            Console.WriteLine("Signed integral types:");

            Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

            /*
            Para a maioria dos aplicativos não científicos, provavelmente você
            só precisará trabalhar com int. Na maioria das vezes, você não precisará
            de mais de 2,14 bilhões de números inteiros positivos a negativos.
            */


            // Tipos integrais sem sinal

            /*
            Um tipo sem sinal usa seus bytes para representar apenas números positivos.
            O restante do exercício apresenta os tipos integrais sem sinal em C#.
            */

            Console.WriteLine("");
            Console.WriteLine("Unsigned integral types:");

            Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");


            /*
            Embora um determinado tipo de dados possa ser usado para qualquer finalidade,
            dado o fato de que o tipo de dados byte pode representar um valor de 0 a 255,
            é óbvio que isso se destina a armazenar um valor que representa um byte de dados.
            Os dados armazenados em arquivos ou dados transferidos pela Internet geralmente
            estão em um formato binário. Ao trabalhar com os dados dessas fontes externas,
            você precisará receber dados como uma matriz de bytes e convertê-los em cadeias
            de caracteres. Muitos dos métodos na Biblioteca de Classes do .NET que lidam com
            os dados de codificação e decodificação exigem que você manipule matrizes de bytes.
            */


            // Recapitulação

            /*
            - Um tipo integral é um tipo de dados de valor simples que pode armazenar
            números inteiros.
            - Há tipos de dados com sinal e sem sinal. Os tipos integrais com sinal
            usam um bit para armazenar, independentemente se o valor é positivo ou negativo.
            - É possível usar as propriedades MaxValue e MinValue de tipos de dados numéricos
            para avaliar se um número pode se enquadrar em um tipo de dados determinado. 
            */


            // Tipos de ponto flutuante

            /*
            Um ponto flutuante é um tipo de valor simples que representa números fracionários.
            Ao contrário dos números integrais, há outras considerações além dos valores
            máximo e mínimo que você pode armazenar em um determinado tipo de ponto flutuante. 
            */

            Console.WriteLine("");
            Console.WriteLine("Floating point types:");
            Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
            Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
            Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");


            // Recapitulação

            /*
            - Um tipo de ponto flutuante é um tipo de dados de valor simples
            que pode conter números fracionários.
            - A escolha do tipo de ponto flutuante certo para seu aplicativo
            exige que você considere mais do que apenas os valores máximo e mínimo
            que ele pode conter. Você também precisa considerar quantos valores
            podem ser preservados após o decimal, como os números são armazenados
            e como o armazenamento interno afeta o resultado de operações matemáticas.
            - Às vezes, os valores de ponto flutuante podem ser representados usando
            a "notação E", quando os números aumentam bastante.
            - Há uma diferença fundamental em como o compilador e o tempo de execução
            manipulam o decimal em oposição ao float ou ao double, principalmente ao
            determinar quanta precisão é necessária de operações matemáticas.
            */
            Console.ReadLine();

        }
    }
}
