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
        public string diasLaborales { get; set; }
        public char disponibilidad { get; set; }
        public char activo { get; set; }
    }
}
