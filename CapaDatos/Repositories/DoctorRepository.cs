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
    public class DoctorRepository:MasterRepository,IDoctorRepository
    {
        private string insert;
        private string update;
        private string delete;
        private string selectAll;
        private string selectByName;

        public DoctorRepository()
        {
            selectAll = "select * from doctores";
            selectByName = "select id_doctor, nombre from doctores";
            insert = "insert into doctores values(default,@idArea,@cedula,@nombre,@apellido,@telefono,@diasLaborales,@disponibilidad,@activo)";
            update = "update doctores set idArea=@idArea, cedula=@cedula, nombre=@nombre, apellidos=@apellido, telefono=@telefono, diaslaborales=@diasLaborales, disponibilidad=@disponibilidad, activo=@activo where idDoctor=@id";
            delete = "delete from doctores where idDoctor=@id";

            
        }
        public int Create(Doctor Entity)
        {
            parametros = new List<MySqlParameter>();
            parametros.Add(new MySqlParameter("@idArea", Entity.idArea));
            parametros.Add(new MySqlParameter("@cedula",Entity.cedula));
            parametros.Add(new MySqlParameter("@nombre", Entity.nombre));
            parametros.Add(new MySqlParameter("@apellido", Entity.apellidos));
            parametros.Add(new MySqlParameter("@telefono", Entity.telefono));
            parametros.Add(new MySqlParameter("@diasLaborales", Entity.diasLaborales));
            parametros.Add(new MySqlParameter("@disponibilidad", Entity.disponibilidad));
            parametros.Add(new MySqlParameter("@activo", Entity.activo));
            return ExecuteNonQuery(insert);
        }

        public int Delete(int EntityID)
        {
            parametros = new List<MySqlParameter>();
            parametros.Add(new MySqlParameter("@id", EntityID));
            return ExecuteNonQuery(delete);
        }

        public IEnumerable<Doctor> Read()
        {
            DataTable resultadoTabla = ExecuteReader(selectAll);
            var listaDoctor = new List<Doctor>();
            foreach (DataRow item in resultadoTabla.Rows)
            {
                listaDoctor.Add(new Doctor
                {
                    idDoctor = Convert.ToInt32(item[0]),
                    idArea = Convert.ToInt32(item[1]),
                    cedula = item[2].ToString(),
                    nombre = item[3].ToString(),
                    apellidos = item[4].ToString(),
                    telefono = item[5].ToString(),
                    diasLaborales = item[6].ToString(),
                    disponibilidad = Convert.ToChar(item[7]),
                    activo = Convert.ToChar(item[8])

                });
            }
            return listaDoctor;
        }

        public int Update(Doctor Entity)
        {
            parametros = new List<MySqlParameter>();
            parametros.Add(new MySqlParameter("@id", Entity.idDoctor));
            parametros.Add(new MySqlParameter("@idArea", Entity.idArea));
            parametros.Add(new MySqlParameter("@cedula", Entity.cedula));
            parametros.Add(new MySqlParameter("@nombre", Entity.nombre));
            parametros.Add(new MySqlParameter("@apellido", Entity.apellidos));
            parametros.Add(new MySqlParameter("@telefono", Entity.telefono));
            parametros.Add(new MySqlParameter("@diasLaborales", Entity.diasLaborales));
            parametros.Add(new MySqlParameter("@disponibilidad", Entity.disponibilidad));
            parametros.Add(new MySqlParameter("@activo", Entity.activo));
            return ExecuteNonQuery(update);
        }

        public IEnumerable<Doctor> GetNames()
        {
            DataTable resultadoTabla = ExecuteReader(selectByName);
            var listaDoctor = new List<Doctor>();
            foreach (DataRow item in resultadoTabla.Rows)
            {
                listaDoctor.Add(new Doctor
                {
                    idDoctor = Convert.ToInt32(item[0].ToString()),
                    nombre = item[1].ToString(),
                });
            }
            return listaDoctor;
        }
    }
}
