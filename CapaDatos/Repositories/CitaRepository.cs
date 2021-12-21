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
    public class CitaRepository : MasterRepository, ICitaRepository
    {
        private string insert;
        private string update;
        private string delete;
        private string selectAll;

        public CitaRepository()
        {
            selectAll = "select * from citas";
            insert = "insert into citas values(default,@descripcion,@nombreDoctor,@cedulaPaciente,@nombrePaciente,@correoPaciente,@telefonoPaciente,@fecha,@hora)";
            update = "update citas set descripcion=@descripcion, nombreDoctor=@nombreDoctor, cedula=@cedulaPaciente, nombre=@nombrePaciente, correoPaciente=@correoPaciente, telefono=@telefonoPaciente, fecha=@fecha, hora=@hora where idCita=@id";
            delete = "delete from citas where idCita=@id";
        }

        public int Create(Cita Entity)
        {
            parametros = new List<MySqlParameter>();
            parametros.Add(new MySqlParameter("@descripcion", Entity.descripcion));
            parametros.Add(new MySqlParameter("@nombreDoctor", Entity.nombreDoctor));
            parametros.Add(new MySqlParameter("@cedulaPaciente", Entity.cedula));
            parametros.Add(new MySqlParameter("@nombrePaciente", Entity.nombre));
            parametros.Add(new MySqlParameter("@correoPaciente", Entity.correoPaciente));
            parametros.Add(new MySqlParameter("@telefonoPaciente", Entity.telefono));
            parametros.Add(new MySqlParameter("@fecha", Entity.fecha));
            parametros.Add(new MySqlParameter("@hora", Entity.hora));
            return ExecuteNonQuery(insert);
        }

        public int Delete(int EntityID)
        {
            parametros = new List<MySqlParameter>();
            parametros.Add(new MySqlParameter("@id", EntityID));
            return ExecuteNonQuery(delete);
        }

        public IEnumerable<Cita> Read()
        {
            DataTable resultadoTabla = ExecuteReader(selectAll);
            var listaCitas = new List<Cita>();
            foreach (DataRow item in resultadoTabla.Rows)
            {
                listaCitas.Add(new Cita
                {
                    idCita = Convert.ToInt32(item[0]),
                    descripcion = item[1].ToString(),
                    nombreDoctor = item[2].ToString(),
                    cedula = item[3].ToString(),
                    nombre = item[4].ToString(),
                    correoPaciente = item[5].ToString(),
                    telefono = item[6].ToString(),
                    fecha = item[7].ToString(),
                    hora = item[8].ToString()

                });
            }
            return listaCitas;
        }

        public int Update(Cita Entity)
        {
            parametros = new List<MySqlParameter>();
            parametros.Add(new MySqlParameter("@id", Entity.idCita));
            parametros.Add(new MySqlParameter("@descripcion", Entity.descripcion));
            parametros.Add(new MySqlParameter("@nombreDoctor", Entity.nombreDoctor));
            parametros.Add(new MySqlParameter("@cedulaPaciente", Entity.cedula));
            parametros.Add(new MySqlParameter("@nombrePaciente", Entity.nombre));
            parametros.Add(new MySqlParameter("@correoPaciente", Entity.correoPaciente));
            parametros.Add(new MySqlParameter("@telefonoPaciente", Entity.telefono));
            parametros.Add(new MySqlParameter("@fecha", Entity.fecha));
            parametros.Add(new MySqlParameter("@hora", Entity.hora));
           
            return ExecuteNonQuery(update);
        }
    }
}
