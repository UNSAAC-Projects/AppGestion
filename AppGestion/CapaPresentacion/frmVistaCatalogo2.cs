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
    public partial class frmVistaCatalogo2 : Form
    {
        readonly N_CursoCatalogo ocurso = new N_CursoCatalogo();
        public frmVistaCatalogo2()
        {
            InitializeComponent();
        }

        private void frmAlumnosMatriculadosPorCurso_Load(object sender, EventArgs e)
        {
            MostrarListaCursos();
        }
        void MostrarListaCursos()
        {
            dgvCatalogo.DataSource = ocurso.ListarCursoCatalogo2();
            if (dgvCatalogo.Rows.Count == 0)
            {
                MessageBox.Show("No existen Elementos");
            }
            else
            {
                dgvCatalogo.Columns["AlumnosMatriculados"].DisplayIndex = 3;
                dgvCatalogo.Columns["Nombre"].Width = 430;
                dgvCatalogo.Columns["IdCatalogo"].Visible = false;
                dgvCatalogo.Columns["CodigoAsignatura"].Width = 120;
            }
            
        }

        private void dgvCatalogo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) //Si no se hizo click en el encabezado
            {
                if (dgvCatalogo.Rows[e.RowIndex].Cells["AlumnosMatriculados"].Selected)
                {
                    frmAlumnosMatriculadosPorCurso matriculados = new frmAlumnosMatriculadosPorCurso();
                    string IdCatalogo= dgvCatalogo.Rows[e.RowIndex].Cells["IDCatalogo"].Value.ToString();
                    matriculados.IdCatalogo = IdCatalogo;
                    matriculados.label1.Text= dgvCatalogo.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    matriculados.labelGrupo.Text = dgvCatalogo.Rows[e.RowIndex].Cells["Grupo"].Value.ToString();
                    matriculados.ShowDialog();
                }
            }
        }
    }
}
