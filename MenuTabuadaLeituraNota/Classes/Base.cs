using Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Base : IPessoa
    {
        public string Nome;
        public string Telefone;
        public string CPF;

        public void SetNome(string nome) { this.Nome = nome; }
        public void SetTelefone(string telefone) { this.Telefone = telefone; }
        public void SetCPF(string cpf) { this.CPF = cpf; }
        public Base(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
        }
        public Base() { }

        public virtual void Gravar()
        {
            var dados = this.Ler();
            dados.Add(this);
            StreamWriter sw = new StreamWriter(diretorioComArquivo());
            sw.WriteLine("nome;telefone;cpf");
            foreach (Base b in dados)
            {
                var linha = b.Nome + ";" + b.CPF + ";" + b.Telefone + ";";
                sw.WriteLine(linha);
            }
            sw.Close();
        }

        public List<IPessoa> Ler()
        { 
            var dados = new List<IPessoa>();
            if (File.Exists(diretorioComArquivo()))
            {
                using (StreamReader arquivo = File.OpenText(diretorioComArquivo()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var BaseArquivo = linha.Split(';');
                        var b = (IPessoa)Activator.CreateInstance(this.GetType());
                        b.SetNome(BaseArquivo[0]);
                        b.SetTelefone(BaseArquivo[1]);
                        b.SetCPF(BaseArquivo[2]);
                        dados.Add(b);
                    }
                }
            }
            return dados;
        }
        private string diretorioComArquivo()
        {
            return ConfigurationManager.AppSettings["CaminhoArquivos"] + this.GetType().Name + ".txt";
        }
    }
}
 