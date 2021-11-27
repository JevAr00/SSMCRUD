using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.Repositories
{
    public abstract class MasterRepository:Repository
    {
        protected List<SqlParameter> parametros;

        protected int ExecuteNonQuery(string transactSQL)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = transactSQL;
                    command.CommandType = CommandType.Text;
                    foreach(SqlParameter item in parametros)
                    {
                        command.Parameters.Add(item);
                    }
                    int resultado = command.ExecuteNonQuery();
                    parametros.Clear();
                    return resultado;
                }
            }
        }

        protected DataTable ExecuteReader(string transactSQL)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = transactSQL;
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    using (var table = new DataTable())
                    {
                        table.Load(reader);
                        reader.Dispose();
                        return table;
                    }
                }
            }
        }
    }
}
