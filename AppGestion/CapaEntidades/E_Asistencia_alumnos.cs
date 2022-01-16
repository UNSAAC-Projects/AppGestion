using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Asistencia_alumnos
    {
        private DateTime _Fecha;
        private string _IdCatalogo;
        private string _CodAlumno;
        private string _Nombres;
        private string _Asistio;
        private string _Observacion;
        public E_Asistencia_alumnos()
        {

        }
        public E_Asistencia_alumnos(DateTime Fecha, string IdCatalogo,
            string CodAlumno, string Nombres, string Asistio, string Observacion)
        {
            _Fecha = Fecha;
            _IdCatalogo = IdCatalogo;
            _CodAlumno = CodAlumno;
            _Nombres = Nombres;
            _Asistio = Asistio;
            _Observacion = Observacion;
        }
        public DateTime fecha { get => _Fecha; set => _Fecha = value; }
        public string idcatalogo { get => _IdCatalogo; set => _IdCatalogo = value; }
        public string codalumno { get => _CodAlumno; set => _CodAlumno = value; }
        public string nombres { get => _Nombres; set => _Nombres = value; }
        public string asistio { get => _Asistio; set => _Asistio = value; }
        public string observacion { get => _Observacion; set => _Observacion = value; }
    }
}
