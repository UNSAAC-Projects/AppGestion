using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    class E_AsistenciaDocentes : E_Tabla
    {
        //==============ATRIBUTOS================
        //---   Todos heredados de cEntidad   ---

        //===============METODOS=================
        //-----------Constructores---------------
        public E_AsistenciaDocentes() : base("TAsistenciaDocentes")
        {
        }
        //--Implementacion de metodos abstractos
        public override string[] NombresAtributos()
        {
            return new string[] {"CodAsistenciaDocentes","CodDocente", "CodAsignatura",
                "Horario","Hora","Fecha","Dia"};
        }
    }
}
