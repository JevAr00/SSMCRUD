using CapaDatos.Entities;
using System.Collections.Generic;

namespace CapaDatos.Contracts
{
    /// <summary>
    /// Declara metodos adicionales que debe contener AreaRepository. 
    /// </summary>
    /// <remarks>Implementa <see cref="IGenericRepository{Entity}"/></remarks>
    public interface IAreaRepository:IGenericRepository<Area>
    {
        /// <summary>
        /// Obtiene los nombres de las areas registradas
        /// </summary>
        IEnumerable<Area> GetNames();
    }
}
