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
    public class N_AsistenciaDiariaDocentes
    {
        D_AsistenciaDiariaDocentes data = new D_AsistenciaDiariaDocentes();
        public DataTable ListarDocentesActivos(string semestreLectivo, DateTime fecha)
        {
            return data.ListarDocentesActivos(semestreLectivo, fecha);
        }
    }
}
