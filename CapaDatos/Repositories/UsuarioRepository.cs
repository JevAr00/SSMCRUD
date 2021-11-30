using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Contracts;
using CapaDatos.Entities;
using MySql.Data.MySqlClient;

namespace CapaDatos.Repositories
{
    public class UsuarioRepository : MasterRepository, IUsuarioRepository
    {
        private string insert;

        public UsuarioRepository()
        {
            insert = "insert into usuarios values(default,@nombre,@passUser)";
        }

        public int Create(Usuario Entity)
        {
            parametros = new List<MySqlParameter>();
            parametros.Add(new MySqlParameter("@nombre", Entity.nombre));
            parametros.Add(new MySqlParameter("@passUser", Entity.passUser));
            return ExecuteNonQuery(insert);
        }

        public int Delete(int EntityID)
        {
            //No requerido
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> Read()
        {
            //No requerido
            throw new NotImplementedException();
        }

        public int Update(Usuario Entity)
        {
            //No requerido
            throw new NotImplementedException();
        }
    }
}
