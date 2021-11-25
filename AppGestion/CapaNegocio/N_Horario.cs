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
    public class N_Horario
    {
        D_Horario data = new D_Horario();
        E_Horario entities = new E_Horario();
        
        public void CreandoHorario(E_Horario horario)
        {
            data.CrearHorario(horario);
        }
        public DataTable ListandoHorarios()
        {
            return data.ListarHorario();
        }
    }
}
