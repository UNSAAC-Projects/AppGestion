using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_CursoCatalogo
    {
        private string _IdCatalogo;
        private string _NroSemestre;
        private string _CodAsignatura;
        private string _Grupo;
        //private string _IdPlan;
        private string _CodDocente;
        private string _Aula;
        private string search;
        public E_CursoCatalogo()
        {

        }
        public E_CursoCatalogo(string idCatalogo, string nroSemestre, string codAsignatura, 
            string grupo, string codDocente, string aula)
        {
            _IdCatalogo = idCatalogo;
            _NroSemestre = nroSemestre;
            _CodAsignatura = codAsignatura;
            _Grupo = grupo;
            _CodDocente = codDocente;
            _Aula = aula;
            
        }
        public string IdCatalogo { get => _IdCatalogo; set => _IdCatalogo = value; }
        public string NroSemestre { get => _NroSemestre; set => _NroSemestre = value; }
        public string CodAsignatura { get => _CodAsignatura; set => _CodAsignatura = value; }
        public string Grupo { get => _Grupo; set => _Grupo = value; }
        //public string IdPlan { get => _IdPlan; set => _IdPlan = value; }
        public string CodDocente { get => _CodDocente; set => _CodDocente = value; }
        public string Aula { get => _Aula; set => _Aula = value; }
        public string Search { get => search; set => search = value; }
    }
}
