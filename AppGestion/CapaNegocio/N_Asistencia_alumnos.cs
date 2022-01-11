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
    public class N_Asistencia_alumnos
    {
        D_Asistencia_alumnos data = new D_Asistencia_alumnos();
        public void InsertarAsistenciaAlumno(E_Asistencia_alumnos asistencia_alumno)
        {
            data.InsertarAsistenciaAlumno(asistencia_alumno);
        }
    }
}
