using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IndexOf() e Substring()

            /* Código para localizar um parêntese de abertura e fechamento inserido em uma cadeia de caracteres
            
            string message = "Find what is (inside the parentheses)";

            int openingPosition = message.IndexOf('(');
            int closingPosition = message.IndexOf(')');

            openingPosition += 1;

            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));

            */

            /* Código para recuperar o valor entre dois caracteres de parênteses
            
            string message = "What is the value <span>between the tags</span>?";

            const string openSpan = "<span>";
            const string closeSpan = "</span>";

            int openingPosition = message.IndexOf(openSpan);
            int closingPosition = message.IndexOf(closeSpan);

            openingPosition += openSpan.Length;
            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));

            */

            /* Código para recuperar a última ocorrência de uma subcadeia de caracteres
            
            string message = "(What if) I am (only interested) in the last (set of parentheses)?";
            int openingPosition = message.LastIndexOf('(');

            openingPosition += 1;
            int closingPosition = message.LastIndexOf(')');
            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));

            */

            /* Código para recuperar qualquer valor entre um ou mais conjuntos de parênteses em uma cadeia de caracteres
            
            string message = "(What if) there are (more than) one (set of parentheses)?";
            while (true)
            {
                int openingPosition = message.IndexOf('(');
                if (openingPosition == -1) break;
                // O método IndexOf() retornará -1 se não for possível encontrar
                // o parâmetro de entrada na cadeia de caracteres. Apenas verificamos
                // o valor -1 e break fora do loop.


                openingPosition += 1;
                int closingPosition = message.IndexOf(')');
                int length = closingPosition - openingPosition;
                Console.WriteLine(message.Substring(openingPosition, length));


                message = message.Substring(closingPosition + 1);
                //Quando você usa Substring() sem especificar um parâmetro de entrada
                //de comprimento, ele retornará todos os caracteres após a posição inicial
                //especificada.Para obter uma vantagem, remova o primeiro conjunto de
                //parênteses do valor de message.O que permanece é processado na próxima
                //iteração do loop while.
            }
            */

            /* Código para trabalhar com tipos diferentes de conjuntos de símbolos
            
            string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

            // O método auxiliar IndexOfAny() requer um array char de caracteres.
            // Queremos procurar:

            char[] openSymbols = { '[', '{', '(' };

            // Usaremos uma técnica ligeiramente diferente para iterar através do
            // caracteres na string. Desta vez, usaremos a posição de fechamento
            // da iteração anterior como o índice inicial para a próxima abertura
            // símbolo. Então, precisamos inicializar a variável closingPosition
            // para zero:

            int closingPosition = 0;

            while (true)
            {
                int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

                if (openingPosition == -1) break;

                string currentSymbol = message.Substring(openingPosition, 1);

                // Agora devemos encontrar o símbolo de fechamento correspondente
                char matchingSymbol = ' ';

                switch (currentSymbol)
                {
                    case "[":
                        matchingSymbol = ']';
                        break;
                    case "{":
                        matchingSymbol = '}';
                        break;
                    case "(":
                        matchingSymbol = ')';
                        break;
                }

                // Para encontrar o closurePosition, usamos uma sobrecarga do método IndexOf para especificar
                // que nossa busca pelo matchingSymbol deve começar em openingPosition na string. 
    
                openingPosition += 1;
                closingPosition = message.IndexOf(matchingSymbol, openingPosition);

                // Por fim, use as técnicas que já aprendemos para exibir a substring:

                int length = closingPosition - openingPosition;
                Console.WriteLine(message.Substring(openingPosition, length));
            }
            */


            //Diversos tópicos foram abordados nesta unidade. Lembre - se dos pontos mais importantes:

            // IndexOf() informa a primeira posição de um caractere ou uma cadeia de caracteres dentro de outra cadeia de caracteres.
            // IndexOf() retornará - 1 se não for possível encontrar uma correspondência.
            // Substring() retorna apenas a parte especificada de uma cadeia de caracteres usando uma posição inicial e um comprimento opcional.
            // LastIndexOf() retorna a última posição de um caractere ou uma cadeia de caracteres dentro de outra cadeia de caracteres.
            // IndexOfAny() retorna a primeira posição de uma matriz de char que ocorre dentro de outra cadeia de caracteres.
            // Geralmente, há mais de uma maneira de resolver um problema.Usamos duas técnicas diferentes para localizar todas as instâncias de um determinado caractere ou cadeia de caracteres.
            // Evite valores mágicos codificados.Em vez disso, defina uma variável const. O valor de uma variável constante não pode ser alterado após a inicialização.



            // Remove() e Replace()

            // O método Remove() funciona de forma semelhante ao método Substring().
            // Você fornecerá uma posição inicial e o comprimento para remover esses
            // caracteres da cadeia de caracteres.
            /*
            string data = "12345John Smith          5000  3  ";
            string updatedData = data.Remove(5, 20);
            Console.WriteLine(updatedData);
            */

            // O método Replace() é diferente dos outros usados até agora, pois substitui
            // todas as instâncias dos caracteres especificados, não apenas a primeira ou
            // a última.
            /*
            string message = "This--is--ex-amp-le--da-ta";
            message = message.Replace("--", " ");
            message = message.Replace("-", "");
            Console.WriteLine(message);
            */
            Console.ReadLine();
        }
    }
}
