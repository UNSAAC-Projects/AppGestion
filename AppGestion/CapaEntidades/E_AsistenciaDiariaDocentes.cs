using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_AsistenciaDiariaDocentes
    {
        private DateTime _Fecha;
        private string _CodDocente;
        private string _Nombres;
        private string _Asistio;
        private string _Observacion;

        public E_AsistenciaDiariaDocentes()
        {

        }
        public E_AsistenciaDiariaDocentes(DateTime Fecha,
            string CodDocente, string Nombres, string Asistio, string Observacion)
        {
            _Fecha = Fecha;
            _CodDocente = CodDocente;
            _Nombres = Nombres;
            _Asistio = Asistio;
            _Observacion = Observacion;
        }
        public DateTime fecha { get => _Fecha; set => _Fecha = value; }
        public string coddocente { get => _CodDocente; set => _CodDocente = value; }
        public string nombres { get => _Nombres; set => _Nombres = value; }
        public string asistio { get => _Asistio; set => _Asistio = value; }
        public string observacion { get => _Observacion; set => _Observacion = value; }
    }
}