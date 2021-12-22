using System.Collections.Generic;

namespace CapaDatos.Contracts
{
    /// <summary>
    /// Interfaz generica para los repositorios. Contiene los metodos CRUD
    /// <para>Se recibe un tipo generico (un <paramref name="Entity"/>) que nos permite especificar un tipo concreto</para>
    /// </summary>
    /// <remarks><typeparamref name="Entity"/> es el mapeo de una tabla de la base de datos en una clase</remarks>
    /// <typeparam name="Entity">
    /// Tipo generico el cual se le especifica que tomara valor como una clase para ser usado en el tipo que se recibe
    /// </typeparam>
    public interface IGenericRepository<Entity> where Entity:class
    {
        /// <summary>
        /// Inserta informacion en la base de datos
        /// </summary>
        int Create(Entity Entity);

        /// <summary>
        /// Lee informacion de la base de datos
        /// </summary>
        IEnumerable<Entity> Read();

        /// <summary>
        /// Modifica informacion en la base de datos
        /// </summary>
        int Update(Entity Entity);

        /// <summary>
        /// Elimina informacion en la base de datos
        /// </summary>
        int Delete(int EntityID);
    }
}
