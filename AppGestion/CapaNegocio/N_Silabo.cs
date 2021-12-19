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
    public class N_Silabo
    {
        D_Silabo data = new D_Silabo();
        public void SubirSilabo(string RutaPDF,string CodCatalogo)
        {
            data.SubirSilabo(RutaPDF,CodCatalogo);
        }
        public byte[] ObtenerBytesSilabo( string CodCatalogo)
        {
            
            return data.ObtenerBytesSilabo( CodCatalogo);
        }
    }
}
