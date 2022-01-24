using System;
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
    public class N_ReporteEstadoAlumnos
    {
        D_ReporteEstadoAlumnos data = new D_ReporteEstadoAlumnos();
        public DataTable MostrarReporteEstado(string IdCatalogo, DateTime FechaActual)
        {
            return data.MostrarReporteEstado(IdCatalogo, FechaActual);
        }
    }
}
