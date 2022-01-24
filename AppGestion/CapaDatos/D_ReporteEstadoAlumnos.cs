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
    public class D_ReporteEstadoAlumnos
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public DataTable MostrarReporteEstado(string IdCatalogo, DateTime FechaActual)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_ReporteEstadoAlumno", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IdCatalogo", IdCatalogo);
            cmd.Parameters.AddWithValue("@FechaActual", FechaActual);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            return tabla;
        }
    }
}
