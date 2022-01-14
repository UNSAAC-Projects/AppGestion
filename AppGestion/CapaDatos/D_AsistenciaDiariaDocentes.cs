using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using CapaEntidades;
using CapaDatos;
using System.Windows.Forms;

namespace CapaDatos
{
    public class D_AsistenciaDiariaDocentes
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public DataTable ListarDocentesActivos(string semestreLectivo, DateTime fecha)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_ListarDocentesActivos", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@SemestreLectivo", semestreLectivo); //varchar(8)
            cmd.Parameters.AddWithValue("@Fecha", fecha); //Date


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            return tabla;
        }
    }
}
