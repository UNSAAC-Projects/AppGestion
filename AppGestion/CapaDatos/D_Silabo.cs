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
        public void SubirSilabo(string RutaPDF, string CodCatalogo)
        {
            byte[] bytespdf = File.ReadAllBytes(RutaPDF);
            SqlCommand cmd = new SqlCommand("SP_SUBIRSILABO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            //cmd.Parameters.AddWithValue("@IDCatalogo", curso.IdCatalogo);
            cmd.Parameters.Add("@Contenido", SqlDbType.VarBinary).Value = bytespdf;
            cmd.Parameters.AddWithValue("@IDCatalogo", CodCatalogo);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public byte[] ObtenerBytesSilabo(string CodCatalogo)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_VerSilabo", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDCatalogo",CodCatalogo);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                byte[] bytespdf = (byte[])dr["Contenido"];
                //File.WriteAllBytes("SILABO.pdf", bytespdf);
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
