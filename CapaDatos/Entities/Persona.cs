using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entities
{
    public abstract class Persona
    {
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string telefono { get; set; }
    }
}
