using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmReportesSesiones : Form
    {
        N_ReporteSesiones oReporteSesiones = new N_ReporteSesiones();

        public frmReportesSesiones()
        {
            InitializeComponent();
        }

        private void frmReportesSesiones_Load(object sender, EventArgs e)
        {
            MostrarReporte("C006");
        }

        private void MostrarReporte(string IdCatalogo)
        {
            dgvReporteSesiones.DataSource =  oReporteSesiones.MostrarReporteSesiones(IdCatalogo);
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

        private void buttonExportar_Click(object sender, EventArgs e) => ExportarDatos(dgvReporteSesiones);
    }
}
