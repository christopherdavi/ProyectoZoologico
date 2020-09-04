using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zooline.Models
{
    public class Especie
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NombreCientifico { get; set; }
        public double Estatura { get; set; }
        public double Ancho { get; set; }
        public string descripcion { get; set; }
        public string Reino { get; set; }

    }
}
