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
    public class N_ReporteEstadoDocentes
    {
        //D_ReporteEstadoAlumnos data = new D_ReporteEstadoAlumnos();
        D_ReporteEstadoDocentes data = new D_ReporteEstadoDocentes();

        public DataTable MostrarReporteEstado()
        {
            return data.MostrarReporteEstado();
        }
    }
}
