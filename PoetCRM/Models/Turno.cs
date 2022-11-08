using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PoetCRM.Models
{
    public class Turno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdTurno { get; set; }

        [Display(Name = "Fecha del turno")]
        public DateTime Fecha { get; set; }

        [ForeignKey("Paciente")]
        public int IdPaciente { get; set; }

        [ForeignKey("Doctor")]
        public int IdDoctor { get; set; }

        [ForeignKey("Especialidad")]
        public int IdEspecialidad { get; set; }
    }
}
