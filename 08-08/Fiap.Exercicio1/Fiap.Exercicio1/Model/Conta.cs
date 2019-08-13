using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Banco.Model
{
    abstract class Conta
    {
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public DateTime DataAbertura { get; set; }
        public decimal Saldo { get; protected set; }

        public abstract void Retirar(decimal valor);

        public virtual void Depositar(decimal valor)
        {
            Saldo += valor;
        }
    }
}
