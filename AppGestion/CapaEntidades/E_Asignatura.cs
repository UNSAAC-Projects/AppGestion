using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Asignatura
    {
        private string _CodAsignatura;
        private string _IdPlan;
        private string _Nombre;
        private string _Creditos;
        private string _Categoria;
        private string _HorasPracticas;
        private string _HorasTeoricas;
        private string _Prerrequisitos;

        private string buscar;
        public E_Asignatura()
        { }
        public E_Asignatura(string CodAsignatura, string IdPlan ,string Nombre, string Creditos,
            string Categoria, string HorasPracticas, string HorasTeoricas, string Prerrequisitos)
        {
            _CodAsignatura = CodAsignatura;
            _IdPlan = IdPlan;
            _Nombre = Nombre;
            _Creditos = Creditos;
            _Categoria = Categoria;
            _HorasPracticas = HorasPracticas;
            _HorasTeoricas = HorasTeoricas;
            _Prerrequisitos = Prerrequisitos;
        }

        public string codAsigantura { get => _CodAsignatura; set => _CodAsignatura = value; }
        public string idPlan { get => _IdPlan; set => _IdPlan = value; }
        public string nombre { get => _Nombre; set => _Nombre = value; }
        public string creditos { get => _Creditos; set => _Creditos = value; }
        public string categoria { get => _Categoria; set => _Categoria = value; }
        public string horasPracticas { get => _HorasPracticas; set => _HorasPracticas = value; }
        public string horasTeoricas { get => _HorasTeoricas; set => _HorasTeoricas = value; }
        public string prerrequisitos { get => _Prerrequisitos; set => _Prerrequisitos = value; }
        public string Buscar { get => buscar; set => buscar = value; }
    }
}

