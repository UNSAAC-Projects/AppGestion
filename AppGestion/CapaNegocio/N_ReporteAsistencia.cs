﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using CapaEntidades;
using CapaDatos;


namespace CapaNegocio
{
    public class N_ReporteAsistencia
    {
        D_ReporteAsistecia data = new D_ReporteAsistecia();
        public DataTable ReporteAsistencia(string IdCatalogo, string FechaInicio, string FechaFin)
        {
            return data.ReporteAsistencia(IdCatalogo, FechaInicio, FechaFin);
        }
        public string recuperarIdCat(string NombreAsig, string CodDocente)
        {
            return data.recuperarIdCat(NombreAsig, CodDocente);
        }
    }
}