using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.Models
{
    public class FundoInvestimentoBanco
    {
        public int FundoInvestimentoId { get; set; }
        public FundoInvestimento FundoInvestimento { get; set; }
        public int BancoId { get; set; }
        public Banco Banco { get; set; }
    }
}
