using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PoetCRM.Models
{
    public class Paciente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPaciente { get; set; }

        [Display(Name = "Nombre del Paciente")]
        public string NombrePaciente { get; set; }

        [Display(Name = "Numero de Documento")]
        public string Dni { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Display(Name = "Numero de Historial Clinico")]
        public int HistorialClinico { get; set; }

        [Display(Name = "Correo electronico")]
        public string Mail { get; set; }

        [Display(Name = "Numero de telefono")]
        public string Telefono { get; set; }

        [ForeignKey("Plan")]
        public int IdPlan { get; set; }

        public Plan Plan{ get; set; }
    }
}
