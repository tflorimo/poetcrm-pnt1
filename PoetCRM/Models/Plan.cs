using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PoetCRM.Models
{
    public class Plan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPlan { get; set; }

        [Display(Name = "Descripcion")]
        public string NombrePlan { get; set; }

        [ForeignKey("ObraSocial")]
        public int IdObraSocial { get; set; }

        public ObraSocial ObraSocial { get; set; }

    }
}
