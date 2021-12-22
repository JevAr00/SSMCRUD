namespace CapaLogica.Models
{
    public abstract class PersonaModel
    {
        private string cedula;
        private string nombre;
        private string apellidos;
        private string telefono;

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
