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
    public class N_CursosDocente
    {
        D_CursosDocente data = new D_CursosDocente();
        //E_CursosDocente entities = new E_CursosDocente();
        public DataTable ListandoCursosDocente(string CodDocente)
        {
            return data.ListarCursosDocente(CodDocente);
        }
        public string ObtenerCodCatalogo(string GrupoAsignatura)
        {
            return data.ObtenerCodCatalogo(GrupoAsignatura);
        }
    }
}
