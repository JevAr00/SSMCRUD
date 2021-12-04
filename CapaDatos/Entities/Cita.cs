using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos.Entities
{
    public class Cita : Persona
    {
        public int idCita { get; set; }
        public string descripcion { get; set; }
        public string nombreDoctor { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string correoPaciente { get; set; }
        public string telefono { get; set; }
        public DateTime fecha { get; set; }
        public string hora { get; set; }

    }


}
