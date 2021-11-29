using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaNegocio;
using CapaEntidades;


namespace CapaPresentacion
{
    public partial class frmAsignarDocente : Form
    {
        public frmAsignarDocente(string CodCursoCatalogo ) //Ex: IF345AIN
        {
            InitializeComponent();
            MostrarTablaHorario(CodCursoCatalogo);
        }

        private void MostrarTablaHorario(string CodCursoCatalogo)
        {
            // Modulo para mostrar el horario de un curso
            N_CursoCatalogo oCursoCatalogo = new N_CursoCatalogo();
            dgvHorarioCurso.DataSource = oCursoCatalogo.MostrarHorarioCurso(CodCursoCatalogo); //DA: director académico

        }


        #region Eventos
        private void pictureBoxCerrar_Click(object sender, EventArgs e) => Close();

        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            //Cambiar estado a minimizado
            WindowState = FormWindowState.Minimized;
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea cancelar?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) Close(); //Cerrar ventana
        }
        #endregion

        #region Procedure to drag form
        //Añadir using System.Runtime.InteropServices para usar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);
        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
