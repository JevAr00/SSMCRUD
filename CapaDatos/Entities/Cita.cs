namespace CapaDatos.Entities
{
    public class Cita : Persona
    {
        public int idCita { get; set; }
        public string descripcion { get; set; }
        public string nombreDoctor { get; set; }
        public string correoPaciente { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }

    }


}
