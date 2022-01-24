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
    public partial class frmVistaCatalogo : Form
    {
        public bool Update = false;
        public frmVistaCatalogo()
        {
            InitializeComponent();
            MostrarVistaCatalogo();
            OcultarMoverAncharColumnas();
        }
        public void OcultarMoverAncharColumnas()
        {
            dgvCatalogo.Columns[0].DisplayIndex = 14;
            dgvCatalogo.Columns[1].DisplayIndex = 14;

            dgvCatalogo.Columns["GrupoAsignatura"].Visible = false;
            dgvCatalogo.Columns["Nombre"].Width = 430;//280
            dgvCatalogo.Columns["Creditos"].Width = 60;
            //dgvCatalogo.Columns["Categoria"].Visible = false;//
            dgvCatalogo.Columns["NroSemestre"].Width = 80;
            dgvCatalogo.Columns["Editar"].Width = 40;
            dgvCatalogo.Columns["Eliminar"].Width = 60;
            dgvCatalogo.Columns["IdCatalogo"].Visible=false;
            dgvCatalogo.Columns["Aula"].Width = 45;//45
            dgvCatalogo.Columns["DocentePractico"].Width = 155;//110
            dgvCatalogo.Columns["DocenteTeorico"].Width = 155;//110
            dgvCatalogo.Columns["Grupo"].Width = 45;//45
            dgvCatalogo.Columns["CodDocentePractico"].Visible = false;
            dgvCatalogo.Columns["CodDocenteTeorico"].Visible = false;
            dgvCatalogo.Columns["CodAsignatura"].Width = 93;
        }
        public void MostrarVistaCatalogo()
        {
            N_CursoCatalogo ovista = new N_CursoCatalogo();
            dgvCatalogo.DataSource = ovista.ListandoVistaCatalogo();

        }
        public void BuscarVista(string search)
        {
            N_Asignatura oAsignatura = new N_Asignatura();
            dgvCatalogo.DataSource = oAsignatura.BuscandoVistaCatalogo(search);

        }
        private void frmVistaCatalogo_Load(object sender, EventArgs e)
        {

        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            ExportarDatos(dgvCatalogo);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarVista(txtBuscar.Text);
        }

        private void dgvCatalogo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) //Si no se hizo click en el encabezado
            {
                if (dgvCatalogo.Rows[e.RowIndex].Cells["Editar"].Selected)
                {
                    EditCatalogo frm = new EditCatalogo();
                    frm.Update = true;
                    frm.textIdCatalogo.Text = dgvCatalogo.Rows[e.RowIndex].Cells["IDCatalogo"].Value.ToString();
                    frm.textIdCatalogo.Enabled = false;
                    frm.textCodigo.Text = dgvCatalogo.Rows[e.RowIndex].Cells["CodAsignatura"].Value.ToString();
                    frm.textNombreCurso.Text = dgvCatalogo.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    frm.textNombreCurso.Enabled = false;
                    frm.textCreditos.Text = dgvCatalogo.Rows[e.RowIndex].Cells["Creditos"].Value.ToString();
                    frm.textNroSemestre.Text = dgvCatalogo.Rows[e.RowIndex].Cells["NroSemestre"].Value.ToString();
                    frm.textNroSemestre.Enabled = false;
                    frm.textSemestreLectivo.Text= dgvCatalogo.Rows[e.RowIndex].Cells["SemestreLectivo"].Value.ToString();
                    frm.cmbGrupo.Text= dgvCatalogo.Rows[e.RowIndex].Cells["Grupo"].Value.ToString();
                    frm.textAula.Text= dgvCatalogo.Rows[e.RowIndex].Cells["Aula"].Value.ToString();

                    if (Convert.ToInt32(dgvCatalogo.Rows[e.RowIndex].Cells["Creditos"].Value) < 4)
                    {
                        frm.cmbDia3.Enabled = false;
                        frm.textHInicio3.Enabled = false;
                        frm.textHFin3.Enabled = false;
                        frm.cmbTipo3.Enabled = false;
                    }
                    frm.DocPractico = dgvCatalogo.Rows[e.RowIndex].Cells["CodDocentePractico"].Value.ToString();
                    frm.DocTeorico = dgvCatalogo.Rows[e.RowIndex].Cells["CodDocenteTeorico"].Value.ToString();
                    frm.ShowDialog();
                    MostrarVistaCatalogo();
                }
                else if (dgvCatalogo.Rows[e.RowIndex].Cells["Eliminar"].Selected)
                {
                    DialogResult dialogResult = MessageBox.Show("¿Seguro que desea eliminar?", "Alerta", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        N_CursoCatalogo oVista = new N_CursoCatalogo();
                        string delete = dgvCatalogo.Rows[e.RowIndex].Cells["IDCatalogo"].Value.ToString();
                        oVista.EliminandoCursoCatalogo(delete);

                        MostrarVistaCatalogo();
                    }
                }
            }
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            frmVistaHorarios frm = new frmVistaHorarios();
            frm.ShowDialog();
        }
        public void ExportarDatos(DataGridView listadoCatalogo)
        {
            Microsoft.Office.Interop.Excel.Application exportarCatalogo = new Microsoft.Office.Interop.Excel.Application();
            exportarCatalogo.Application.Workbooks.Add(true);
            int indexColumn = 0;
            foreach (DataGridViewColumn columna in listadoCatalogo.Columns)
            {
                if ((columna.Name != "Editar") && (columna.Name != "Eliminar"))
                {
                    indexColumn++;
                    exportarCatalogo.Cells[1, indexColumn] = columna.Name;

                }
            }
            int indexfila = 0;
            foreach (DataGridViewRow fila in listadoCatalogo.Rows)
            {
                indexfila++;
                indexColumn = 0;
                foreach (DataGridViewColumn columna in listadoCatalogo.Columns)
                {
                    if ((columna.Name != "Editar") && (columna.Name != "Eliminar"))
                    {
                        indexColumn++;
                        exportarCatalogo.Cells[indexfila + 1, indexColumn] = fila.Cells[columna.Name].Value;
                    }
                }
            }
            exportarCatalogo.Visible = true;
        }

    }
}
