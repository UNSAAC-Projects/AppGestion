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
    public partial class frmReporteAsistenciaDocente : Form
    {
        readonly N_AsistenciaDiariaDocentes oAsistenciaDocentes = new N_AsistenciaDiariaDocentes();
        public frmReporteAsistenciaDocente()
        {
            InitializeComponent();
        }

        private void frmReporteAsistenciaDocente_Load(object sender, EventArgs e)
        {
            dtpFechaInferior.Value = new DateTime(2022, 1, 1);
            dtpFechaSuperior.Value = DateTime.Now;
            mostrarReporte();
        }
        private void mostrarReporte()
        {
            string limInferior = dtpFechaInferior.Value.ToString("yyyy-MM-dd");
            string limSuperior = dtpFechaSuperior.Value.ToString("yyyy-MM-dd");
            //mostrar el reporte de asistencias
            dgvReporteAsistenciaDocentes.DataSource = oAsistenciaDocentes.ReporteAsistenciaDocenteDiaria(limInferior, limSuperior);

        }

        private void dtpFechaInferior_ValueChanged(object sender, EventArgs e)
        {
            dgvReporteAsistenciaDocentes.Columns.Clear();
            mostrarReporte();
        }

        private void dtpFechaSuperior_ValueChanged(object sender, EventArgs e)
        {
            dgvReporteAsistenciaDocentes.Columns.Clear();
            mostrarReporte();
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

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea exportar?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)//Cerrar ventana
                ExportarDatos(dgvReporteAsistenciaDocentes);
        }
    }
}
