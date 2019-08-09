using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Fiap.UI.HelloWorld.Model
{
    class PessoaFisica : Pessoa, ITrabalhador
    {
        //Métodos

        public override void Respirar()
        {
            Console.WriteLine("Pessoa física respirando");
        }

        public override void Comer()
        {
            Console.WriteLine("Pessoa se alimentando...");
        }

        public void Trabalhar()
        {
            Console.WriteLine("Entregando resultado");
        }

        public PessoaFisica(string nome, string rg) :base(nome)
        {
            Rg = rg;
        }
        public PessoaFisica() { }
        // propriedades
        public long Cpf { get; set; }
        public string Rg { get; set; }
        public EstadoCivil Status { get; set; }
    }
}
