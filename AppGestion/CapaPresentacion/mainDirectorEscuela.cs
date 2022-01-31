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
using CapaEntidades;


namespace CapaPresentacion
{
    public partial class mainDirectorEscuela : Form
    {
        N_Asignatura oAsignatura = new N_Asignatura();
        N_Login oLogin = new N_Login();

        private bool OpcionAsignaturas;
        private bool OpcionVerCatalogo;
        public mainDirectorEscuela(string CodDocente)
        {
            InitializeComponent();
            
            MostrarNombreUsuario(CodDocente);
        }
        //Pantalla completa
        public void PantallaOk()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        private void MostrarNombreUsuario(string CodDocente)
        {
            labelNombre.Text = oLogin.ObtenerNombreUsuario(CodDocente);
        }


        private void pictureMINIMIZE1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureCANCEL1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureMaxDirectorEscuela_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private Form formActivado = null;
        private void AbrirFormulariosEnPanelContenedor(Form FormHijo)
        {
            if (formActivado != null)
                formActivado.Close();
            formActivado = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.Dock = DockStyle.Fill;
            panelContenedor2.Controls.Add(FormHijo);
            panelContenedor2.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();

        }

        private void btnASIGNATURA_Click(object sender, EventArgs e)
        {
            AbrirFormulariosEnPanelContenedor(new FrmPrincipalDirectorEscuela());
            //
            OpcionAsignaturas = true;
            OpcionVerCatalogo = false;
           

            //Restaurar backcolors
            btnASIGNATURA.BackColor = Color.WhiteSmoke;
            btnVerCatalogos.BackColor = Color.FromArgb(33, 47, 60);

            //Restaurar forecolors
            btnASIGNATURA.ForeColor = Color.FromArgb(33, 47, 60);
            btnVerCatalogos.ForeColor = Color.FromArgb(212, 172, 13);


        }

        private void btnVerCatalogos_Click(object sender, EventArgs e)
        {
            AbrirFormulariosEnPanelContenedor(new frmVistaCatalogo());
            //
            OpcionAsignaturas = false;
            OpcionVerCatalogo = true;

            //Restaurar backcolors
            btnVerCatalogos.BackColor = Color.WhiteSmoke; ;
            btnASIGNATURA.BackColor = Color.FromArgb(33, 47, 60);

            //Restaurar forecolors
            btnVerCatalogos.ForeColor = Color.FromArgb(33, 47, 60);
            btnASIGNATURA.ForeColor = Color.FromArgb(212, 172, 13);
        }

        private void mainDirectorEscuela_Load(object sender, EventArgs e)
        {
            PantallaOk();
        }

        private void timerHoraFecha_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
            labelFecha.Text = DateTime.Now.ToString(" MMM dd yyyy");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de que quieres cerrar Sesion?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void PicBoxIndicador_Click(object sender, EventArgs e)
        {

        }

        private void btnMatriculados_Click(object sender, EventArgs e)
        {
            AbrirFormulariosEnPanelContenedor(new frmVistaCatalogo2());
            //
            OpcionAsignaturas = false;
            OpcionVerCatalogo = true;

            //Restaurar backcolors
            btnVerCatalogos.BackColor = Color.WhiteSmoke; ;
            btnASIGNATURA.BackColor = Color.FromArgb(33, 47, 60);

            //Restaurar forecolors
            btnVerCatalogos.ForeColor = Color.FromArgb(33, 47, 60);
            btnASIGNATURA.ForeColor = Color.FromArgb(212, 172, 13);
        }
    }
}
