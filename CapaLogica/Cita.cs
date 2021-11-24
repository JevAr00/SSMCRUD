using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Cita:Persona
    {
        public int idCita { get; set; }
        public string descripcion { get; set; }
        public string nombreDoctor { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }
    }
}
