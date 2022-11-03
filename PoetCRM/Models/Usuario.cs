using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PoetCRM.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }

        [Display(Name = "Usuario de Login")]
        public string Login { get; set; } // Estaba definido en el UML como "Usuario" pero no se permite tener una columna con nombre de Tabla

        [Display(Name = "Contraseña")]
        public string Clave { get; set; }
        
        [Display(Name = "Nombre del usuario")]
        public string NombreUsuario { get; set; }

        [Display(Name = "Usuario de alta")]
        public Boolean Activo { get; set; }

    }
}
