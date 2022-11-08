using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PoetCRM.Models
{
    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDoctor { get; set; }

        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }

        [ForeignKey("Especialidad")]
        public int IdEspecialidad { get; set; }

    }
}
