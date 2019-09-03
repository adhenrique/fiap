using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Fiap.Web.AspNet.Models
{
    [Table("Tb_Sorvete")]
    public class Sorvete
    {
        [Column("Id"), HiddenInput]
        public int SorveteId { get; set; }

        [Required, MaxLength(50)]
        public string Nome { get; set; }

        [Display(Name = "Data de Vencimento"), DataType(DataType.Date)]
        public DateTime DataVencimento { get; set; }

        public bool Vegano { get; set; }

        public TipoSorvete Tipo { get; set; }
    }
}
