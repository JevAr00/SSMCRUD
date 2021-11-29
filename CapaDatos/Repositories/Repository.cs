using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace CapaDatos.Repositories
{
    /// <summary>
    /// Declara y solicita los datos para crear la conexion a la base de datos
    /// </summary>
    public abstract class Repository
    {
        private readonly string connectionString;

        public Repository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["conexionBD"].ToString();
        }

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
