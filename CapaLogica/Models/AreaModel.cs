using CapaDatos.Contracts;
using CapaDatos.Entities;
using CapaDatos.Repositories;
using CapaLogica.ValueObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CapaLogica.Models
{
    public class AreaModel
    {
        private int idArea;
        private string nombre;
        private string edificio;
        private string habilitada;

        private List<AreaModel> listaAreas;
        private IAreaRepository areaRepositorio;
        public EntityState estadoEntidad { private get; set; }

        public int IdArea { get => idArea; set => idArea = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Edificio { get => edificio; set => edificio = value; }
        public string Habilitada { get => habilitada; set => habilitada = value; }

        public AreaModel()
        {
            areaRepositorio = new AreaRepository();
        }

        /// <summary>
        /// Observa cual es el <see cref="EntityState"/> de AreaModel, luego se encarga de ejecutar los metodos insert, update o delete segun corresponda.
        /// </summary>
        /// <returns>Mensaja con respuesta</returns>
        public string ejecutarAccion()
        {
            string message = null;
            try
            {
                var areaDataModel = new Area();
                areaDataModel.idArea = idArea;
                areaDataModel.nombre = nombre;
                areaDataModel.edificio = edificio;
                areaDataModel.habilitada = habilitada;

                switch (estadoEntidad)
                {
                    case EntityState.Added:
                        areaRepositorio.Create(areaDataModel);
                        message = $"Se ha registrado {areaDataModel.nombre}, como una nueva area.";
                        break;

                    case EntityState.Modified:
                        areaRepositorio.Update(areaDataModel);
                        message = $"El area con ID:{areaDataModel.idArea}, se ha modificado";
                        break;

                    case EntityState.Deleted:
                        areaRepositorio.Delete(idArea);
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
        public async Task<List<AreaModel>> GetAll()
        {
            return await Task.Run(() =>
            {
                var areaDataModel = areaRepositorio.Read();
                listaAreas = new List<AreaModel>();
                foreach (Area item in areaDataModel)
                {
                    listaAreas.Add(new AreaModel
                    {
                        idArea = item.idArea,
                        nombre = item.nombre,
                        edificio = item.edificio,
                        habilitada = item.habilitada,
                    });
                }
                return listaAreas;
            });
        }

        /// <summary>
        /// Obtiene todos los nombres de areas que se encuentran en una tabla de la base de datos
        /// </summary>
        /// <returns>Lista con nombres de areas de la tabla de la base de datos</returns>
        public async Task<List<AreaModel>> GetNombres()
        {
            return await Task.Run(() =>
            {
                var areaDataModel = areaRepositorio.GetNames();
                listaAreas = new List<AreaModel>();
                foreach (Area item in areaDataModel)
                {
                    listaAreas.Add(new AreaModel
                    {
                        idArea = item.idArea,
                        nombre = item.nombre,
                    });
                }
                return listaAreas;
            });
        }

        /// <summary>
        /// Compara el nombre recibido con la lista recibida de <see cref="GetNombres"/> para obtener su id
        /// </summary>
        /// <param name="lista">Lista que contiene todos los ID y nombre desde <see cref="GetNombres"/> </param>
        /// <param name="nombre">Nombre que recibe para compararse</param>
        /// <returns>ID de nombre que coincide</returns>
        public int GetID(List<AreaModel> lista, string nombre)
        {
            int id = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if(nombre == lista[i].nombre)
                {
                    id = lista[i].idArea;
                }
            }
            return id;
        }

        /// <summary>
        /// Compara el ID recibido con la lista recibida de <see cref="GetNombres"/> para obtener su nombre
        /// </summary>
        /// <param name="lista">Lista que contiene todos los ID y nombre desde <see cref="GetNombres"/> </param>
        /// <param name="ID">ID que recibe para compararse</param>
        /// <returns>Nombre de ID que coincide</returns>
        public string GetNameByID(List<AreaModel> lista, int ID)
        {
            string nombre = "";
            for (int i = 0; i < lista.Count; i++)
            {
                if (ID == lista[i].idArea)
                {
                    nombre = lista[i].Nombre;
                }
            }
            return nombre;
        }

        /// <summary>
        /// Realiza una busqueda en los registros obtenidos de la base de datos.
        /// </summary>
        /// <param name="filtro">Caracteres para realizar busqueda</param>
        /// <returns>Registro buscado de la base de datos</returns>
        public IEnumerable<AreaModel> Buscar(string filtro)
        {
            return listaAreas.FindAll(area => area.Nombre.ToLower().Contains(filtro.ToLower()));
        }
    }
}
