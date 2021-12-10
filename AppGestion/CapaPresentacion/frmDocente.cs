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
    }
}
