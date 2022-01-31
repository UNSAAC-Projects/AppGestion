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
        //DataSet result;
        N_Login oLogin = new N_Login();
        N_Docente oDocente = new N_Docente();
        N_PlanSesiones oPlanSesiones = new N_PlanSesiones();
        //DataTable tabla;
        public string Docente;

        private bool OpcionCursosPorDia;
        private bool OpcionVerCursosDocente;
        private bool OpcionReporteCursos;
        private bool OpcionREPORTEASISTENCIA;
        private bool OpcionReporteSesiones;


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
            //
            OpcionCursosPorDia = false;
            OpcionVerCursosDocente = true;
            OpcionReporteCursos = false;
            OpcionREPORTEASISTENCIA = false;
            OpcionReporteSesiones = false;


            //Restaurar backcolors
            btnCursosPorDia.BackColor = Color.FromArgb(33, 47, 60);
            btnVerCursosDocente.BackColor = Color.WhiteSmoke;
            btnReporteCursos.BackColor = Color.FromArgb(33, 47, 60);
            btnREPORTEASISTENCIA.BackColor = Color.FromArgb(33, 47, 60);
            buttonReporteSesiones.BackColor = Color.FromArgb(33, 47, 60);

            //Restaurar forecolors
            btnCursosPorDia.ForeColor = Color.FromArgb(212, 172, 13);
            btnVerCursosDocente.ForeColor = Color.FromArgb(33, 47, 60);
            btnReporteCursos.ForeColor = Color.FromArgb(212, 172, 13);
            btnREPORTEASISTENCIA.ForeColor = Color.FromArgb(212, 172, 13);
            buttonReporteSesiones.ForeColor = Color.FromArgb(212, 172, 13);
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
            //
            OpcionCursosPorDia = false;
            OpcionVerCursosDocente = false;
            OpcionReporteCursos = true;
            OpcionREPORTEASISTENCIA = false;
            OpcionReporteSesiones = false;

            //Restaurar backcolors
            btnCursosPorDia.BackColor = Color.FromArgb(33, 47, 60);
            btnVerCursosDocente.BackColor = Color.FromArgb(33, 47, 60);
            btnReporteCursos.BackColor = Color.WhiteSmoke;
            btnREPORTEASISTENCIA.BackColor = Color.FromArgb(33, 47, 60);
            buttonReporteSesiones.BackColor = Color.FromArgb(33, 47, 60);

            //Restaurar forecolors
            btnCursosPorDia.ForeColor = Color.FromArgb(212, 172, 13);
            btnVerCursosDocente.ForeColor = Color.FromArgb(212, 172, 13);
            btnReporteCursos.ForeColor = Color.FromArgb(33, 47, 60);
            btnREPORTEASISTENCIA.ForeColor = Color.FromArgb(212, 172, 13);
            buttonReporteSesiones.ForeColor = Color.FromArgb(212, 172, 13);
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
            frmReporteAsistenciasAlumnos RAsistencia = new frmReporteAsistenciasAlumnos();
            RAsistencia.CodDocente = datos.CodDocente;
            AbrirFormulariosEnPanelContenedor(RAsistencia);

            /*ReporteAsistenciasAlumnos RAsistencia = new ReporteAsistenciasAlumnos();
            RAsistencia.CodDocente = datos.CodDocente;
            RAsistencia.ShowDialog();*/

            //
            OpcionCursosPorDia = false;
            OpcionVerCursosDocente = false;
            OpcionReporteCursos = false;
            OpcionREPORTEASISTENCIA = true;
            OpcionReporteSesiones = false;


            //Restaurar backcolors
            btnCursosPorDia.BackColor = Color.FromArgb(33, 47, 60);
            btnVerCursosDocente.BackColor = Color.FromArgb(33, 47, 60);
            btnReporteCursos.BackColor = Color.FromArgb(33, 47, 60);
            btnREPORTEASISTENCIA.BackColor = Color.WhiteSmoke;
            buttonReporteSesiones.BackColor = Color.FromArgb(33, 47, 60);

            //Restaurar forecolors
            btnCursosPorDia.ForeColor = Color.FromArgb(212, 172, 13);
            btnVerCursosDocente.ForeColor = Color.FromArgb(212, 172, 13);
            btnReporteCursos.ForeColor = Color.FromArgb(212, 172, 13);
            btnREPORTEASISTENCIA.ForeColor = Color.FromArgb(33, 47, 60);
            buttonReporteSesiones.ForeColor = Color.FromArgb(212, 172, 13);
        }

        private void buttonReporteSesiones_Click(object sender, EventArgs e)
        {
            AbrirFormulariosEnPanelContenedor(new frmReporteSesiones(Docente));
            //
            OpcionCursosPorDia = false;
            OpcionVerCursosDocente = false;
            OpcionReporteCursos = false;
            OpcionREPORTEASISTENCIA = false;
            OpcionReporteSesiones = true;


            //Restaurar backcolors
            btnCursosPorDia.BackColor = Color.FromArgb(33, 47, 60);
            btnVerCursosDocente.BackColor = Color.FromArgb(33, 47, 60);
            btnReporteCursos.BackColor = Color.FromArgb(33, 47, 60);
            btnREPORTEASISTENCIA.BackColor = Color.FromArgb(33, 47, 60);
            buttonReporteSesiones.BackColor = Color.WhiteSmoke;

            //Restaurar forecolors
            btnCursosPorDia.ForeColor = Color.FromArgb(212, 172, 13);
            btnVerCursosDocente.ForeColor = Color.FromArgb(212, 172, 13);
            btnReporteCursos.ForeColor = Color.FromArgb(212, 172, 13);
            btnREPORTEASISTENCIA.ForeColor = Color.FromArgb(212, 172, 13);
            buttonReporteSesiones.ForeColor = Color.FromArgb(33, 47, 60);
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
            //
            OpcionCursosPorDia = true;
            OpcionVerCursosDocente = false;
            OpcionReporteCursos = false;
            OpcionREPORTEASISTENCIA = false;
            OpcionReporteSesiones = false;

            //Restaurar backcolors
            btnCursosPorDia.BackColor = Color.WhiteSmoke;
            btnVerCursosDocente.BackColor = Color.FromArgb(33, 47, 60);
            btnReporteCursos.BackColor = Color.FromArgb(33, 47, 60);
            btnREPORTEASISTENCIA.BackColor = Color.FromArgb(33, 47, 60);
            buttonReporteSesiones.BackColor = Color.FromArgb(33, 47, 60);

            //Restaurar forecolors
            btnCursosPorDia.ForeColor = Color.FromArgb(33, 47, 60);
            btnVerCursosDocente.ForeColor = Color.FromArgb(212, 172, 13);
            btnReporteCursos.ForeColor = Color.FromArgb(212, 172, 13);
            btnREPORTEASISTENCIA.ForeColor = Color.FromArgb(212, 172, 13);
            buttonReporteSesiones.ForeColor = Color.FromArgb(212, 172, 13);
        }

        // mostrarhora y fecha
        private void timerHoraFecha_Tick_1(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
            labelFecha.Text = DateTime.Now.ToString(" MMM dd yyyy");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de que quieres cerrar Sesion?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

       

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    FrmReporteAvanceDocente D = new FrmReporteAvanceDocente();
        //    D.ShowDialog();
        //}

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    FrmReporteAvanceDocente D = new FrmReporteAvanceDocente();
        //    D.Show();
        //}
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    FrmReporteAvanceDocente D = new FrmReporteAvanceDocente();
        //    D.ShowDialog();
        //}

        private void btnReporteAvanceDocentes_Click(object sender, EventArgs e)
        {
            AbrirFormulariosEnPanelContenedor(new FrmReporteAvanceDocente());
        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnAlumnosMatriculados_Click(object sender, EventArgs e)
        {
            AbrirFormulariosEnPanelContenedor(new frmAlumnosMatriculados());
            //
            OpcionCursosPorDia = false;
            OpcionVerCursosDocente = false;
            OpcionReporteCursos = true;
            OpcionREPORTEASISTENCIA = false;
            OpcionReporteSesiones = false;

            //Restaurar backcolors
            btnCursosPorDia.BackColor = Color.FromArgb(33, 47, 60);
            btnVerCursosDocente.BackColor = Color.FromArgb(33, 47, 60);
            btnReporteCursos.BackColor = Color.WhiteSmoke;
            btnREPORTEASISTENCIA.BackColor = Color.FromArgb(33, 47, 60);
            buttonReporteSesiones.BackColor = Color.FromArgb(33, 47, 60);

            //Restaurar forecolors
            btnCursosPorDia.ForeColor = Color.FromArgb(212, 172, 13);
            btnVerCursosDocente.ForeColor = Color.FromArgb(212, 172, 13);
            btnReporteCursos.ForeColor = Color.FromArgb(33, 47, 60);
            btnREPORTEASISTENCIA.ForeColor = Color.FromArgb(212, 172, 13);
            buttonReporteSesiones.ForeColor = Color.FromArgb(212, 172, 13);
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReporteEstadoAlumnos_Click(object sender, EventArgs e)
        {
            AbrirFormulariosEnPanelContenedor(new frmReporteEstadoAlumnos(Docente));
        }
    }
}
