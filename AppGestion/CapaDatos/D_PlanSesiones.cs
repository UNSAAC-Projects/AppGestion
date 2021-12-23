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
    public class D_PlanSesiones
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public DataTable ListarPlanSesiones(string CodCatalogo)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_OBTENER_PLANSESIONES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CodCatalogo", CodCatalogo);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            return tabla;
        }
        public void CrearPlanSesiones(E_PlanSesiones tema)
        {

            SqlCommand cmd = new SqlCommand("SP_INSERTARPLANSESIONES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@Unidad", tema.Unidad);
            cmd.Parameters.AddWithValue("@Capitulo", tema.Capitulo);
            cmd.Parameters.AddWithValue("@Tema", tema.Tema);
            cmd.Parameters.AddWithValue("@HorasProgramadas", tema.HorasProgramadas);
            cmd.Parameters.AddWithValue("@Fecha", tema.Fecha);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void EditarPlanSesiones(E_Asignatura curso)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARPLANSESIONES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@Unidad", curso.codAsigantura);
            cmd.Parameters.AddWithValue("@Capitulo", curso.idPlan);
            cmd.Parameters.AddWithValue("@Tema", curso.nombre);
            cmd.Parameters.AddWithValue("@HorasProgramadas", curso.creditos);
            cmd.Parameters.AddWithValue("@Fecha", curso.categoria);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void EliminarPlanSesiones(string codTema)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ELIMINARTEMA_PLANSESIONES", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                cmd.Parameters.AddWithValue("@Id", codTema);

                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {
                string mensaje = "No se puede eliminar porque el tema ya se avanzo.";
                MessageBox.Show(mensaje, "Error");
            }

        }

        public List <string> ObtenerTemasXUnidad(string IdCatalogo, string Unidad) 
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_OBTENER_TEMASXUNIDAD", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDCatalogo", IdCatalogo);
            cmd.Parameters.AddWithValue("@Unidad", Unidad);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            //return tabla;
            List<string> ListaTemas = new List<string>();

            //Recorrer tabla y guardar en lista
            foreach (DataRow row in tabla.Rows)
            {
                ListaTemas.Add(row[0].ToString());
            }

            return ListaTemas;
        }

        //Obtener ultimo tema completado
        public string[] UltimoTemaCompletado(string IdCatalogo)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_ULTIMO_TEMACOMPLETADO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDCatalogo", IdCatalogo);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            string[] arrayTema = new string[4];
            if(tabla.Rows.Count > 0) //Si tabla no está vacia
            {
                arrayTema[0] = tabla.Rows[0]["Id"].ToString();
                arrayTema[1] = tabla.Rows[0]["Unidad"].ToString();
                arrayTema[2] = tabla.Rows[0]["Capitulo"].ToString();
                arrayTema[3] = tabla.Rows[0]["Tema"].ToString();
                conexion.Close();
                return arrayTema;
            }
            else //Si está vacia
            {
                conexion.Close();
                return null;
            }
            

        }
    }
}
