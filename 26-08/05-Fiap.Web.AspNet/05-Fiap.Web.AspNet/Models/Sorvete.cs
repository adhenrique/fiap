using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Fiap.Web.AspNet.Models
{
    public class Sorvete
    {
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de vencimento")]
        public DateTime DataVencimento { get; set; }
        public bool Vegano { get; set; }
        public TipoSorvete Tipo { get; set; }
    }
}
