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
    public class D_ReporteEstadoDocentes
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public DataTable MostrarReporteEstado()
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_ReporteEstadoDocentes", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            return tabla;
        }

    }
}
