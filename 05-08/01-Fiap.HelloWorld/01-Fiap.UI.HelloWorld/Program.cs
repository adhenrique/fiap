using _01_Fiap.UI.HelloWorld.Model;
using System;

namespace _01_Fiap.UI.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciar uma classe pessoa fisica
            // atribuir um valor para o nome
            // exibir valor
            PessoaFisica pessoa = new PessoaFisica();
            pessoa.Nome = "Sêrgio";
            Console.WriteLine(pessoa.Nome);

            // instanciar outra pessoa fisica
            PessoaFisica pessoa2 = new PessoaFisica()
            {
                Nome = "Thiag",
                Rg = "123123",
                Cpf = 123123123,
                Idade = 30
            };

            Console.WriteLine(pessoa2.Idade);
        }
    }
}
