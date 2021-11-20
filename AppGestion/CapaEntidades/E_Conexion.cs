using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaEntidades
{
    public class cConexion
    {   //==============ATRIBUTOS==================
        private SqlConnection aConexion;
        private SqlDataAdapter aAdaptador;
        private DataSet aDatos;
        //=============METODOS=====================
        public cConexion()
        {   //-- iniciar conexion
            aDatos = new DataSet();
            aAdaptador = new SqlDataAdapter();
            // realizar la conexion
            string CadenaConexion = @"Data Source=DESKTOP-104NIAI\SQLEXPRESS;Initial Catalog=AppGestion;Integrated Security=True";
            aConexion = new SqlConnection(CadenaConexion);
        }
        //-------------Propiedades---------------
        public SqlConnection Conexion
        {
            get { return aConexion; }
        }
        //---------------------------------------
        public SqlDataAdapter Adaptador
        {
            get { return aAdaptador; }
        }
        //---------------------------------------
        public DataSet Datos
        {
            get { return aDatos; }
        }
        //-----------Servicios-------------------
        //--- Metodos para ejecutar metodos sql server
        //--- devuelve el resultado en la tabla cero del dataset
        public virtual DataSet EjecutarSelect(string pConsulta)
        {   //metodo para ejecutar consultas del tipo SELECT
            aAdaptador.SelectCommand = new SqlCommand(pConsulta, aConexion);
            aDatos = new DataSet();
            aAdaptador.Fill(aDatos);
            return aDatos;
        }
        //--------------------------------------------------------------------
        //--- Metodo para ejecutar instrucciones DML. No retorna resultados
        //--------------------------------------------------------------------
        public virtual void EjecutarComando(string pComando)
        {   //metodo para ejecutar consultas del tipo INSERT, UPDATE, DELETE
            SqlCommand oComando = new SqlCommand(pComando, aConexion);
            aConexion.Open();
            oComando.ExecuteNonQuery();
            aConexion.Close();
        }

    }
}
