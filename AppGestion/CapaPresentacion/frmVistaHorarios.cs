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
        }
        public void MostrarVistaCatalogo()
        {
            N_Horario ovista = new N_Horario();
            dgvHorarios.DataSource = ovista.ListandoHorarios();

        }
    }
}
