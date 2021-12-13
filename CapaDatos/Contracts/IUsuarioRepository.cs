using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Entities;

namespace CapaDatos.Contracts
{
    /// <summary>
    /// Declara metodos adicionales que debe contener UsuarioRepository. 
    /// </summary>
    /// <remarks>Implementa <see cref="IGenericRepository{Entity}"/></remarks>
    public interface IUsuarioRepository:IGenericRepository<Usuario>
    {
        /// <summary>
        /// Verifica si un usuario existe en la base de datos
        /// </summary>
        /// <returns>Si usuario buscado esta registrado</returns>
        bool Login(Usuario Entity);
    }
}
