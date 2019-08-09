using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Fiap.UI.HelloWorld.Model
{
    abstract class Pessoa
    {
        // atributo - field/campo
        private int _idade;

        // gets e sets - propriedades
        public string Nome { get; set; } // implicito
        public int Idade { get => _idade; set => _idade = value; } // explicito

        // Métodos
        public abstract void Comer();

        // virtual -> permite a sobrescrita do método
        public virtual void Respirar()
        {
            Console.WriteLine("Respirando...");
        }

        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public Pessoa() { }
    }
}
