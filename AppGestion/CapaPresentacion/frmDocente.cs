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
        public string codDocente;

        public frmDocente(string CodDocente)
        {
            InitializeComponent();
            MostrarTablaCatalogo(codDocente);
            codDocente = CodDocente;
            MostrarNombreUsuario(CodDocente);
        }

        private void MostrarNombreUsuario(string codDocente)
        {
            labelNombre.Text = oLogin.ObtenerNombreUsuario(codDocente);
        }

        private void btnVerCursosDocente_Click(object sender, EventArgs e)
        {
            frmVistaCursosDocente frm = new frmVistaCursosDocente(codDocente); 
            frm.ShowDialog();
        }

        private void btnMINIMIZAR_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ContenedorLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MostrarTablaCatalogo(string codDocente)
        {
            //Obtener día
            ObtenerTiempo(out _, out _, out string dia);
            //Mostrar tabla
            N_Docente oDocente = new N_Docente();
            dgvCursosDocente.DataSource = oDocente.MostrarHorarioDocenteDia(codDocente, dia);
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

        //private void buttonGetDate_Click(object sender, EventArgs e)
        //{
        //    string fecha, hora, dia;
        //    ObtenerTiempo(out fecha, out hora, out dia);
        //    MessageBox.Show($"Dia: {fecha}\nHora: {hora}\nDia: {dia}");
        //}

        private void dgvCursosDocente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvCursosDocente.Rows[e.RowIndex];
            if (row.Cells["ASISTENCIA"].Selected)
            {
                //Obtener cod curso
                string CodCursoCatalogo = row.Cells["CODIGO"].Value.ToString();

                frmAsistencia form = new frmAsistencia();
                //Recuperar información de la tabla
                //form.textBoxCodigo.Text = CodCursoCatalogo;
                //form.textBoxCurso.Text = row.Cells["CURSO"].Value.ToString();
                form.ShowDialog();
            }
        }
    }
}
