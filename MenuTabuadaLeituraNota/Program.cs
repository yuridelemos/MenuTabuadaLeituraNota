using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using Tela;

namespace MesaDeTeste
{
    public class LerArquivo
    {
        public static void Main(string[] args)
        {
            // Menu.Principal();
            Usuario u = new Usuario();
            u.Nome = "Francisco";
            u.Telefone = "1231231";
            u.CPF = "1231232";
            u.Gravar();
        }
    }
}