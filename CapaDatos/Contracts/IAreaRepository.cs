using CapaDatos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Contracts
{
    /// <summary>
    /// Declara metodos adicionales que debe contener AreaRepository. 
    /// </summary>
    /// <remarks>Implementa <see cref="IGenericRepository{Entity}"/></remarks>
    public interface IAreaRepository:IGenericRepository<Area>
    {
        //metodos a implementar (especificos)
    }
}
