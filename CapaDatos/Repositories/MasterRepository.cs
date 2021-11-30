using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace CapaDatos.Repositories
{
    /// <summary>
    /// Contiene los metodos de consulta y no consulta que seran utilizados por cualquier repositorio que se implemente
    /// </summary>
    public abstract class MasterRepository:Repository
    {
        protected List<MySqlParameter> parametros;

        //noconsulta
        protected int ExecuteNonQuery(string transactSQL)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = transactSQL;
                    command.CommandType = CommandType.Text;
                    foreach(MySqlParameter item in parametros)
                    {
                        command.Parameters.Add(item);
                    }
                    int resultado = command.ExecuteNonQuery();
                    parametros.Clear();
                    return resultado;
                }
            }
        }

        //consulta
        protected DataTable ExecuteReader(string transactSQL)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = transactSQL;
                    command.CommandType = CommandType.Text;
                    if (parametros != null)
                    {
                        foreach (MySqlParameter item in parametros)
                        {
                            command.Parameters.Add(item);
                        }
                    }
                    MySqlDataReader reader = command.ExecuteReader();
                    using (var table = new DataTable())
                    {
                        table.Load(reader);
                        reader.Dispose();
                        if(parametros!=null)
                            parametros.Clear();
                        return table;
                    }
                }
            }
        }
    }
}
