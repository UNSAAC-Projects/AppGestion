﻿using System;
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
    public class D_Horario
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public void CrearHorario(E_Horario horario)
        {

            SqlCommand cmd = new SqlCommand("SP_INSERTARHORARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@Dia", horario.Dia);
            cmd.Parameters.AddWithValue("@HoraInicio", horario.HoraInicio);
            cmd.Parameters.AddWithValue("@HoraFin", horario.HoraFin);
            cmd.Parameters.AddWithValue("@IDCatalogo", horario.IdCatalogo);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
