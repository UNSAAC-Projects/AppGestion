using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class N_Login
    {
        D_Login data = new D_Login();
        //E_Login entities = new E_Login();

        public string ObtenerNombreUsuario(string CodDocente)
        {
            return data.ObtenerNombreUsuario(CodDocente);
        }
    }
}
