using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_AsistenciaAlumno : E_Tabla
    {
        //==============ATRIBUTOS================
        //---   Todos heredados de E_Tabla   ---

        //===============METODOS=================
        //-----------Constructores---------------
        public E_AsistenciaAlumno() : base("TAsistenciaAlumno")
        {
        }
        //--Implementacion de metodos abstractos
        public override string[] NombresAtributos()
        {
            return new string[] { "Id", "IdAsistencia", "CodAsignatura", "CodAlumno", "MarcarAsistencia","Observacion" };
        }
    }
}
