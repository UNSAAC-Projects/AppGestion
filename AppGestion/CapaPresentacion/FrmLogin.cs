using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {

        private bool OpcionDocente;
        private bool OpcionDirEscuela;
        private bool OpcionDirDepartamento;

        public FrmLogin()
        {
            InitializeComponent();
        }


        #region Eventos
        private void buttonDocente_Click(object sender, System.EventArgs e)
        {
            OpcionDocente = true;
            OpcionDirEscuela = false;
            OpcionDirDepartamento = false;

            //Restaurar backcolors
            buttonDocente.BackColor = Color.White;       
            buttonDirDep.BackColor = Color.FromArgb(33, 47, 60);
            buttonDirEscuela.BackColor = Color.FromArgb(33, 47, 60);

            //Restaurar forecolors
            buttonDocente.ForeColor = Color.FromArgb(33, 47, 60);
            buttonDirDep.ForeColor = Color.White;
            buttonDirEscuela.ForeColor = Color.White;
        }

        private void buttonDirEscuela_Click(object sender, System.EventArgs e)
        {
            OpcionDocente = false;
            OpcionDirEscuela = true;
            OpcionDirDepartamento = false;

            //Restaurar backcolors
            buttonDocente.BackColor = Color.FromArgb(33, 47, 60);
            buttonDirDep.BackColor = Color.FromArgb(33, 47, 60);
            buttonDirEscuela.BackColor = Color.White;

            //Restaurar forecolors
            buttonDocente.ForeColor = Color.White;
            buttonDirDep.ForeColor = Color.White;
            buttonDirEscuela.ForeColor = Color.FromArgb(33, 47, 60);
        }

        private void buttonDirDep_Click(object sender, System.EventArgs e)
        {
            OpcionDocente = false;
            OpcionDirEscuela = false;
            OpcionDirDepartamento = true;

            //Restaurar backcolors
            buttonDocente.BackColor = Color.FromArgb(33, 47, 60);
            buttonDirDep.BackColor = Color.White;
            buttonDirEscuela.BackColor = Color.FromArgb(33, 47, 60);

            //Restaurar forecolors
            buttonDocente.ForeColor = Color.White;
            buttonDirDep.ForeColor = Color.FromArgb(33, 47, 60);
            buttonDirEscuela.ForeColor = Color.White;
        }

        private void buttonCerrar_Click(object sender, System.EventArgs e) => Close();

        private void buttonIniciarSesion_EnabledChanged(object sender, System.EventArgs e)
        {
            if (buttonIniciarSesion.Enabled == true) //Si el boton está activado
                buttonIniciarSesion.BackColor = Color.FromArgb(33, 47, 60);
            else //Si el boton está desactivado
                buttonIniciarSesion.BackColor = Color.Silver;
        }

        private void textBoxUsuario_TextChanged(object sender, System.EventArgs e)
        {
            //Activar o desactivar boton de iniciar sesión
            if (textBoxUsuario.Text != "" && textBoxContraseña.Text != "")
                buttonIniciarSesion.Enabled = true;
            else buttonIniciarSesion.Enabled = false;
        }

        private void textBoxContraseña_TextChanged(object sender, System.EventArgs e)
        {
            //Activar o desactivar boton de iniciar sesión
            if (textBoxContraseña.Text != "" && textBoxUsuario.Text != "")
                buttonIniciarSesion.Enabled = true;
            else buttonIniciarSesion.Enabled = false;
        }

        private void FrmLogin_Load(object sender, System.EventArgs e)
        {
            //Inicializando boton
            OpcionDocente = true;
            buttonDocente.BackColor = Color.White;
            buttonDocente.ForeColor = Color.FromArgb(33, 47, 60);

            //Inicializando boton inicio sesion
            buttonIniciarSesion.Enabled = false;
            buttonIniciarSesion.BackColor = Color.Silver;
        }

        #endregion

        private void buttonIniciarSesion_Click(object sender, System.EventArgs e)
        {

        }

        private void panelLinea_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
