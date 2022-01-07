using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Cliente
    {
        public string Nome;
        public string Telefone;
        public string CPF;

        /// <summary>
        /// Construtor da classe
        /// </summary>
        /// <param name="nome">Para preencher o nome do cliente</param>
        /// <param name="cpf">Para preencher o CPF do cliente</param>
        public Cliente(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
        }
        public Cliente() { }
        public virtual void Gravar()
        {
            var clientes = Cliente.LerClientes();
            clientes.Add(this);
            if (File.Exists(caminhoBase()))
            {
                StreamWriter sw = new StreamWriter(caminhoBase());
                sw.WriteLine("nome;telefone;cpf");
                foreach (Cliente c in clientes)
                {
                    var linha = c.Nome + ";" + c.CPF + ";" + c.Telefone + ";";
                    sw.WriteLine(linha);
                }
                sw.Close();
            }
        }
        private static string caminhoBase()
        {
            return ConfigurationManager.AppSettings["BaseDeClientes"];
        }

        public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();
            if (File.Exists(caminhoBase()))
            {
                using (StreamReader arquivo = File.OpenText(caminhoBase()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var clienteArquivos = linha.Split(';');
                        var cliente = new Cliente
                        {
                            Nome = clienteArquivos[0], Telefone = clienteArquivos[1], CPF = clienteArquivos[2]
                        };
                        clientes.Add(cliente);
                    }
                }
            }
            return clientes;
        }
    }
}
