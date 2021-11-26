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
    public partial class frmVistaHorarios : Form
    {
        public frmVistaHorarios()
        {
            InitializeComponent();
            MostrarVistaCatalogo();
            //OcultarMoverAncharColumnas();
        }
        
        public void MostrarVistaCatalogo()
        {
            N_Horario ovista = new N_Horario();
            dgvHorarios.DataSource = ovista.ListandoHorarios();

        }

        private void btnMinVistaHorario_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaxVistaHorario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
