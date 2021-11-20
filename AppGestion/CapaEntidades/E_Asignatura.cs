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
        private string _Nombre;
        private string _Creditos;
        private string _Categoria;
        private string _Requisito;
        private string _NroSemestre;

        private string buscar;
        public E_Asignatura()
        { }
        public E_Asignatura(string CodAsignatura, string Nombre, string Creditos,
            string Categoria, string Requisito, string NroSemestre)
        {
            _CodAsignatura = CodAsignatura;
            _Nombre = Nombre;
            _Creditos = Creditos;
            _Categoria = Categoria;
            _Requisito = Requisito;
            _NroSemestre = NroSemestre;
        }

        public string codAsigantura { get => _CodAsignatura; set => _CodAsignatura = value; }
        public string nombre { get => _Nombre; set => _Nombre = value; }
        public string creditos { get => _Creditos; set => _Creditos = value; }
        public string categoria { get => _Categoria; set => _Categoria = value; }
        public string requisito { get => _Requisito; set => _Requisito = value; }
        public string nroSemestre { get => _NroSemestre; set => _NroSemestre = value; }
        public string Buscar { get => buscar; set => buscar = value; }
    }
}

