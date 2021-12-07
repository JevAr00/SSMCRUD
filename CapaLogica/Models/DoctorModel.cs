using CapaDatos.Contracts;
using CapaDatos.Entities;
using CapaDatos.Repositories;
using CapaLogica.ValueObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CapaLogica.Models
{
    public class DoctorModel : PersonaModel
    {
        private int idDoctor;
        private int idArea;
        private string diasLaborales;
        private char disponibilidad;
        private char activo;

        private List<DoctorModel> listaDoctores;
        private IDoctorRepository doctorRepositorio;
        public EntityState estadoEntidad { private get; set; }

        public int IdDoctor { get => idDoctor; set => idDoctor = value; }
        public int IdArea { get => idArea; set => idArea = value; }
        public string DiasLaborales { get => diasLaborales; set => diasLaborales = value; }
        public char Disponibilidad { get => disponibilidad; set => disponibilidad = value; }
        public char Activo { get => activo; set => activo = value; }

        public DoctorModel()
        {
            doctorRepositorio = new DoctorRepository();
        }

        /// <summary>
        /// Observa cual es el <see cref="EntityState"/> de DoctorModel, luego se encarga de ejecutar los metodos insert, update o delete segun corresponda.
        /// </summary>
        /// <returns>Mensaja con respuesta</returns>
        public string ejecutarAccion()
        {
            string message = null;
            try
            {
                var doctorDataModel = new Doctor();
                doctorDataModel.idDoctor = idDoctor;
                doctorDataModel.idArea = idArea;
                doctorDataModel.cedula = Cedula;
                doctorDataModel.nombre = Nombre;
                doctorDataModel.apellidos = Apellidos;
                doctorDataModel.telefono = Telefono;
                doctorDataModel.diasLaborales = diasLaborales;
                doctorDataModel.disponibilidad = disponibilidad;
                doctorDataModel.activo = activo;

                switch (estadoEntidad)
                {
                    case EntityState.Added:
                        doctorRepositorio.Create(doctorDataModel);
                        message = $"Se ha registrado {doctorDataModel.nombre}, como nueva persona contratada.";
                        break;

                    case EntityState.Modified:
                        doctorRepositorio.Update(doctorDataModel);
                        message = $"El doctor con ID:{doctorDataModel.idDoctor}, se ha modificado";
                        break;

                    case EntityState.Deleted:
                        doctorRepositorio.Delete(idDoctor);
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
        public async Task<List<DoctorModel>> GetAll()
        {
            return await Task.Run(() =>
            {
                var doctorDataModel = doctorRepositorio.Read();
                listaDoctores = new List<DoctorModel>();
                foreach (Doctor item in doctorDataModel)
                {
                    listaDoctores.Add(new DoctorModel
                    {
                        idDoctor = item.idDoctor,
                        idArea = item.idArea,
                        Cedula = item.cedula,
                        Nombre = item.nombre,
                        Apellidos = item.apellidos,
                        Telefono = item.telefono,
                        diasLaborales = item.diasLaborales,
                        disponibilidad = item.disponibilidad,
                        activo = item.activo
                    });
                }
                return listaDoctores;
            });
        }

        /// <summary>
        /// Obtiene todos los nombres de doctores que se encuentran en una tabla de la base de datos
        /// </summary>
        /// <returns>Lista con nombres de doctores de la tabla de la base de datos</returns>
        public async Task<List<DoctorModel>> GetNombres()
        {
            return await Task.Run(() =>
            {
                var doctorDataModel = doctorRepositorio.GetNames();
                listaDoctores = new List<DoctorModel>();
                foreach (Doctor item in doctorDataModel)
                {
                    listaDoctores.Add(new DoctorModel
                    {
                        Nombre = item.nombre,
                    });
                }
                return listaDoctores;
            });
        }

        /// <summary>
        /// Compara el nombre recibido con la lista recibida de <see cref="GetNombres"/> para obtener su id
        /// </summary>
        /// <param name="lista">Lista que contiene todos los ID y nombre desde <see cref="GetNombres"/> </param>
        /// <param name="nombre">Nombre que recibe para compararse</param>
        /// <returns>ID de nombre que coincide</returns>
        public int GetID(List<DoctorModel> lista, string nombre)
        {
            int id = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (nombre == lista[i].Nombre)
                {
                    id = lista[i].idArea;
                }
            }
            return id;
        }

        /// <summary>
        /// Realiza una busqueda en los registros obtenidos de la base de datos.
        /// </summary>
        /// <param name="filtro">Caracteres para realizar busqueda</param>
        /// <returns>Registro buscado de la base de datos</returns>
        public IEnumerable<DoctorModel> Buscar(string filtro)
        {
            return listaDoctores.FindAll(doctor => doctor.Nombre.ToLower().Contains(filtro.ToLower()) || doctor.Cedula.Contains(filtro));
        }
    }
}
