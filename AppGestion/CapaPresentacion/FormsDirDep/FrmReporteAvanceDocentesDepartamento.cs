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

namespace CapaPresentacion.FormsDirDep
{
    public partial class FrmReporteAvanceDocentesDepartamento : Form
    {
        public FrmReporteAvanceDocentesDepartamento()
        {
            InitializeComponent();
        }
        readonly N_ReporteAsistencia oDocentes = new N_ReporteAsistencia();
        private void FrmReporteAvanceDocentesDepartamento_Load(object sender, EventArgs e)
        {
            dgvAvanceDocentes.DataSource = oDocentes.ReporteAvanceDocente();
        }
    }
}
