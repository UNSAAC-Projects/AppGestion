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
    public partial class frmAlumnosMatriculadosPorCurso : Form
    {
        readonly N_CursosDocente oCursosDocente = new N_CursosDocente();
        public string IdCatalogo;
        public frmAlumnosMatriculadosPorCurso()
        {
            InitializeComponent();
        }
        void MostrarMatriculados()
        {
            dgvMatriculados.DataSource = oCursosDocente.ListarMatriculados(IdCatalogo);
        }

        private void frmAlumnosMatriculadosPorCurso_Load(object sender, EventArgs e)
        {
            MostrarMatriculados();

        }
    }
}
