using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using CapaEntidades;
using System.IO;

namespace CapaDatos
{
    public class D_Silabo
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public bool ExisteSilabo(string CodCatalogo)
        {//Comprobar si existe el silabo de un catalogo
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_EXISTE_SILABO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDCatalogo", CodCatalogo);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            bool existeSilabo = false;
            //-- Verificando si CodCursoCatalogo existe
            if (tabla.Rows.Count == 1) existeSilabo = true;
            conexion.Close();
            return existeSilabo;
        }

        public void ActualizarSilabo(string RutaPDF, string CodCatalogo)
        {
            byte[] bytespdf = File.ReadAllBytes(RutaPDF);
            SqlCommand cmd = new SqlCommand("SP_ACTUALIZAR_SILABO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDCatalogo", CodCatalogo);
            cmd.Parameters.Add("@Contenido", SqlDbType.VarBinary).Value = bytespdf;
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void SubirSilabo(string RutaPDF, string CodCatalogo)
        {
            byte[] bytespdf = File.ReadAllBytes(RutaPDF);
            SqlCommand cmd = new SqlCommand("SP_SUBIRSILABO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.Add("@Contenido", SqlDbType.VarBinary).Value = bytespdf;
            cmd.Parameters.AddWithValue("@IDCatalogo", CodCatalogo);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public byte[] ObtenerBytesSilabo(string CodCatalogo)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_OBTENER_SILABO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDCatalogo",CodCatalogo);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                byte[] bytespdf = (byte[])dr["Contenido"];
                conexion.Close();
                return bytespdf;
            }
            else
            {
                conexion.Close();
                return null;
            }
        }
    }
}
