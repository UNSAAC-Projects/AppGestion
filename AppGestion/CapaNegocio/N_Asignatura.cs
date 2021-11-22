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
    public class N_Asignatura
    {
        D_Asignatura data = new D_Asignatura();
        E_Asignatura entities = new E_Asignatura();
        public DataTable ListandoAsignaturas()
        {
            return data.ListarAsignaturas();
        }
        public DataTable BuscandoAsignatura(string search)
        {
            entities.Buscar = search;
            return data.BuscarAsignatura(entities);
        }
        public void CreandoAsignatura(E_Asignatura curso)
        {
            data.CrearAsignatura(curso);
        }
        public void EditandoAsignatura(E_Asignatura curso)
        {
            data.EditarAsignatura(curso);
        }
        public void EliminandoAsignatura(string id)
        {
            data.EliminarAsignatura(id);
        }
    }
}
