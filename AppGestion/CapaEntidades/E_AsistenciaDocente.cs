using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_AsistenciaDocente : E_Tabla
    {
        //==============ATRIBUTOS================
        //---   Todos heredados de E_Tabla   ---

        //===============METODOS=================
        //-----------Constructores---------------
        public E_AsistenciaDocente() : base("TAsistenciaDocente")
        {
        }
        //--Implementacion de metodos abstractos
        public override string[] NombresAtributos()
        {
            return new string[] {"Id","IdAsistencia", "CodDocente", "MarcarAsistencia","Observacion"};
        }
    }
}
