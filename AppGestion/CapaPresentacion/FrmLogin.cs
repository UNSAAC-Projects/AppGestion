using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void tbUsuario_TextChange(object sender, EventArgs e)
        {
            //Activar o desactivar boton de iniciar sesión
            if (tbContraseña.Text != "" && tbUsuario.Text != "") 
                btnIniciarSesion.Enabled = true;
            else btnIniciarSesion.Enabled = false;
        }

        private void tbContraseña_TextChange(object sender, EventArgs e)
        {
            //Activar o desactivar boton de iniciar sesión
            if (tbContraseña.Text != "" && tbUsuario.Text != "")
                btnIniciarSesion.Enabled = true;
            else btnIniciarSesion.Enabled = false;

            //Cambiar caracter a *
            if (tbContraseña.Text != "")
                tbContraseña.PasswordChar = '*';
            else tbContraseña.PasswordChar = '\0';

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuShadowPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

        }
    }
}
