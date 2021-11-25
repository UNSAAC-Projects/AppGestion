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
    public class N_CursoCatalogo
    {
        
        D_CursoCatalogo data = new D_CursoCatalogo();
        E_CursoCatalogo entities = new E_CursoCatalogo();
        
        public DataTable ListandoCursoCatalogo()
        {
            return data.ListarCursosCatalogo();
        }
        public DataTable ListandoVistaCatalogo()
        {
            return data.ListarVistaCatalogo();
        }
        public DataTable BuscandoCursoCatalogo(string search)
        {
            entities.Search = search;
            return data.BuscarCursoCatalogo(entities);
        }
        public void CreandoCursoCatalogo(E_CursoCatalogo curso)
        {
            data.CrearCursoCatalogo(curso);
        }
        public void EditandoCursoCatalogo(E_CursoCatalogo curso)
        {
            data.EditarCursoCatalogo(curso);
        }
        public void EliminandoCursoCatalogo(string id)
        {
            data.EliminarCursoCatalogo(id);
        }

    }
}
