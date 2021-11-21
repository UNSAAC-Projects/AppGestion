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
        FrmMain M = new FrmMain();
        DataTable dt = new DataTable();
        public FrmLogin()
        {
            InitializeComponent();
        }
        public bool logins(string usuario, string clave)
        {

            try
            {
                conexion.Open();
                //_usuario = txtusuario.Text;
                //_clave = txtcontraseña.Text;

                SqlCommand cmd = new SqlCommand("SELECT * from TLogin  WHERE Usuario= @Usuario AND Contraseña=@Contraseña ", conexion);

                cmd.Parameters.AddWithValue("Usuario", usuario);
                cmd.Parameters.AddWithValue("Contraseña", clave);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                // DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                   
                    MessageBox.Show("Login exitoso.");
                   
                    M.lblusuario.Text = dt.Rows[0][1].ToString();
                    M.lblcategoria.Text = dt.Rows[0][3].ToString();



                    conexion.Close();
                    return true;
                }
                else
                {
                    if (tbUsuario.Text == "" && tbContraseña.Text != "")
                    {
                        MessageBox.Show("Llenar el campo usuario");
                        
                    }
                    else if (tbUsuario.Text != "" && tbContraseña.Text == "")
                    {
                        MessageBox.Show("Llenar el campo contraseña");
                       
                    }
                    else if (tbUsuario.Text == "" && tbContraseña.Text == "")
                    {
                        MessageBox.Show("Llenar ambos campos");
                       
                    }
                    else
                    {
                        MessageBox.Show("Error Usuario i/o Contraseña");
                        tbUsuario.Text = "";
                        tbContraseña.Text = "";
                       
                    }
                    conexion.Close();
                    return false;
                }
                //return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;

            }
            //lblnombreusuario.Text = _usuario;


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
            string usuario = tbUsuario .Text;
            string clave = tbContraseña .Text;

            bool Inicio = logins(usuario, clave);
            if (Inicio)
            {

                this.Hide();
                M.Show();
            }
        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
