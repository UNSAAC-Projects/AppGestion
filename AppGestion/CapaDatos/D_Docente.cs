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
            DataTable table = new DataTable();
            SqlDataReader readRows;
            SqlCommand cmd = new SqlCommand("SP_DISTRIBUCION_DOCENTES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            readRows = cmd.ExecuteReader();
            table.Load(readRows);

            readRows.Close();
            conexion.Close();

            return table;
        }

    }
}
