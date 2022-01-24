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

        // Obtener los 3 temas anteriores y posteriores a dictar
        public List<string> ObtenerTemasProximos(string IdCatalogo, out int indexSiguienteTema) 
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_OBTENER_TEMAS_PROXIMOS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDCatalogo", IdCatalogo);
            cmd.Parameters.Add("@IDTema", SqlDbType.Int).Direction = ParameterDirection.Output; //Parametro de salida

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla); //Rellenar tabla
            int idSiguienteTema = Convert.ToInt32(cmd.Parameters["@IDTema"].Value); //Obtener variable de salida

            conexion.Close();

            indexSiguienteTema = -1; //Valor por defecto
            //Recorrer tabla y guardar en lista
            if (tabla.Rows.Count > 0) //Si tabla no está vacia
            {
                List<string> listaTemas = new List<string>();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    //Si IDTema es igual a idSiguienteTema
                    if (idSiguienteTema.ToString() == tabla.Rows[i]["Id"].ToString())
                        indexSiguienteTema = i; //Guardar indice
                    //Agregar tema a lista   
                    listaTemas.Add(tabla.Rows[i]["Tema"].ToString());   
                }
                return listaTemas;
            }
            else return null;
        }

        //Obtener el siguiente tema a dictar de un determinado catalogo
        public string SiguienteTema(string IdCatalogo)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_SIGUIENTE_TEMA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDCatalogo", IdCatalogo);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            conexion.Close();
            if (tabla.Rows.Count > 0) //Si tabla no está vacia
            {
                //arrayTema[0] = tabla.Rows[0]["Id"].ToString();
                //arrayTema[1] = tabla.Rows[0]["Unidad"].ToString();
                //arrayTema[2] = tabla.Rows[0]["Capitulo"].ToString();
                //arrayTema[3] = tabla.Rows[0]["Tema"].ToString();
                string siguienteTema = tabla.Rows[0][0].ToString(); //Obtener tema
                return siguienteTema;
            }
            else //Si está vacia
            {
                //La tabla retornará vacia cuando se completen todos los temas
                //del plan de sesiones y no haya un siguiente tema
                return null;
            }
        }
        public void GuardarPlanSesiones(DataTable tabla, string IDCatalogo) 
        {
            
            string Unidad, Capitulo, Tema, Horas, Finalizado, Observacion,VariacionHora;

            string ComandoSQL = $"exec SP_Eliminar_PLANXCATALOGO \'{IDCatalogo}\' \n";

            foreach (DataRow fila in tabla.Rows) {
                Unidad = fila["Unidad"].ToString();
                Capitulo=fila["Capitulo"].ToString();
                Tema=fila["Tema"].ToString();
                Horas=fila["Horas"].ToString();
                Finalizado=fila["Finalizado"].ToString();
                Observacion=fila["Observacion"].ToString();
                VariacionHora = fila["VariacionHora"].ToString();

                //Observacion == "" ? "\'\'": fila["Observacion"].ToString();

                //if (Observacion == "") { Observacion = "\'\'"; }

                ComandoSQL +=$"Insert Into TPlanSesiones values (\'{Unidad}\',\'{Capitulo}\',\'{Tema}\',\'{Horas}\',\'{IDCatalogo}\',\'{Finalizado}\',\'{Observacion}\' ,\'{VariacionHora}\')\n";

                
            }
            SqlCommand cmd = new SqlCommand(ComandoSQL, conexion);
            conexion.Open();
            
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void  InsertarNuevoTema(int idTemaAnterior, string codCatalogo, string tema)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_TEMA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IdAnterior", idTemaAnterior);
            cmd.Parameters.AddWithValue("@IDCatalogo", codCatalogo);
            cmd.Parameters.AddWithValue("@Tema", tema);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
