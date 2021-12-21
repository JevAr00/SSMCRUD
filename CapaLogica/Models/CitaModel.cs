using CapaDatos.Contracts;
using CapaDatos.Entities;
using CapaDatos.Repositories;
using CapaLogica.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Models
{
    public class CitaModel
    {
        private int idCita;
        private string descripcion;
        private string doctor;
        private string cedula;
        private string nombre;
        private string telefono;
        private string correo;
        private string fecha;
        private string hora;

        private List<CitaModel> listaCitas;
        private ICitaRepository citasRepositorio;
        public EntityState estadoEntidad { private get; set; }

        public int IdCita { get => idCita; set => idCita = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Doctor { get => doctor; set => doctor = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }

        public CitaModel()
        {
            citasRepositorio = new CitaRepository();
        }

        /// <summary>
        /// Observa cual es el <see cref="EntityState"/> de CitasModel, luego se encarga de ejecutar los metodos insert, update o delete segun corresponda.
        /// </summary>
        /// <returns>Mensaja con respuesta</returns>
        public string ejecutarAccion()
        {
            string message = null;
            try
            {
                var citaDataModel = new Cita();
                citaDataModel.idCita = IdCita;
                citaDataModel.descripcion = Descripcion;
                citaDataModel.nombreDoctor = Doctor;
                citaDataModel.cedula = Cedula;
                citaDataModel.nombre = Nombre;
                citaDataModel.telefono = Telefono;
                citaDataModel.correoPaciente = Correo;
                citaDataModel.fecha = Fecha;
                citaDataModel.hora = Hora;

                switch (estadoEntidad)
                {
                    case EntityState.Added:
                        citasRepositorio.Create(citaDataModel);
                        message = $"Se ha agendado una nueva cita";
                        break;

                    case EntityState.Modified:
                        citasRepositorio.Update(citaDataModel);
                        message = $"La cita con ID:{citaDataModel.idCita}, se ha modificado";
                        break;

                    case EntityState.Deleted:
                        citasRepositorio.Delete(IdCita);
                        message = "Se ha elimiando correctamente";
                        break;
                }

            }
            catch (Exception e)
            {
                message = $"Un error ha ocurrido\n\nError:\n{e}";
            }
            return message;
        }

        /// <summary>
        /// Obtiene todos los registros que se encuentran en una tabla de la base de datos
        /// </summary>
        /// <returns>Lista con registros de la tabla de la base de datos</returns>
        public async Task<List<CitaModel>> GetAll()
        {
            return await Task.Run(() =>
            {
                var citaDataModel = citasRepositorio.Read();
                listaCitas = new List<CitaModel>();
                foreach (Cita item in citaDataModel)
                {
                    listaCitas.Add(new CitaModel
                    {
                        IdCita = item.idCita,
                        Descripcion = item.descripcion,
                        Doctor = item.nombreDoctor,
                        Cedula = item.cedula,
                        Nombre = item.nombre,
                        Telefono = item.telefono,
                        Correo = item.correoPaciente,
                        Fecha = Convert.ToDateTime(item.fecha).ToString("dd/MM/yyyy"),
                        Hora = item.hora
                    });
                }
                return listaCitas;
            });
        }

        /// <summary>
        /// Realiza una busqueda en los registros obtenidos de la base de datos.
        /// </summary>
        /// <param name="filtro">Caracteres para realizar busqueda</param>
        /// <returns>Registro buscado de la base de datos</returns>
        public IEnumerable<CitaModel> Buscar(string filtro)
        {
            return listaCitas.FindAll(cita => cita.Nombre.ToLower().Contains(filtro.ToLower()) || cita.Cedula.Contains(filtro));
        }
    }
}
