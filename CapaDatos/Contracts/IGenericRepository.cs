using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Contracts
{
    public interface IGenericRepository<Entity> where Entity:class
    {
        ///<summary>
        ///Inserta informacion en la base de datos
        ///</summary>
        ///<param name="Entity">Objeto de tipo <typeparamref name="Entity"/></param>
        int Create(Entity Entity);

        ///<summary>
        ///Lee informacion de la base de datos
        ///</summary>
        IEnumerable<Entity> Read();

        ///<summary>
        ///Modifica informacion en la base de datos
        ///</summary>
        ///<param name="Entity">Objeto de tipo <typeparamref name="Entity"/></param>
        int Update(Entity Entity);

        ///<summary>
        ///Elimina informacion en la base de datos
        ///</summary>
        ///<param name="Entity">Objeto de tipo <typeparamref name="Entity"/></param>
        int Delete(int EntityID);
    }
}
