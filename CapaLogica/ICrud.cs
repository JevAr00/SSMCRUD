using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    ///<summary>
    ///Define los metodos principales de CRUD
    ///</summary>
    ///<typeparam name="T">Entidad de base de datos</typeparam>
    public interface ICrud<T>
    {
        ///<summary>
        ///Inserta informacion en la base de datos
        ///</summary>
        ///<param name="obj">Objeto de tipo <typeparamref name="T"/></param>
        bool Create(T obj);

        ///<summary>
        ///Lee informacion de la base de datos
        ///</summary>
        ///<param name="obj">Objeto de tipo <typeparamref name="T"/></param>
        void Read(T obj);

        ///<summary>
        ///Modifica informacion en la base de datos
        ///</summary>
        ///<param name="obj">Objeto de tipo <typeparamref name="T"/></param>
        bool Update(T obj);

        ///<summary>
        ///Elimina informacion en la base de datos
        ///</summary>
        ///<param name="obj">Objeto de tipo <typeparamref name="T"/></param>
        bool Delete(T obj);
    }
}
