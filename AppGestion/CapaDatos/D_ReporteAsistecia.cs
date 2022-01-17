using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using CapaEntidades;
using CapaDatos;
using System.Windows.Forms;

namespace CapaDatos
{
    public class D_ReporteAsistecia
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public DataTable ReporteAsistencia(string IdCatalogo,string FechaInicio,string FechaFin)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_ReporteAsistencia", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IdCatalogo", IdCatalogo);
            cmd.Parameters.AddWithValue("@FechaInicio", FechaInicio);
            cmd.Parameters.AddWithValue("@FechaFin", FechaFin);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            return tabla;
        }
        public string recuperarIdCat(string NombreAsig, string CodDocente,string Grupo)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_recuperarIdCat_Doc_y_Asignatura", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NombreAsignatura", NombreAsig);
            cmd.Parameters.AddWithValue("@CodDocente", CodDocente);
            cmd.Parameters.AddWithValue("@Grupo", Grupo);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            conexion.Close();

            string id = tabla.Rows[0][0].ToString();
            return id;
        }
    }
}
