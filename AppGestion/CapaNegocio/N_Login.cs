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
    public class N_Login
    {
        D_Login data = new D_Login();
        E_Login entities = new E_Login();

        public string ObtenerNombreUsuario(string CodDocente)
        {
            return data.ObtenerNombreUsuario(CodDocente);
        }

        public DataTable ObtenerDatosUsuario(E_Login login)
        {
            return data.ObtenerDatosUsuario(login);
        }
    }
}
