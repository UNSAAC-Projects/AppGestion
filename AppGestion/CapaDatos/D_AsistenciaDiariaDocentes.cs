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

       
        public void GuardarAsistenciasDiarias(DataTable tabla, string fecha)
        {
            //string Unidad, Capitulo, Tema, Horas, Finalizado, Observacion;
            string codDocente, nombres, asistio, observacion;

            string ComandoSQL = $"delete from TAsistenciaDiariaDocentes where Fecha = '{fecha}'\n";

            foreach (DataRow fila in tabla.Rows)
            {
                codDocente = fila["CodDocente"].ToString();
                nombres = fila["Nombres"].ToString();
                asistio = fila["Asistio"].ToString();
                observacion = fila["Observacion"].ToString();
                ComandoSQL += $"Insert Into TAsistenciaDiariaDocentes values ('{fecha}','{codDocente}','{nombres}','{asistio}','{observacion}')\n";
            }
            SqlCommand cmd = new SqlCommand(ComandoSQL, conexion);
            conexion.Open();

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public DataTable ReporteAsistenciaDocenteDiaria(string FechaInicio, string FechaFin)
        {
            try
            {
                DataTable tabla = new DataTable();
                SqlCommand cmd = new SqlCommand("sp_ReporteAsistenciaDocentes", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                cmd.Parameters.AddWithValue("@FechaInicio", FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", FechaFin);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                conexion.Close();
                return tabla;
            }
            catch
            {
                MessageBox.Show("No hay asistencias registradas o el rango de fechas es incorrecto");
                conexion.Close();
                return null;
            }

        }
    }
}
