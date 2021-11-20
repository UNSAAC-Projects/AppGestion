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
            SqlCommand cmd = new SqlCommand("SP_LISTARCURSOSCATALOGO", conexion);
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
        public void BorrarCursoCatalogo(int id)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID", id);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void CrearCursoCatalogo(E_CursoCatalogo curso)
        {

            SqlCommand cmd = new SqlCommand("SP_INSERTAR", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@CODASIGNATURAGRUPO", curso.CodAsignaturaGrupo);
            cmd.Parameters.AddWithValue("@CODASIGNATURA", curso.CodAsignatura);
            cmd.Parameters.AddWithValue("@DIA", curso.Dia);
            cmd.Parameters.AddWithValue("@HORASTEORICAS", curso.HorasTeoricas);
            cmd.Parameters.AddWithValue("@HORASPRACTICAS", curso.HorasPracticas);
            cmd.Parameters.AddWithValue("@HORAINICIO", curso.HoraInicio);
            cmd.Parameters.AddWithValue("@HORAFIN", curso.HoraFin);
            cmd.Parameters.AddWithValue("@GRUPO", curso.Grupo);
            cmd.Parameters.AddWithValue("@AULA", curso.Aula);


            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarCursoCatalogo(E_CursoCatalogo curso)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAR", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            //cmd.Parameters.AddWithValue("@CODASIGNATURAGRUPO", curso.CodAsignaturaGrupo);
            //cmd.Parameters.AddWithValue("@CODASIGNATURA", curso.CodAsignatura);
            cmd.Parameters.AddWithValue("@DIA", curso.Dia);
            cmd.Parameters.AddWithValue("@HORASTEORICAS", curso.HorasTeoricas);
            cmd.Parameters.AddWithValue("@HORASPRACTICAS", curso.HorasPracticas);
            cmd.Parameters.AddWithValue("@HORAINICIO", curso.HoraInicio);
            cmd.Parameters.AddWithValue("@HORAFIN", curso.HoraFin);
            //cmd.Parameters.AddWithValue("@GRUPO", curso.Grupo);
            cmd.Parameters.AddWithValue("@AULA", curso.Aula);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
