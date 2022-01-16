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
    public class D_ListaAsistencias
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public void GuardarDatosAsistencia(E_ListaAsistencias eListaAsistencias)
        {
            SqlCommand cmd = new SqlCommand("SP_InsertarDatosAsistencia", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@Tema", eListaAsistencias.tema);
            cmd.Parameters.AddWithValue("@Fecha", eListaAsistencias.fecha);
            cmd.Parameters.AddWithValue("@IDCatalogo", eListaAsistencias.idcatalogo);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public DataTable ListarAsistenciaCurso(string idCatalogo)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_ListarAsistenciasCurso", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IdCatalogo", idCatalogo);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            conexion.Close();
            return tabla;
        }
    }
}
