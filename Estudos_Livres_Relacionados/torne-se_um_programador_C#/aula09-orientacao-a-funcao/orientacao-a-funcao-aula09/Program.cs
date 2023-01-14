using Funcoes;
using Calculo;
using Diretorio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;
using Tela;
using Classes;

namespace orientacao_a_funcao_aula09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Menu.Criar();

            var clientes = Cliente.LerClientes();

            /*
            var cliente = new Cliente();
            cliente.Nome = "Erick";
            cliente.Telefone = "11980304135";
            cliente.CPF = "45693323806";
            cliente.Gravar();

            var cliente2 = new Cliente();
            cliente2.Nome = "Joyce";
            cliente.Telefone = "11940208433";
            cliente.CPF = "65795331866";
            cliente2.Gravar();
            */
        }
    }
}
