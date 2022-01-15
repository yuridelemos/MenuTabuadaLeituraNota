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
    public class Cliente : Base
    {

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
        
    }
}
