using CapaDatos.Entities;
using System.Collections.Generic;

namespace CapaDatos.Contracts
{
    /// <summary>
    /// Declara metodos adicionales que debe contener DoctorRepository. 
    /// </summary>
    /// <remarks>Implementa <see cref="IGenericRepository{Entity}"/></remarks>
    public interface IDoctorRepository : IGenericRepository<Doctor>
    {
        /// <summary>
        /// Obtiene los nombres de los doctores registradas
        /// </summary>
        IEnumerable<Doctor> GetNames();
    }
}
