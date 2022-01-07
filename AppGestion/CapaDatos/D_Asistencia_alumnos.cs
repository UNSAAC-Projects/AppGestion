using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using CapaEntidades;

namespace CapaDatos
{
    public class D_Asistencia_alumnos
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public void InsertarAsistenciaAlumno(E_Asistencia_alumnos asistencia_alumno)
        {

            SqlCommand cmd = new SqlCommand("SP_InsertarAsistenciaAlumno", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@Fecha", asistencia_alumno.fecha);
            cmd.Parameters.AddWithValue("@IdCatalogo", asistencia_alumno.idcatalogo);
            cmd.Parameters.AddWithValue("@CodAlumno", asistencia_alumno.codalumno);
            cmd.Parameters.AddWithValue("@Nombres", asistencia_alumno.nombres);
            cmd.Parameters.AddWithValue("@Asistio", asistencia_alumno.asistio);
            cmd.Parameters.AddWithValue("@Observacion", asistencia_alumno.observacion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}