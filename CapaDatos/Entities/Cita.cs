using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos.Entities
{
    public class Cita
    {
        public int idCita { get; set; }
        public string descripcion { get; set; }
        public string nombreDoctor { get; set; }
        public string cedulaPaciente { get; set; }
        public string nombrePaciente { get; set; }
        public string correoPaciente { get; set; }
        public string telefonoPaciente { get; set; }
        public DateTime fecha { get; set; }
        public string hora { get; set; }

    }
}
