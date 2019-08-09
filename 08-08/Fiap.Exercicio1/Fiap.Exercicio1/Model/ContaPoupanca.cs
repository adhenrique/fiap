using Fiap.Exercicio1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Banco.Model
{
    class ContaPoupanca : Conta, IContaInvestimento
    {
        public decimal Taxa { get; set; }
        private decimal _rendimento;
        public decimal Rendimento { get; set; }

        public ContaPoupanca() { }
        public ContaPoupanca(decimal rendimento)
        {
            Rendimento = rendimento;
        }

        public override void Depositar(decimal valor)
        {
            Saldo = valor;
        }

        public override void Retirar(decimal valor)
        {
            if (Saldo > 0)
            {
                Saldo -= (valor - Taxa);
            }
            else
            {
                throw new Exception("Retirada nao permitida. Você nao possui crédito suficiente");
            }
        }

        public decimal CalcularRetornoInvestimento()
        {
            return Saldo * Rendimento;
        }
    }
}
