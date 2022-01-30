using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using CapaEntidades;

namespace CapaDatos
{
    public class D_CursosDocente
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public DataTable ListarCursosDocente(string CodDocente)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_LISTARCURSOSXDOCENTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CodDocente", CodDocente);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            conexion.Close();

            //Verificar si existen datos en la tabla
            //Nota: Si tabla siempre tendra una fila por los valores NULL
            if (tabla.Rows.Count == 1 && tabla.Rows[0]["GrupoAsignatura"].ToString() == "") 
                return null;
            else 
                return tabla;
        }
        public string ObtenerCodCatalogo(string GrupoAsignatura)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_EXISTE_CURSOCATALOGO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CURSOCATALOGO", GrupoAsignatura);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            string CodCatalogo = tabla.Rows[0][0].ToString();

            conexion.Close();
            return CodCatalogo;
        }
        public DataTable ListarMatriculados(string IdCatalogo)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_ListarMatriculadosxCurso", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IdCatalogo", IdCatalogo);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            conexion.Close();

            //Verificar si existen datos en la tabla
            //Nota: Si tabla siempre tendra una fila por los valores NULL
            if (tabla.Rows.Count == 1 && tabla.Rows[0]["Nombre"].ToString() == "")
                return null;
            else
                return tabla;
        }
    }
}
