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
    public class N_PlanSesiones
    {
        D_PlanSesiones data = new D_PlanSesiones();
        E_PlanSesiones entities = new E_PlanSesiones();
        public DataTable ListandoPlanSesiones(string CodCatalogo)
        {
            return data.ListarPlanSesiones(CodCatalogo);
        }
        public void CreandoPlanSesiones(E_PlanSesiones tema)
        {
            data.CrearPlanSesiones(tema);
        }
        public void EditandoPlanSesiones(E_Asignatura curso)
        {
            data.EditarPlanSesiones(curso);
        }
        public void EliminandoPlanSesiones(string id)
        {
            data.EliminarPlanSesiones(id);
        }

        public List<string> ObtenerTemasXUnidad(string IdCatalogo, string Unidad)
        {
            return data.ObtenerTemasXUnidad(IdCatalogo, Unidad);
        }

        public string[] SiguienteTema(string IdCatalogo)
        {
            return data.SiguienteTema(IdCatalogo);
        }
        public void GuardarPlanSesiones(DataTable tabla, string IDCatalogo)
        {
            data.GuardarPlanSesiones(tabla,IDCatalogo);
        }
    }
}
