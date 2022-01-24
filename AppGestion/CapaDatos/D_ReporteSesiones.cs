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
    public class D_ReporteSesiones
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public DataTable MostrarReporteSesiones(string IdCatalogo)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_REPORTE_SESIONES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IdCatalogo", IdCatalogo);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            return tabla;
        }

        public DataTable MostrarReporteSesionesDocente(string IdDocente)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_REPORTE_AVANCE_SESIONES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IdDocente",IdDocente);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            return tabla;
        }
    }
}
