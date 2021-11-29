using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Contracts;
using CapaDatos.Entities;
using System.Data;
using MySql.Data.MySqlClient;

namespace CapaDatos.Repositories
{
    public class AreaRepository : MasterRepository, IAreaRepository
    {
        private string insert;
        private string update;
        private string delete;
        private string selectAll;

        public AreaRepository()
        {
            selectAll = "select * from areas";
            insert = "insert into areas values(@nombre,@edificio,@habilitada)";
            update = "update areas set nombre=@nombre, edificio=@edificio, habilitada=@habilitada where idArea=@id";
            delete = "delete from areas where idArea=@id";
        }

        public int Create(Area Entity)
        {
            parametros = new List<MySqlParameter>();
            parametros.Add(new MySqlParameter("@nombre", Entity.nombre));
            parametros.Add(new MySqlParameter("@edificio", Entity.edificio));
            parametros.Add(new MySqlParameter("@habilitada", Entity.habilitada));
            return ExecuteNonQuery(insert);
        }

        public int Delete(int EntityID)
        {
            return 1;
        }

        public IEnumerable<Area> Read()
        {
            DataTable resultadoTabla = ExecuteReader(selectAll);
            var listaAreas = new List<Area>();
            foreach (DataRow item in resultadoTabla.Rows)
            {
                listaAreas.Add(new Area
                {
                    idArea = Convert.ToInt32(item[0]),
                    nombre = item[1].ToString(),
                    edificio = item[2].ToString(),
                    habilitada = item[3].ToString()
                });
            }
            return listaAreas;
        }

        public int Update(Area Entity)
        {
            return 1;
        }
    }
}
