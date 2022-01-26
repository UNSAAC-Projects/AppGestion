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
            try
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
            catch 
            {
                MessageBox.Show("No hay asistencias registradas o el rango de fechas es incorrecto");
                conexion.Close();
                return null;
            }
    
        }
        public DataTable ReporteAvacenDocenteDepartamento()
        {
            try
            {
                DataTable tablaDocentes = new DataTable();
                SqlDataReader readRows;
                SqlCommand cmd = new SqlCommand("SP_REPORTE_AVANCE_SESIONES_DOCENTE", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                readRows = cmd.ExecuteReader();
                tablaDocentes.Load(readRows);

                readRows.Close();
                conexion.Close();

                return tablaDocentes;
            }
            catch
            {
                MessageBox.Show("No hay avances...");
                conexion.Close();
                return null;
            }

        }
        public string recuperarIdCat(string NombreAsig, string CodDocente,string Grupo)
        {
            try
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
            catch 
            {
                MessageBox.Show("El docente no cuenta un curso asignado");
                conexion.Close();
                return null;
            }
        }
    }
}
