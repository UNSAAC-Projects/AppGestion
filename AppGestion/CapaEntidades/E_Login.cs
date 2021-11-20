using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Login: E_Tabla
    {
        //==============ATRIBUTOS================
        //---   Todos heredados de cEntidad   ---

        //===============METODOS=================
        //-----------Constructores---------------
        //base: Se pasa como parametro el nombre de la tabla de la BD
        public E_Login() : base("TLogin")
        {
        }
        //--Implementacion de metodos abstractos
        public override string[] NombresAtributos()
        {
            return new string[] {"Usuario","Contraseña", "CodDocente","Categoria"};
        }
    }
}
