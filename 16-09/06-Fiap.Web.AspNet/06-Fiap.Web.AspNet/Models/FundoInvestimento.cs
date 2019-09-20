using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.Models
{
    public class FundoInvestimento
    {
        public int FundoInvestimentoId { get; set; }

        public decimal ValorMinimo { get; set; }

        public decimal Rendimento { get; set; }
        public string Nome { get; set; }

        //Relacionamento
        public IList<FundoInvestimentoBanco> FundoInvestimentoBancos { get; set; }
    }
}
