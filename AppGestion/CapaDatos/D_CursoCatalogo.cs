using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using CapaEntidades;
using System.Windows.Forms;

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
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ELIMINARCATALOGO", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                cmd.Parameters.AddWithValue("@IDCatalogo", idCatalogo);

                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch 
            {
                string mensaje = "No se puede eliminar el curso del catalogo debido a que el curso ya esta en curso.";
                MessageBox.Show(mensaje, "Error");
            }
        }

        public void CrearCursoCatalogo(E_CursoCatalogo curso)
        {

            SqlCommand cmd = new SqlCommand("SP_INSERTARCATALOGO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDCatalogo", curso.IdCatalogo);
            cmd.Parameters.AddWithValue("@SemestreLectivo", curso.SemestreLectivo);
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
            cmd.Parameters.AddWithValue("@SemestreLectivo", curso.SemestreLectivo);
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
        public DataTable ListarMatriculados(string IdCatalogo, DateTime date)
        {
            DataTable table = new DataTable();
            SqlDataReader readRows;
            SqlCommand cmd = new SqlCommand("SP_ListarMatriculados", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IdCatalogo", IdCatalogo);
            cmd.Parameters.AddWithValue("@Fecha", date);
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
        // Verificar si existe un curso del catalogo
        public bool ExisteCursoCatalogo(string CodCursoCatalogo)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_EXISTE_CURSOCATALOGO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CURSOCATALOGO", CodCursoCatalogo);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            bool existeCod = false;
            //-- Verificando si CodCursoCatalogo existe
            if (tabla.Rows.Count == 1) existeCod = true;
            conexion.Close();
            return existeCod;
        }

        // Editar el codigo de un docente Teorico en el catálogo
        public void EditarDocenteTeorico(string CodCursoCatalogo, string CodDocenteT)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAR_DOCENTETEORICO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@CURSOCATALOGO", CodCursoCatalogo);

            if (CodDocenteT != "") //Si no es una cadena vacia
                cmd.Parameters.AddWithValue("@CodDocenteTeorico", CodDocenteT);
            else //Si es una cadena vacia
                cmd.Parameters.AddWithValue("@CodDocenteTeorico", DBNull.Value); //Pasando NULL como parametro

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        // Editar el codigo de un docente Práctico en el catálogo
        public void EditarDocentePractico(string CodCursoCatalogo, string CodDocenteP)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAR_DOCENTEPRACTICO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CURSOCATALOGO", CodCursoCatalogo);
            if(CodDocenteP != "") //Si no es una cadena vacia
                cmd.Parameters.AddWithValue("@CodDocentePractico", CodDocenteP);
            else //Si es una cadena vacia
                cmd.Parameters.AddWithValue("@CodDocentePractico", DBNull.Value); //Pasando NULL como parametro

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        //Nuevo Catalago
        public string Nuevo()
        {

            SqlCommand cmd = new SqlCommand("NuevoCatalogo", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.CommandTimeout = 30;
            SqlCommandBuilder.DeriveParameters(cmd);
            cmd.ExecuteNonQuery();
            conexion.Close();
            return (string)cmd.Parameters["@RETURN_VALUE"].Value;
        }
        public DataTable ListarCursosCatalogo2()
        {
            try
            {

                DataTable table = new DataTable();
                SqlDataReader readRows;
                SqlCommand cmd = new SqlCommand("ListarCursosCatalogo2", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                readRows = cmd.ExecuteReader();
                table.Load(readRows);

                readRows.Close();
                conexion.Close();

                return table;
            }
            catch (Exception ex)
            {
                
                return null;

            }
        }

    }
}
