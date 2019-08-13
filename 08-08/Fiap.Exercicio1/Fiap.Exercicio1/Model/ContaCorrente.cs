using Fiap.Exercicio1.Exceptions;
using Fiap.Exercicio1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Banco.Model
{
    sealed class ContaCorrente : Conta
    {
        public TipoConta Tipo { get; set; }

        public override void Retirar(decimal valor)
        {
            if (Tipo == TipoConta.Comum && valor > Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            Saldo -= valor;
        }
    }
}
