using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Entities;

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
