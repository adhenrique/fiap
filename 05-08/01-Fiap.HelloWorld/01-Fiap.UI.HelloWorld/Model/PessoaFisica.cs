using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Fiap.UI.HelloWorld.Model
{
    class PessoaFisica : Pessoa
    {
        public PessoaFisica(string nome, string rg) :base(nome)
        {
            Rg = rg;
        }
        public PessoaFisica() { }
        // propriedades
        public long Cpf { get; set; }
        public string Rg { get; set; }
    }
}
