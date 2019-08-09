using Fiap.Banco.Model;
using Fiap.Exercicio1.Model;
using System;

namespace Fiap.Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();
            cc.Tipo = TipoConta.Comum;
            cc.Depositar(12000);

            Console.WriteLine(cc.Saldo);
        }
    }
}
