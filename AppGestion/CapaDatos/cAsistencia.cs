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
    public class cAsistencia
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public void CrearAsistencia(E_Asistencia asistencia_curso)
        {

            SqlCommand cmd = new SqlCommand("SP_InsertarAsistenciaReporte", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@Curso", asistencia_curso.curso);
            cmd.Parameters.AddWithValue("@Tema", asistencia_curso.tema);
            cmd.Parameters.AddWithValue("@Fecha", asistencia_curso.fecha);
            cmd.Parameters.AddWithValue("@Asistencia", asistencia_curso.asistencia);
            cmd.Parameters.AddWithValue("@IDCatalogo", asistencia_curso.idcatalogo);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

    }
   
}
