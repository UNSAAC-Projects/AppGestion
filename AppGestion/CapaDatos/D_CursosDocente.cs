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
    }
}
