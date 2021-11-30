using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmDocente : Form
    {
        N_Login oLogin = new N_Login();

        public frmDocente(string CodDocente)
        {
            InitializeComponent();
            MostrarNombreUsuario(CodDocente);
        }

        private void MostrarNombreUsuario(string codDocente)
        {
            labelNombre.Text = oLogin.ObtenerNombreUsuario(codDocente);
        }
    }
}
