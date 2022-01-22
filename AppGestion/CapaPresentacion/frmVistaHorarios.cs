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
using System.Runtime.InteropServices;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class frmVistaHorarios : Form
    {
        public frmVistaHorarios()
        {
            InitializeComponent();
        }

        public void MostrarVistaCatalogo()
        {
            N_Horario ovista = new N_Horario();
            dgvHorarios.DataSource = ovista.ListandoHorarios();

        }
        public void OcultarMoverAncharColumnas()
        {
            dgvHorarios.Columns["CodAsignatura"].Width = 130;
            dgvHorarios.Columns["Nombre"].Width = 310;
            dgvHorarios.Columns["Grupo"].Width = 90;
            dgvHorarios.Columns["Dia"].Width = 90;
            dgvHorarios.Columns["HoraInicio"].Width = 100;
            dgvHorarios.Columns["HoraFin"].Width = 80;
            dgvHorarios.Columns["Tipo"].Width = 80;
        }

        private void btnMinVistaHorario_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaxVistaHorario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Procedure to drag form
        //Añadir using System.Runtime.InteropServices para usar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);
        private void panelVistaHorario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void dgvHorarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmVistaHorarios_Load(object sender, EventArgs e)
        {
            MostrarVistaCatalogo();
            OcultarMoverAncharColumnas();
        }
    }
}
