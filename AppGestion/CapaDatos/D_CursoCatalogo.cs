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
    public class D_CursoCatalogo
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        
        public DataTable ListarCursosCatalogo()
        {
            DataTable table = new DataTable();
            SqlDataReader readRows;
            SqlCommand cmd = new SqlCommand("SP_LISTARCATALOGO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            readRows = cmd.ExecuteReader();
            table.Load(readRows);

            readRows.Close();
            conexion.Close();

            return table;
        }
        public DataTable ListarVistaCatalogo()
        {
            DataTable table = new DataTable();
            SqlDataReader readRows;
            SqlCommand cmd = new SqlCommand("SP_VISTACATALOGO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            readRows = cmd.ExecuteReader();
            table.Load(readRows);

            readRows.Close();
            conexion.Close();

            return table;
        }
        
        public DataTable BuscarCursoCatalogo(E_CursoCatalogo curso)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_BUSCARCURSOCATALOGO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", curso.Search);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            return tabla;
        }
        public void EliminarCursoCatalogo(string idCatalogo)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARCATALOGO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDCatalogo", idCatalogo);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void CrearCursoCatalogo(E_CursoCatalogo curso)
        {

            SqlCommand cmd = new SqlCommand("SP_INSERTARCATALOGO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDCatalogo", curso.IdCatalogo);
            cmd.Parameters.AddWithValue("@NroSemestre", curso.NroSemestre);
            cmd.Parameters.AddWithValue("@CodAsignatura", curso.CodAsignatura);
            cmd.Parameters.AddWithValue("@Grupo", curso.Grupo);
            cmd.Parameters.AddWithValue("@Aula", curso.Aula);
            cmd.Parameters.AddWithValue("@CodDocenteTeorico", curso.CodDocenteTeorico);
            cmd.Parameters.AddWithValue("@CodDocentePractico", curso.CodDocentePractico);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarCursoCatalogo(E_CursoCatalogo curso)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARCATALOGO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDCatalogo", curso.IdCatalogo);
            cmd.Parameters.AddWithValue("@NroSemestre", curso.NroSemestre);
            cmd.Parameters.AddWithValue("@CodAsignatura", curso.CodAsignatura);
            cmd.Parameters.AddWithValue("@Grupo", curso.Grupo);
            cmd.Parameters.AddWithValue("@Aula", curso.Aula);
            cmd.Parameters.AddWithValue("@CodDocenteTeorico", curso.CodDocenteTeorico);
            cmd.Parameters.AddWithValue("@CodDocentePractico", curso.CodDocentePractico);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        // Modulos director académico
        public DataTable ListarCatalogoDA()
        {
            DataTable table = new DataTable();
            SqlDataReader readRows;
            SqlCommand cmd = new SqlCommand("SP_LISTACATALOGO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            readRows = cmd.ExecuteReader();
            table.Load(readRows);

            readRows.Close();
            conexion.Close();

            return table;
        }

        public DataTable MostrarHorarioCurso(string CodCursoCatalogo)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_OBTENER_HORARIO_CURSOCATALOGO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CURSOCATALOGO", CodCursoCatalogo);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            return tabla;
        }


    }
}
