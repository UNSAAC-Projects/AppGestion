using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Runtime.InteropServices; //Para usar librerias nativas del sistema operativo (dll)(can drag form)
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        //Inicializando variables
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        DataTable tabla = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();
        N_Login oLogin = new N_Login();
        E_Login login = new E_Login();

        private bool OpcionDocente;
        private bool OpcionDirEscuela;
        //private bool OpcionDirDepartamento;

        public FrmLogin()
        {
            InitializeComponent();
        }

        #region Módulos
        bool VerificarLogin(string usuario, string contraseña, out string mensaje, out string codDocente)
        {
            //-- Verifica si se inició correctamente el login. Se guarda el mensaje en la variable "mensaje".

            try
            {              
                //-- Determinar tipo de usuario
                string categoria;
                if (OpcionDocente) categoria = "Docente";
                else if (OpcionDirEscuela) categoria = "DirectorEscuela";
                else categoria = "DirectorAcademico";
             
                login.Usuario = usuario;
                login.Contrasenia = contraseña;
                login.Categoria = categoria;

                tabla = oLogin.ObtenerDatosUsuario(login);
                //oLogin.ObtenerNombreUsuario();

                //-- Realizando consulta en la BD
                //conexion.Open();
                //string consulta = $@"
                //    SELECT * from TLogin  
	               // WHERE Usuario= '{usuario}' AND Contrasenia = '{contraseña}' and Categoria = '{categoria}'";

                //adapter.SelectCommand = new SqlCommand(consulta, conexion);
                //adapter.Fill(tabla); //Rellenando tabla

                //-- Verificando si usuario existe
                if (tabla.Rows.Count == 1)
                {
                    codDocente = tabla.Rows[0]["CodDocente"].ToString();
                    mensaje = "Sesión iniciada correctamente";
                    conexion.Close();
                    return true;
                }
                else
                {
                    codDocente = "";
                    mensaje = "Usuario y/o contraseña incorrecta, intente de nuevo";
                    conexion.Close();
                    return false;
                } 
            }
            catch (System.Exception e)
            {
                //mensaje = e.ToString();
                codDocente = "";
                mensaje = "Hubo un problema en conectar con la base de datos. Intente de nuevo.";
                return false;
            }
        }
        #endregion

        #region Eventos
        private void buttonDocente_Click(object sender, System.EventArgs e)
        {
            OpcionDocente = true;
            OpcionDirEscuela = false;
            //OpcionDirDepartamento = false;

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
            //OpcionDirDepartamento = false;

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
            //OpcionDirDepartamento = true;

            //Restaurar backcolors
            buttonDocente.BackColor = Color.FromArgb(33, 47, 60);
            buttonDirDep.BackColor = Color.White;
            buttonDirEscuela.BackColor = Color.FromArgb(33, 47, 60);

            //Restaurar forecolors
            buttonDocente.ForeColor = Color.White;
            buttonDirDep.ForeColor = Color.FromArgb(33, 47, 60);
            buttonDirEscuela.ForeColor = Color.White;
        }

        private void buttonCerrar_Click(object sender, System.EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea salir?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) Close(); //Cerrar ventana
        }

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

        private void textBoxContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonIniciarSesion.PerformClick();
            }
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

        private void buttonIniciarSesion_Click(object sender, System.EventArgs e)
        {
            string mensaje;
            string codDocente;
            //Verificar si datos del login son correctos
            if(VerificarLogin(textBoxUsuario.Text, textBoxContraseña.Text, out mensaje, out codDocente)) //Si inicio es correcto
            {
                MessageBox.Show(mensaje);

                //Dirigir a su formulario correspondiente
                if (OpcionDocente)
                {
                    Program.SwitchMainForm(new frmDocente(codDocente));
                }
                else if (OpcionDirEscuela)
                {
                    Program.SwitchMainForm(new mainDirectorEscuela(codDocente));
                }
                else //DirDepartamento
                {
                    Program.SwitchMainForm(new frmDirecDepAcade(codDocente));
                }
            }
            else
            {
                MessageBox.Show(mensaje);
                textBoxContraseña.Text = "";
                textBoxUsuario.Text = "";
            }
        }
        #endregion

        #region Procedure to drag form
        //Añadir using System.Runtime.InteropServices para usar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);
        private void pnlLateral_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pictureBoxLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
