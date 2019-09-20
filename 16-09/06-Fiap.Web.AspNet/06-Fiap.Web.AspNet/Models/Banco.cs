using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.Models
{
    public class Banco
    {
        public int BancoId { get; set; }
        public string Nome { get; set; }
        public int Numero { get; set; }
        public bool Agencia { get; set; }


        //Relacionamento
        public IList<Cartao> Cartoes { get; set; }
        public IList<FundoInvestimentoBanco> FundoInvestimentoBancos { get; set; }
    }
}
