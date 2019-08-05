using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Fiap.UI.HelloWorld.Model
{
    class Pessoa
    {
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public Pessoa() { }
        // atributo - field/campo
        private int _idade;

        // gets e sets - propriedades
        public string Nome { get; set; } // implicito
        public int Idade { get => _idade; set => _idade = value; } // explicito
    }
}
