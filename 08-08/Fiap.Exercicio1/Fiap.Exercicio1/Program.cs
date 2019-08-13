using Fiap.Banco.Model;
using Fiap.Exercicio1.Model;
using System;

namespace Fiap.Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente()
            {
                Numero = 1,
                Agencia = 1,
                DataAbertura = DateTime.Now,
                Tipo = TipoConta.Comum,
            };
            //cc.Tipo = TipoConta.Comum;
            cc.Depositar(12000);
            cc.Retirar(13000);

            // 8.0d -> double | 8.0f -> float | 8.0m -> decimal
            ContaPoupanca cp = new ContaPoupanca();
            cp.Taxa = 12;
            cp.Depositar(30000);
            cp.Retirar(1000);

            Console.WriteLine(cp.Saldo);
        }
    }
}
