using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zooline.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        [Display(Name = "Segundo nombre")]
        public string SegundoNombre { get; set; }
        [Display(Name = "Primer Apellido")]
        public string PrimerApellido { get; set; }
        [Display(Name = "Segundo Apellido")]
        public string SegundoApellido { get; set; }
        [Display(Name = "Cedula de Identidad")]
        public string CI { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public string Telefono { get; set; }
    }
}
