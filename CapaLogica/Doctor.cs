using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Doctor : Persona
    {
        public int idDoctor { get; set; }
        public int idArea { get; set; }
        public string diasLaborales { get; set; }
        public string disponibilidad { get; set; }
        public string activo { get; set; }
    }
}
