using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Classes
{
    public class Cliente
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nome"></param>
        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public Cliente()
        {

        }

        public string Nome;
        public string Telefone;
        public string CPF;

        public void Gravar()
        {
            //
        }

        private static string caminhoBaseClientes()
        {
            return ConfigurationManager.AppSettings["BaseDeClientes"];
        }

        public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();

            if (File.Exists(caminhoBaseClientes()))
            {
                using (StreamReader arquivo = File.OpenText(caminhoBaseClientes()))
                {
                    string linha;
                    int i = 0;
                    Console.WriteLine("\n====================");
                    Console.WriteLine($"Arquivo.");
                    Console.WriteLine("====================");

                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var clienteArquivo = linha.Split(';');

                        var cliente = new Cliente();
                        cliente.Nome = clienteArquivo[0];
                        cliente.Telefone = clienteArquivo[1];
                        cliente.CPF = clienteArquivo[2];

                        clientes.Add(cliente);
                        Thread.Sleep(300);
                    }
                }
            }

            return clientes;
        }
    }
}
