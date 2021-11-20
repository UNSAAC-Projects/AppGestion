using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_CursoCatalogo
    {
        private string _CodAsignaturaGrupo;
        private string _CodAsignatura;
        private string _Dia;
        private string _HorasTeoricas;
        private string _HorasPracticas;
        private string _HoraInicio;
        private string _HoraFin;
        private string _Grupo;
        private string _Aula;
        private string search;
        public E_CursoCatalogo()
        {

        }
        public E_CursoCatalogo(string codAsignaturaGrupo, string codAsignatura, string dia, string horasTeoricas,
            string horasPracticas, string horaInicio, string horaFin, string grupo, string aula)
        {
            _CodAsignaturaGrupo = codAsignaturaGrupo;
            _CodAsignatura = codAsignatura;
            _Dia = dia;
            _HorasTeoricas = horasTeoricas;
            _HorasPracticas = horasPracticas;
            _HoraInicio = horaInicio;
            _HoraFin = horaFin;
            _Grupo = grupo;
            _Aula = aula;
        }
        public string CodAsignaturaGrupo { get => _CodAsignaturaGrupo; set => _CodAsignatura = value; }
        public string CodAsignatura { get => _CodAsignatura; set => _CodAsignatura = value; }
        public string Dia { get => _Dia; set => _Dia = value; }
        public string HorasTeoricas { get => _HorasTeoricas; set => _HorasTeoricas = value; }
        public string HorasPracticas { get => _HorasPracticas; set => _HorasPracticas = value; }
        public string HoraInicio { get => _HoraInicio; set => _HoraInicio = value; }
        public string HoraFin { get => _HoraFin; set => _HoraFin = value; }
        public string Grupo { get => _Grupo; set => _Grupo = value; }
        public string Aula { get => _Aula; set => _Aula = value; }
        public string Search { get => search; set => search = value; }
    }
}
