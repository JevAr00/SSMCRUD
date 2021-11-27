using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Contracts;
using CapaDatos.Entities;
using CapaDatos.Repositories;
using CapaLogica.ValueObjects;

namespace CapaLogica.Models
{
    public class AreaModel
    {
        private int idArea;
        private string nombre;
        private string edificio;
        private string habilitada;

        private IAreaRepository areaRepositorio;
        public EntityState estado { private get; set; }
        private List<AreaModel> listaAreas;

        public int IdArea { get => idArea; set => idArea = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Edificio { get => edificio; set => edificio = value; }
        public string Habilitada { get => habilitada; set => habilitada = value; }

        public AreaModel()
        {
            areaRepositorio = new AreaRepository();
        }

        public string guardarCambios()
        {
            return "";
        }

        public List<AreaModel> GetAll()
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
        }
    }
}
