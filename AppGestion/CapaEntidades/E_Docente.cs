using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CapaEntidades
{
    public class E_Docente
    {
        private string _IdDocente;
        private string _APaterno;
        private string _AMaterno;
        private string _Nombres;
        private string _Direccion;
        private string _TituloAcademico;
        private string _Estado;
        public E_Docente()
        {

        }
        public E_Docente(string idDocente, string apaterno, string amaterno, string nombres, string direccion, string tituloacademico, string estado)
        {

            _IdDocente = idDocente;
            _APaterno = apaterno;
            _AMaterno = amaterno;
            _Nombres = nombres;
            _Direccion = direccion;
            _TituloAcademico = tituloacademico;
            _Estado = estado;
        }
        public string IdDocente { get => _IdDocente; set => _IdDocente = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        


    }
}
