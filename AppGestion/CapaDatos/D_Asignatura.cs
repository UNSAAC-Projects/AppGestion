using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using CapaEntidades;
using System.Windows.Forms;

namespace CapaDatos
{
    public class D_Asignatura
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public DataTable ListarAsignaturas()
        {
            DataTable table = new DataTable();
            SqlDataReader readRows;
            SqlCommand cmd = new SqlCommand("SP_LISTARASIGNATURA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            readRows = cmd.ExecuteReader();
            table.Load(readRows);

            readRows.Close();
            conexion.Close();

            return table;
        }
        public DataTable BuscarAsignatura(E_Asignatura asignatura)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_BUSCARASIGNATURA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", asignatura.Buscar);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            return tabla;
        }

        public DataTable BuscarVistaCatalogo(E_Asignatura asignatura)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_BUSCARVISTACATALOGO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", asignatura.Buscar);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            return tabla;
        }

        public void EliminarAsignatura(string codAsignatura)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ELIMINARASIGNATURA", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                cmd.Parameters.AddWithValue("@CodAsignatura", codAsignatura);

                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {
                string mensaje = "No se puede eliminar la asignatura debido a que ya existe un catálogo que lo está usando.";
                MessageBox.Show(mensaje,"Error");
            }
           
        }

        public void CrearAsignatura(E_Asignatura curso)
        {

            SqlCommand cmd = new SqlCommand("SP_INSERTARASIGNATURA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@CodAsignatura", curso.codAsigantura);
            cmd.Parameters.AddWithValue("@IDPlan", curso.idPlan);
            cmd.Parameters.AddWithValue("@Nombre", curso.nombre);
            cmd.Parameters.AddWithValue("@Creditos", curso.creditos);
            cmd.Parameters.AddWithValue("@Categoria", curso.categoria);
            cmd.Parameters.AddWithValue("@HorasPracticas", curso.horasPracticas);
            cmd.Parameters.AddWithValue("@HorasTeoricas", curso.horasTeoricas);
            cmd.Parameters.AddWithValue("@Prerrequisitos", curso.prerrequisitos);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarAsignatura(E_Asignatura curso)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARASIGNATURA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@CodAsignatura", curso.codAsigantura);
            cmd.Parameters.AddWithValue("@IDPlan", curso.idPlan);
            cmd.Parameters.AddWithValue("@Nombre", curso.nombre);
            cmd.Parameters.AddWithValue("@Creditos", curso.creditos);
            cmd.Parameters.AddWithValue("@Categoria", curso.categoria);
            cmd.Parameters.AddWithValue("@HorasPracticas", curso.horasPracticas);
            cmd.Parameters.AddWithValue("@HorasTeoricas", curso.horasTeoricas);
            cmd.Parameters.AddWithValue("@Prerrequisitos", curso.prerrequisitos);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
