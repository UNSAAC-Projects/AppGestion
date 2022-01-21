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
        private string _SemestreLectivo;
        private string _NroSemestre;
        private string _CodAsignatura;
        private string _Grupo;
        private string _CodDocenteTeorico;
        private string _CodDocentePractico;
        private string _Aula;
        private string search;
        public E_CursoCatalogo()
        {

        }
        public E_CursoCatalogo(string idCatalogo,string semestreLectivo ,string nroSemestre, string codAsignatura, 
            string grupo, string codDocenteTeorico, string codDocentePractico, string aula)
        {
            _IdCatalogo = idCatalogo;
            _SemestreLectivo = semestreLectivo;
            _NroSemestre = nroSemestre;
            _CodAsignatura = codAsignatura;
            _Grupo = grupo;
            _CodDocenteTeorico = codDocenteTeorico;
            _CodDocentePractico = codDocentePractico;
            _Aula = aula;
            
        }
        public string IdCatalogo { get => _IdCatalogo; set => _IdCatalogo = value; }
        public string SemestreLectivo { get => _SemestreLectivo; set => _SemestreLectivo = value; }
        public string NroSemestre { get => _NroSemestre; set => _NroSemestre = value; }
        public string CodAsignatura { get => _CodAsignatura; set => _CodAsignatura = value; }
        public string Grupo { get => _Grupo; set => _Grupo = value; }
        public string CodDocenteTeorico { get => _CodDocenteTeorico; set => _CodDocenteTeorico = value; }
        public string CodDocentePractico { get => _CodDocentePractico; set => _CodDocentePractico = value; }
        public string Aula { get => _Aula; set => _Aula = value; }
        public string Search { get => search; set => search = value; }
    }
}
