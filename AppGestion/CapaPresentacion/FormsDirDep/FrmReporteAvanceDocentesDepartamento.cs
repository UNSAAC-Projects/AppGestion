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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvAvanceDocentes.DataSource = oDocentes.BuscarReporteAvance(txtBuscarAvanceDocente.Text);
        }

        private void dgvAvanceDocentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void ExportarDatos(DataGridView listadoCatalogo)
        {
            Microsoft.Office.Interop.Excel.Application exportarCatalogo = new Microsoft.Office.Interop.Excel.Application();
            exportarCatalogo.Application.Workbooks.Add(true);
            int indexColumn = 0;

            //Recorrer columnas y guardar valores
            foreach (DataGridViewColumn columna in listadoCatalogo.Columns)
            {
                indexColumn++;
                exportarCatalogo.Cells[1, indexColumn] = columna.Name;
            }
            int indexfila = 0;

            //Recorrer filas y guardar sus valores
            foreach (DataGridViewRow fila in listadoCatalogo.Rows)
            {
                indexfila++;
                indexColumn = 0;
                foreach (DataGridViewColumn columna in listadoCatalogo.Columns)
                {
                    indexColumn++;
                    exportarCatalogo.Cells[indexfila + 1, indexColumn] = fila.Cells[columna.Name].Value;
                }
            }
            exportarCatalogo.Visible = true;
        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea exportar?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)//Cerrar ventana
                ExportarDatos(dgvAvanceDocentes);
        }
    }
}
