namespace CapaDatos.Entities
{
    public class Doctor:Persona
    {
        public int idDoctor { get; set; }
        public int idArea { get; set; }
        public string diasLaborales { get; set; }
        public string disponibilidad { get; set; }
        public string activo { get; set; }
    }
}
