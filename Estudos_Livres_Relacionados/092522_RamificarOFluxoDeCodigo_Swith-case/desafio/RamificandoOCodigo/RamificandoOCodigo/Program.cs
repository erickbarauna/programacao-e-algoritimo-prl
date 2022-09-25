using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RamificandoOCodigo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // OBJETIVO DO DESAFIO
            /*
            O foco desse desafio é reescrever o código no editor .NET
            para usar uma técnica diferente para realizar essencialmente a mesma tarefa.
            Este desafio ajudará você a ver os pontos fortes e fracos da instrução
            switch-case quando comparada a uma instrução if-elseif -else.
            */


            // PROPÓSITO
            /*
            Suponha que trabalhamos para uma loja de lembranças em uma cidade
            universitária que vende camisetas, moletons e outros presentes
            com o logotipo e as cores da instituição. Um relatório mensal de vendas
            usa a descrição completa, assim como a SKU (Unidade de Manutenção de Estoque)
            dos produtos vendidos. Pediram que reescrevêssemos determinadas partes
            do código para ficarem mais legíveis. Uma das tarefas é simplificar a conversão
            de um SKU em uma descrição usando a instrução switch.
            */

            // EXEMPLO DO DESÁFIO COM IF-ELSEIF-ELSE

            // SKU = Stock Keeping Unit - Unidade de armazenamento
            /*
            string sku = "01-MR-G";

            string[] produto = sku.Split('-');

            string tipo = "";
            string cor = "";
            string tamanho = "";

            if (produto[0] == "01")
            {
                tipo = "Suéter";
            }
            else if (produto[0] == "02")
            {
                tipo = "Camisa";
            }
            else if (produto[0] == "03")
            {
                tipo = "Moletom";
            }
            else
            {
                tipo = "Outro";
            }


            if (produto[1] == "PT")
            {
                cor = "Preto";
            }
            else if (produto[1] == "MR")
            {
                cor = "Marrom";
            }
            else
            {
                cor = "Branco";
            }


            if (produto[2] == "P")
            {
                tamanho = "Pequeno";
            }
            else if (produto[2] == "M")
            {
                tamanho = "Médio";
            }
            else if (produto[2] == "G")
            {
                tamanho = "Grande";
            }
            else
            {
                tamanho = "Tamanho único";
            }
            */



            // EXEMPLO DO DESAFIO COM SWITCH CASE

            // SKU = Stock Keeping Unit - Unidade de armazenamento
            /*
            string sku = "01-MR-G";

            string[] produto = sku.Split('-');

            string tipo = "";
            string cor = "";
            string tamanho = "";

            switch (produto[0])
            {
                case "01":
                    tipo = "Suéter";
                    break;

                case "02":
                    tipo = "Camisa";
                    break;

                case "03":
                    tipo = "Moletom";
                    break;

                default:
                    tipo = "Outro";
                    break;
            }


            switch (produto[01])
            {
                case "PT":
                    cor = "Preto";
                    break;

                case "MR":
                    cor = "Marrom";
                    break;

                default:
                    cor = "Branco";
                    break;
            }


            switch (produto[2])
            {
                case "P":
                    tamanho = "Pequeno";
                    break;

                case "M":
                    tamanho = "Médio";
                    break;

                case "G":
                    tamanho = "Grande";
                    break;

                default:
                    tamanho = "Tamanho único";
                    break;
            }


            Console.WriteLine($"Produto: {tipo}, {tamanho}, {cor} ");
            Console.ReadLine();
            */
        }
    }
}
