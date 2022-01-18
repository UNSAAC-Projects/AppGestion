using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel;
using System.IO;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmDocente : Form
    {
        DataSet result;
        N_Login oLogin = new N_Login();
        N_Docente oDocente = new N_Docente();
        N_PlanSesiones oPlanSesiones = new N_PlanSesiones();
        DataTable tabla;
        public string Docente;

        public frmDocente(string CodDocente)
        {
            InitializeComponent();
            datos.CodDocente = CodDocente;
            Docente = CodDocente;
        }

        public void PantallaOk()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }


        private void MostrarNombreUsuario(string codDocente)
        {
            labelNombre.Text = oLogin.ObtenerNombreUsuario(codDocente); //Obtener nombre del usuario
            datos.NombreDocente = labelNombre.Text;
        }
      
        private void btnVerCursosDocente_Click(object sender, EventArgs e)
        {
            AbrirFormulariosEnPanelContenedor(new frmVistaCursosDocente(Docente));
        }

        private void btnMINIMIZAR_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnMaxFrmDocente_Click(object sender, EventArgs e)
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

        //Movimiento panel
        int posY = 0;
        int posX = 0;
        private void pnlFrmDocente_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void btnReporteCursos_Click(object sender, EventArgs e)
        {
            AbrirFormulariosEnPanelContenedor(new frmListaAsistencias());
        }

        private void frmDocente_Load(object sender, EventArgs e)
        {
            PantallaOk();
            //Mostrar nombre de usuario
            MostrarNombreUsuario(Docente);
            AbrirFormulariosEnPanelContenedor(new FrmPrincipalDocente(Docente));

        }

        private void btnREPORTEASISTENCIA_Click(object sender, EventArgs e)
        {
            ReporteAsistenciasAlumnos RAsistencia = new ReporteAsistenciasAlumnos();
            RAsistencia.CodDocente = datos.CodDocente;
            AbrirFormulariosEnPanelContenedor(RAsistencia);

            /*ReporteAsistenciasAlumnos RAsistencia = new ReporteAsistenciasAlumnos();
            RAsistencia.CodDocente = datos.CodDocente;
            RAsistencia.ShowDialog();*/
        }

        private void buttonReporteSesiones_Click(object sender, EventArgs e)
        {
            AbrirFormulariosEnPanelContenedor(new frmReporteSesiones(Docente));
        }
        private Form formActivado = null;
        private void AbrirFormulariosEnPanelContenedor(Form FormHijo)
        {
            if (formActivado != null)
                formActivado.Close();
            formActivado = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(FormHijo);
            panelContenedor.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
        }
        //
        private void btnCursosPorDia_Click(object sender, EventArgs e)
        {
            AbrirFormulariosEnPanelContenedor(new FrmPrincipalDocente(Docente));
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flecha_Click(object sender, EventArgs e)
        {

        }

        private void labelHora_Click(object sender, EventArgs e)
        {

        }
        // mostrarhora y fecha

        private void timerHoraFecha_Tick_1(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
            labelFecha.Text = DateTime.Now.ToString(" MMM dd yyyy");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelFecha_Click(object sender, EventArgs e)
        {

        }
    }
}
