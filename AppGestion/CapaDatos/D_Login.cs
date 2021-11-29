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
    public class D_Login
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public string ObtenerNombreUsuario(string CodDocente)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_OBTENER_NOMBREUSUARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CodDocente", CodDocente);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            conexion.Close();

            //-- Verificando si CodCursoCatalogo existe
            string nombreUsuario;
            if (tabla.Rows.Count == 1)
            {
                nombreUsuario = tabla.Rows[0][0].ToString();
                return CodDocente;
            }
            else
            {
                return null;
            }
        }
    }
}
