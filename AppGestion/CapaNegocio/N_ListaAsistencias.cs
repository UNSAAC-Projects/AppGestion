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
    public class N_ListaAsistencias
    {
        D_ListaAsistencias data = new D_ListaAsistencias();
        public DataTable ListarAsitenciaCurso(string idCatalogo)
        {
            return data.ListarAsistenciaCurso(idCatalogo);
        }

        public void GuardarDatosAsistencia(E_ListaAsistencias eListaAsistencias)
        {
            data.GuardarDatosAsistencia(eListaAsistencias);
        }
    }
}
