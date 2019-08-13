using Fiap.Exercicio1.Exceptions;
using Fiap.Exercicio1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Banco.Model
{
    class ContaPoupanca : Conta, IContaInvestimento
    {
        // propriedades
        public decimal Taxa { get; set; }
        // atributos
        private decimal _rendimento;

        public ContaPoupanca() { }
        public ContaPoupanca(decimal rendimento)
        {
            _rendimento = rendimento;
        }

        public override void Retirar(decimal valor)
        {
            if (Saldo < valor + Taxa)
            {
                throw new SaldoInsuficienteException();
            }
            Saldo -= (valor + Taxa);
        }

        public decimal CalcularRetornoInvestimento()
        {
            return Saldo * _rendimento;
        }
    }
}
