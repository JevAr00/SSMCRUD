using CapaDatos.Entities;

namespace CapaDatos.Contracts
{
    /// <summary>
    /// Declara metodos adicionales que debe contener CitaRepository. 
    /// </summary>
    /// <remarks>Implementa <see cref="IGenericRepository{Entity}"/></remarks>
    public interface ICitaRepository:IGenericRepository<Cita>
    {
        //metodos a implementar (especificos)
    }
}
