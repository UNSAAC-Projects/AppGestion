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

        private void MostrarTemasDictar()
        {
            string codAsignatura, codCatalogo;
            string tema;
            //Obtener cod catalogo
            foreach (DataGridViewRow row in dgvCursosDocente.Rows)
            {
                codAsignatura = row.Cells["CODIGO"].Value.ToString();
                codCatalogo = oDocente.ObtenerCodCatalogo(codAsignatura);
                //arrayTema = oPlanSesiones.SiguienteTema(codCatalogo);
                //tema = $"{arrayTema[2]} - {arrayTema[3]}";
                tema = oPlanSesiones.SiguienteTema(codCatalogo);

                row.Cells["TEMA"].Value = tema;
            }
        }

        private void MostrarNombreUsuario(string codDocente)
        {
            labelNombre.Text = oLogin.ObtenerNombreUsuario(codDocente); //Obtener nombre del usuario
            datos.NombreDocente = labelNombre.Text;
        }
      
        private void btnVerCursosDocente_Click(object sender, EventArgs e)
        {
            frmVistaCursosDocente frm = new frmVistaCursosDocente(Docente);
            frm.ShowDialog();
            //Actualizar tabla docentes
            MostrarHorarioxDia(Docente);
        }

        private void btnMINIMIZAR_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void MostrarHorarioxDia(string codDocente)
        {
            //Obtener día
            ObtenerTiempo(out _, out _, out string dia);
            dia = "MARTES";

            //Mostrar tabla
            // Obtener tabla de horarios del dia actual
            var table = oDocente.MostrarHorarioDocenteDia(codDocente, dia);
            //Verificar si la tabla no está vacio
            if (table != null && table.Rows.Count > 0)
            {
                dgvCursosDocente.DataSource = table; //Mostrar tabla
                MoverModificarColumnas(); //Modificar columnas
                MostrarTemasDictar();  //Mostrar temas a dictar de cada curso

            }
            else //Si está vacio
            {
                //Mostrar mensaje
                dgvCursosDocente.Visible = false; //Ocultar datagridview
                labelMensaje.Visible = true; //Mostrar label
                pictureBoxLibros.Visible = true; // Mostrar imagen
            }
        }

        private void MoverModificarColumnas()
        {
            //Mostrar encabezado
            dgvCursosDocente.ColumnHeadersVisible = true; // Mostrar encabezado
            //dgvCatalogo.ColumnHeadersVisible = true;

            // Mover columnas 
            dgvCursosDocente.Columns["TEMA"].DisplayIndex = 7;
            dgvCursosDocente.Columns["ASISTENCIA"].DisplayIndex = 7;

            //Modificar ancho de columnas
            //dgvCursosDocente.Columns["CODIGO"].Width = 70;
            //dgvCursosDocente.Columns["NOMBRE"].Width = 340;
            //dgvCursosDocente.Columns["TIPO"].Width = 50;
            //dgvCursosDocente.Columns["GRUPO"].Width = 60;
            //dgvCursosDocente.Columns["HORAS"].Width = 70;
            //dgvCursosDocente.Columns["AULA"].Width = 60;
            //dgvCursosDocente.Columns["TEMA"].Width = 300;
            //dgvCursosDocente.Columns["ASISTENCIA"].Width = 80;
        }

        public void ObtenerTiempo(out string fecha, out string hora, out string dia)
        {
            fecha = DateTime.Now.ToString("dd/MM/yyyy");
            hora = DateTime.Now.ToString("HH:mm:ss tt");
            dia = "";
            int nroDia = (int)DateTime.Now.DayOfWeek;
            switch (nroDia)
            {
                case 0: dia = "DOMINGO"; break;
                case 1: dia = "LUNES"; break;
                case 2: dia = "MARTES"; break;
                case 3: dia = "MIERCOLES"; break;
                case 4: dia = "JUEVES"; break;
                case 5: dia = "VIERNES"; break;
                case 6: dia = "SABADO"; break;
            }
        }

        private void dgvCursosDocente_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) //Si no se hizo click en el encabezado
            {
                DataGridViewRow row = dgvCursosDocente.Rows[e.RowIndex];
                if (row.Cells["ASISTENCIA"].Selected)
                {
                    N_CursoCatalogo oCursoCatalogo = new N_CursoCatalogo();
                    //Obtener cod curso y luego codcatalogo
                    string codAsignatura = row.Cells["CODIGO"].Value.ToString();
                    string NombreCurso = row.Cells["NOMBRE"].Value.ToString();
                    string Grupo = row.Cells["GRUPO"].Value.ToString();
                    string codCatalogo = oDocente.ObtenerCodCatalogo(codAsignatura);
                    // hasta aqui esta bien 

                    frmAsistencia frm = new frmAsistencia(codCatalogo, $"{NombreCurso} - GRUPO {Grupo}");
                    frm.CodAsignatura = codAsignatura;
                    frm.ShowDialog();
                }
            }
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
            FrmReporteAsistencia RAsistencia = new FrmReporteAsistencia();
            RAsistencia.ShowDialog();
            //dgvCursosDocente.Refresh();
        }

        private void frmDocente_Load(object sender, EventArgs e)
        {
            //Mostrar nombre de usuario
            MostrarNombreUsuario(Docente);
            //Mostrar horario del docente o mensaje si no tiene ningun curso
            MostrarHorarioxDia(Docente);
        }

        private void btnREPORTEASISTENCIA_Click(object sender, EventArgs e)
        {
            
            ReporteAsistenciasAlumnos RAsistencia = new ReporteAsistenciasAlumnos();
            RAsistencia.CodDocente = datos.CodDocente;
            RAsistencia.ShowDialog();
        }
    }
}
