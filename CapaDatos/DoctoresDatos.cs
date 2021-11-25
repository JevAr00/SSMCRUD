using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaLogica;


namespace CapaDatos
{
    class DoctoresDatos : ICrud<Doctor>
    {
        SqlConnection Conexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString);

        public bool Create(Doctor obj)
        {
            
           string sentenciaSql = $"Insert into values ({obj.idArea},'{obj.cedula}','{obj.nombre}','{obj.apellidos}','{obj.telefono}','{obj.diasLaborales}',{obj.disponibilidad},{obj.activo})";

            Conexion.Open();

            SqlCommand command = new SqlCommand(sentenciaSql);


            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else {
                return false;
            }

            Conexion.Close();


            
        }

        public bool Delete(Doctor obj)
        {
            Conexion.Open();
            string sentenciaSql = $" delete from where id={obj.idDoctor}";

            SqlCommand command = new SqlCommand(sentenciaSql);

            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

            Conexion.Close();


        }

        public void Read(Doctor obj)
        {
            string sentenciaSql = "select * from  ";

            SqlCommand command = new SqlCommand(sentenciaSql);

            SqlDataReader registro = command.ExecuteReader();

            command.ExecuteNonQuery();

            Conexion.Close();



        }

        public bool Update(Doctor obj)
        {
            string sentenciaSql = $"update set id_area={obj.idArea} cedula={obj.cedula}, nombre={obj.nombre}, apellido={obj.apellidos}, telefono={obj.telefono}, diasLaborales={obj.diasLaborales}, disponibilidad={obj.disponibilidad}, activo={obj.activo} where id={obj.idDoctor}";

            SqlCommand command = new SqlCommand(sentenciaSql);

            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

            Conexion.Close();



        }
    }
}
