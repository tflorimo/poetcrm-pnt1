using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PoetCRM.Models
{
    public class ObraSocial
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdObraSocial { get; set; }

        [Display(Name ="Descripcion")]
        public string Nombre { get; set; }

    }
}
