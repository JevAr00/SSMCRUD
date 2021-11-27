using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Contracts;
using CapaDatos.Entities;
using System.Data;
using System.Data.SqlClient;

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
            selectAll = "select * from Areas";
            insert = "insert into Areas values(@nombre,@edificio,@habilitada)";
            update = "update Areas set nombre=@nombre, edificio=@edificio, habilitada=@habilitada where idArea=@id";
            delete = "delete from Areas where idArea=@id";
        }

        public int Create(Area Entity)
        {
            parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@nombre", Entity.nombre));
            parametros.Add(new SqlParameter("@edificio", Entity.edificio));
            parametros.Add(new SqlParameter("@habilitada", Entity.habilitada));
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
