using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{

    /// <summary>
    /// Define los metodos principales de CRUD
    /// </summary>
    /// <typeparam name="T">Entidad de base de datos</typeparam>
    public interface ICrud<T>
    {
        /// <param name="obj">Objeto de tipo <typeparamref name="T"/></param>
        void Create(T obj);

        /// <param name="obj">Objeto de tipo <typeparamref name="T"/></param>
        void Read(T obj);

        /// <param name="obj">Objeto de tipo <typeparamref name="T"/></param>
        void Update(T obj);

        /// <param name="obj">Objeto de tipo <typeparamref name="T"/></param>
        void Delete(T obj);
    }
}
