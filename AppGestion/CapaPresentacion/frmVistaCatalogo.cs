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
            dgvCatalogo.Columns[0].DisplayIndex = 10;
            dgvCatalogo.Columns[1].DisplayIndex = 10;

            dgvCatalogo.Columns[0].Width = 50;
            dgvCatalogo.Columns[1].Width = 50;
            dgvCatalogo.Columns[2].Visible = false;
            dgvCatalogo.Columns[3].Visible = false;
            dgvCatalogo.Columns[4].Width = 100;
            dgvCatalogo.Columns[5].Width = 240;
            dgvCatalogo.Columns[6].Width = 70;
            dgvCatalogo.Columns[7].Width = 90;
            dgvCatalogo.Columns[8].Width = 90;
          
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
            if (dgvCatalogo.Rows[e.RowIndex].Cells["Editar"].Selected)
            {
                EditCatalogo frm = new EditCatalogo();
                frm.Update = true;
                frm.textIdCatalogo.Text=dgvCatalogo.Rows[e.RowIndex].Cells["IDCatalogo"].Value.ToString();
                frm.textIdCatalogo.Enabled = false;
                frm.textCodigo.Text = dgvCatalogo.Rows[e.RowIndex].Cells["CodAsignatura"].Value.ToString();
                frm.textNombreCurso.Text = dgvCatalogo.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                frm.textCreditos.Text = dgvCatalogo.Rows[e.RowIndex].Cells["Creditos"].Value.ToString();
                if (Convert.ToInt32(dgvCatalogo.Rows[e.RowIndex].Cells["Creditos"].Value) < 4)
                {
                    frm.cmbDia3.Enabled = false;
                    frm.textHInicio3.Enabled = false;
                    frm.textHFin3.Enabled = false;
                    frm.cmbTipo3.Enabled = false;
                }
                frm.ShowDialog();
                MostrarVistaCatalogo();
            }
            else if(dgvCatalogo.Rows[e.RowIndex].Cells["Eliminar"].Selected)
            {
                N_CursoCatalogo oVista = new N_CursoCatalogo();
                string delete = dgvCatalogo.Rows[e.RowIndex].Cells["IDCatalogo"].Value.ToString();
                oVista.EliminandoCursoCatalogo(delete);

                MostrarVistaCatalogo();
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

        private void btnMinVistaCatalogo_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btonCerrarVistaCatalogo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
