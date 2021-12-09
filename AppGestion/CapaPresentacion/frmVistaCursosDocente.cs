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
    public partial class frmVistaCursosDocente : Form
    {

        public frmVistaCursosDocente(string CodDocente)
        {
            InitializeComponent();
            MostrarCursosDocente(CodDocente);
        }
        public void MostrarCursosDocente(string codDocente)
        {
            N_CursosDocente ovista = new N_CursosDocente();
            dgvCursosDocente.DataSource = ovista.ListandoCursosDocente(codDocente);
        }

        private void btnMinCursosDocente_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnCloseCursosDocente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
