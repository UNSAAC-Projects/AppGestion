using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_ListaAsistencias
    {
        private string _Tema;
        private DateTime _Fecha;
        private string _IdCatalogo;
        public E_ListaAsistencias()
        {

        }
        public E_ListaAsistencias(string Tema, DateTime Fecha, string IdCatalogo)
        {
            _Tema = Tema;
            _Fecha = Fecha;
            _IdCatalogo = IdCatalogo;
        }
        public string tema { get => _Tema; set => _Tema = value; }
        public DateTime fecha { get => _Fecha; set => _Fecha = value;}
        public string idcatalogo { get => _IdCatalogo; set => _IdCatalogo = value; }
    }
}
