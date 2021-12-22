using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Asistencia
    {
        private string _Curso;
        private string _Tema;
        private string _Fecha;
        private string _Asistencia;
        private string _IdCatalogo;
        public E_Asistencia()
        {

        }
        public E_Asistencia(string Curso, string Tema, string Fecha, string Asistencia, string IdCatalogo)
        {
            _Curso = Curso;
            _Tema = Tema;
            _Fecha = Fecha;
            _Asistencia = Asistencia;
            _IdCatalogo = IdCatalogo;
        }
        public string curso { get => _Curso; set => _Curso= value; }
        public string tema { get => _Tema; set => _Tema = value; }
        public string fecha { get => _Fecha; set => _Fecha = value;}
        public string asistencia { get => _Asistencia; set => _Asistencia = value; }
        public string idcatalogo { get => _IdCatalogo; set => _IdCatalogo = value; }
    }
}
