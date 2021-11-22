using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Horario
    {
        private string _Dia;
        private string _HoraInicio;
        private string _HoraFin;
        private string _IdCatalogo;

        public E_Horario() 
        {
        }
        public E_Horario(string dia, string horaInicio, string horaFin, string idCatalogo) 
        {
            _Dia = dia;
            _HoraInicio = horaInicio;
            _HoraFin = horaFin;
            _IdCatalogo = idCatalogo;
        }
        public string Dia { get => _Dia; set => _Dia = value; }
        public string HoraInicio { get => _HoraInicio; set => _HoraInicio = value; }
        public string HoraFin { get => _HoraFin; set => _HoraFin = value; }
        public string IdCatalogo { get => _IdCatalogo; set => _IdCatalogo = value; }
    }
}
