using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class N_Docente
    {
        D_Docente data = new D_Docente();
        E_Docente entities = new E_Docente();

        public string RecuperarCodDocente(string nombres, string apellidos)
        {
            return data.RecuperarCodDocente(nombres, apellidos);
        }

        public DataTable ListarDistribucionDocentes()
        {
            return data.ListarDistribucionDocentes();
        }

        public DataTable MostrarHorarioDocente(string CodDocente)
        {
            return data.MostrarHorarioDocente(CodDocente);
        }
    }
}
