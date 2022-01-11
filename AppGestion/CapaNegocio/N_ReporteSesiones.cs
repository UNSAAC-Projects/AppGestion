using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class N_ReporteSesiones
    {
        D_ReporteSesiones data = new D_ReporteSesiones();

        public DataTable MostrarReporteSesiones(string IdCatalogo)
        {
            return data.MostrarReporteSesiones(IdCatalogo);
        }
    }
}
