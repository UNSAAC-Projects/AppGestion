using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Login
    {
        private string _Usuario;
        private string _Contrasenia;
        private string _Categoria;
        private string _CodDocente;

        public E_Login()
        {

        }

        public E_Login(string usuario, string contrasenia, string categoria, string codDocente)
        {
            _Usuario     = usuario;
            _Contrasenia = contrasenia;
            _Categoria  = categoria;
            _CodDocente = codDocente;
        }

        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Contrasenia { get => _Contrasenia; set => _Contrasenia = value; }
        public string Categoria{ get => _Categoria; set =>  _Categoria= value; }
        public string CodDocente{ get => _CodDocente; set => _CodDocente = value; }

    }
}
