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
    public partial class frmDirecListaAsignaturas : Form
    {
        N_CursosDocente ocursosDocente = new N_CursosDocente();
        public frmDirecListaAsignaturas()
        {
            InitializeComponent();
            MostrarVistaCatalogo();
            OcultarMoverAncharColumnas();
        }
        public void MostrarVistaCatalogo()
        {
            N_CursoCatalogo ovista = new N_CursoCatalogo();
            dgvAsignaturas.DataSource = ovista.ListandoVistaCatalogo();

        }
        public void OcultarMoverAncharColumnas()
        {
            //dgvAsignaturas.Columns[0].DisplayIndex = 14;
            //dgvAsignaturas.Columns[1].DisplayIndex = 14;

            dgvAsignaturas.Columns["GrupoAsignatura"].Visible = false;
            dgvAsignaturas.Columns["Nombre"].Width = 430;//280
            dgvAsignaturas.Columns["Creditos"].Width = 60;
            //dgvCatalogo.Columns["Categoria"].Visible = false;//
            dgvAsignaturas.Columns["NroSemestre"].Width = 80;
            dgvAsignaturas.Columns["NroSemestre"].Visible = false; ;
            dgvAsignaturas.Columns["avance"].Width = 40;
            dgvAsignaturas.Columns["avance"].DisplayIndex = 12;
            dgvAsignaturas.Columns["IdCatalogo"].Visible = false;
            dgvAsignaturas.Columns["Aula"].Width = 45;//45
            dgvAsignaturas.Columns["Aula"].Visible = false;//45
            dgvAsignaturas.Columns["DocentePractico"].Width = 155;//110
            dgvAsignaturas.Columns["DocenteTeorico"].Width = 155;//110
            dgvAsignaturas.Columns["Grupo"].Width = 45;//45
            dgvAsignaturas.Columns["CodDocentePractico"].Visible = false;
            dgvAsignaturas.Columns["CodDocenteTeorico"].Visible = false;
            dgvAsignaturas.Columns["CodAsignatura"].Width = 93;
        }

        private void dgvAsignaturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) //Si no se hizo click en el encabezado
            {
                DataGridViewRow row = dgvAsignaturas.Rows[e.RowIndex];
                if (dgvAsignaturas.Rows[e.RowIndex].Cells["avance"].Selected)
                {
                    string CodGrupoAsignatura = row.Cells["GrupoAsignatura"].Value.ToString();
                    string CodCatalogo = ocursosDocente.ObtenerCodCatalogo(CodGrupoAsignatura);
                    string NombreAsignatura = row.Cells["Nombre"].Value.ToString();
                    string Grupo = row.Cells["Grupo"].Value.ToString();
                    frmReporteDetalladoAvance form = new frmReporteDetalladoAvance(CodCatalogo, NombreAsignatura, Grupo);
                    form.ShowDialog();
                    //AbrirFormulariosEnPanelContenedor(new frmDirecListaAsignaturas());
                }
            }
        }

        private void frmDirecListaAsignaturas_Load(object sender, EventArgs e)
        {

        }
    }
}
