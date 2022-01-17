using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using CapaEntidades;

namespace CapaDatos
{
    public class D_Docente
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        //Recuperar el codigo de un docente a partir de su nombre y apellido
        public string RecuperarCodDocente(string nombres, string apellidos)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_RECUPERAR_CODDOCENTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Nombres", nombres);
            cmd.Parameters.AddWithValue("@Apellidos", apellidos);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            conexion.Close();

            //-- Verificando si CodCursoCatalogo existe
            string CodDocente;
            if (tabla.Rows.Count == 1)
            {
                CodDocente = tabla.Rows[0][0].ToString();
                return CodDocente;
            }
            else
            {
                return null;
            }
        }

        public DataTable ListarDistribucionDocentes()
        {
            DataTable tablaDocentes = new DataTable();
            SqlDataReader readRows;
            SqlCommand cmd = new SqlCommand("SP_LISTA_DOCENTES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            readRows = cmd.ExecuteReader();
            tablaDocentes.Load(readRows);

            readRows.Close();
            conexion.Close();

            return tablaDocentes;
            
        }

        public DataRow HorasDictadoDocente(string CodDocente)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_HORASDICTADO_DOCENTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CodDocente", CodDocente);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            conexion.Close();

            //Verificar si la tabla tiene datos
            if (tabla.Rows.Count != 0) //No está vacio
            {
                return tabla.Rows[0];
            }
            else  //La tabla está vacio;
                return null;
        }

        public DataTable MostrarHorarioDocente(string CodDocente)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_HORARIO_DOCENTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CodDocente", CodDocente);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            return tabla;   
        }

        //Metodo para obtener el horario de un docente de un dia
        public DataTable MostrarHorarioDocenteDia(string codDocente, string nombreDia)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_HORARIO_DOCENTE_DIA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CodDocente", codDocente);
            cmd.Parameters.AddWithValue("@NombreDia", nombreDia);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            return tabla;
        }

        //Metodo para obtener el codigo de asignatura de un respectivo catalogo
        public string ObtenerCodCatalago(string codAsignatura)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_CodCursoCodCatalogo", conexion);
            cmd.CommandType = CommandType.StoredProcedure; 
            conexion.Open();

            cmd.Parameters.AddWithValue("@CodCurso", codAsignatura);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            conexion.Close();

            //-- Verificando si CodCursoCatalogo existe
            string nombreUsuario;
            if (tabla.Rows.Count == 1)
            {
                nombreUsuario = tabla.Rows[0][0].ToString();
                return nombreUsuario;
            }
            else
            {
                return null;
            }
        }
        public DataTable MostrarDatosArchivo(string codCatalogo)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_ListarArchivo", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDCatalogo", codCatalogo);
         

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            return tabla;
        }

        //Funcion para mostrar cursos que dicta un docente
        public string[] CursosDocente(string codDocente)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_CURSOS_DOCENTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CodDocente", codDocente);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();

            if (tabla.Rows.Count != 0)
            {
                //Formar string
                List<string> cursos = new List<string>();
                string codCursoCatalogo, nombreCurso;
                //Recorrer datatable
                foreach (DataRow row in tabla.Rows)
                {
                    codCursoCatalogo = row[0].ToString();
                    nombreCurso = row[1].ToString();

                    cursos.Add($"{codCursoCatalogo} - {nombreCurso}");
                }
                return cursos.ToArray();
            }
            else return  null;
        }
    }
}
