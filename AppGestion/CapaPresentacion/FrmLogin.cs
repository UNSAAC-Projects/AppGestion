using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void tbUsuario_TextChange(object sender, EventArgs e)
        {
            if (tbContraseña.Text != "" && tbUsuario.Text != "") 
                btnIniciarSesion.Enabled = true;
            else btnIniciarSesion.Enabled = false;
        }

        private void tbContraseña_TextChange(object sender, EventArgs e)
        {
            if (tbContraseña.Text != "" && tbUsuario.Text != "")
                btnIniciarSesion.Enabled = true;
            else btnIniciarSesion.Enabled = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
