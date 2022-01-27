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
    public class N_ReporteAsistencia
    {
        D_ReporteAsistecia data = new D_ReporteAsistecia();
        public DataTable ReporteAsistencia(string IdCatalogo, string FechaInicio, string FechaFin)
        {
            return data.ReporteAsistencia(IdCatalogo, FechaInicio, FechaFin);
        }

        public DataTable BuscarReporteAvance(string buscar)
        {
            return data.BuscarReporteAvanceDocente(buscar);
        }
        public DataTable ReporteAvanceDocente()
        {
            return data.ReporteAvacenDocenteDepartamento();
        }
        public string recuperarIdCat(string NombreAsig, string CodDocente, string Grupo)
        {
            return data.recuperarIdCat(NombreAsig, CodDocente,Grupo);
        }
    }
}
