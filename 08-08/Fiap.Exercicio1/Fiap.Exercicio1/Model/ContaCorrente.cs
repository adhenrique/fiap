using Fiap.Exercicio1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Banco.Model
{
    class ContaCorrente : Conta
    {
        public TipoConta Tipo { get; set; }

        public override void Depositar(decimal valor)
        {
            Saldo = valor;
        }

        public override void Retirar(decimal valor)
        {
            if (Tipo == TipoConta.Comum && Saldo < 0)
            {
                throw new Exception("Retirada nao permitida.");
            }
            Saldo -= valor;
        }
    }
}
