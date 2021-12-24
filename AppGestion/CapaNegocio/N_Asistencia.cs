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
    public class N_Asistencia
    {
        cAsistencia data = new cAsistencia();
        public void CreandoCurso_Asistencia(E_Asistencia curso)
        {
            data.CrearAsistencia(curso);
        }
        public DataTable ListandoAsistencias()
        {
            return data.ListarAsistencias();
        }
        public DataTable listarAsitenciaCurso(string curso)
        {
            return data.ListarAsistenciaCurso(curso);
        }
    }
}
