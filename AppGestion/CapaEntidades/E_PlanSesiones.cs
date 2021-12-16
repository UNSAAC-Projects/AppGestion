using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaEntidades
{
    public class E_PlanSesiones
    {
        private string _Unidad;
        private string _Capitulo;
        private string _Tema;
        private string _HorasProgramadas;
        private DateTime _Fecha;

        private string buscar;
        public E_PlanSesiones()
        { }
        public E_PlanSesiones(string Unidad, string Capitulo, string Tema, string HorasProgramadas, DateTime Fecha)
        {
            _Unidad = Unidad;
            _Capitulo = Capitulo;
            _Tema = Tema;
            _HorasProgramadas = HorasProgramadas;
            _Fecha = Fecha;
        }

        public string Unidad { get => _Unidad; set => _Unidad = value; }
        public string Capitulo { get => _Capitulo; set => _Capitulo = value; }
        public string Tema { get => _Tema; set => _Tema = value; }
        public string HorasProgramadas { get => _HorasProgramadas; set => _HorasProgramadas = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public string Buscar { get => buscar; set => buscar = value; }
    }
}
