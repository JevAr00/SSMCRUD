using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos.Entities
{
    public class Doctor:Persona
    {
        public int idDoctor { get; set; }
        public int idArea { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string telefono { get; set; }
        public string diasLaborales { get; set; }
        public char disponibilidad { get; set; }
        public char activo { get; set; }
    }
}
