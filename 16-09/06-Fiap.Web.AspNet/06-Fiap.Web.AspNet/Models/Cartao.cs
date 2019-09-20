using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.Models
{
    public class Cartao
    {
        public int CartaoId { get; set; }
        public string Nome { get; set; }
        public DateTime DataValidade { get; set; }
        public decimal Limite { get; set; }
        public Boolean Internacional { get; set; }
        public Bandeira Bandeira { get; set; }

        //Relacionamento
        public Banco Banco { get; set; }
        public int BancoId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
