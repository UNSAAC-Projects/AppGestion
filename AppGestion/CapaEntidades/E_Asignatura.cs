using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Asignatura : E_Tabla
    {
        //==============ATRIBUTOS================
        //---   Todos heredados de cEntidad   ---

        //===============METODOS=================
        //-----------Constructores---------------
        //base: Se pasa como parametro el nombre de la tabla de la BD
        public E_Asignatura() : base("TAsignatura")
        {
        }
        //--Implementacion de metodos abstractos
        public override string[] NombresAtributos()
        {
            return new string[] { "CodAsignatura", "Nombre", "Creditos", "Categoria","Requisitos","NroSemestre"};
        }
    }
}
