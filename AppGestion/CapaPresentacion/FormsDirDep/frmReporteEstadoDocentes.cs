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
using Excel;
using Microsoft.Office.Interop.Excel;
using CapaEntidades;
using System.IO;

namespace CapaPresentacion
{
    public partial class frmReporteEstadoDocentes : Form
    {
        readonly N_ReporteEstadoDocentes oREstadoDocentes = new N_ReporteEstadoDocentes();

        public frmReporteEstadoDocentes()
        {
            InitializeComponent();
        }
        
        private void MostrarReporte()
        {
            dgvEstadoDocentes.DataSource = oREstadoDocentes.MostrarReporteEstado();
        }

        public void ExportarDatos(DataGridView listadoCatalogo)
        {
            Microsoft.Office.Interop.Excel.Application exportarCatalogo = new Microsoft.Office.Interop.Excel.Application();
            exportarCatalogo.Application.Workbooks.Add(true);
            int indexColumn = 0;
            foreach (DataGridViewColumn columna in listadoCatalogo.Columns)
            {
                if (columna.Name != "EDITAR")
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
                    if (columna.Name != "EDITAR")
                    {
                        indexColumn++;
                        exportarCatalogo.Cells[indexfila + 1, indexColumn] = fila.Cells[columna.Name].Value;
                    }
                }
            }
            exportarCatalogo.Visible = true;
        }


        private void frmReporteEstadoAlumno_Load(object sender, EventArgs e)
        {
            //Mostrar reporte
            MostrarReporte();

            //Mostrar datos en el PieChart
            MostrarPieChart();      
        }

        private void MostrarPieChart()
        {
            System.Data.DataTable tabla = dgvEstadoDocentes.DataSource as System.Data.DataTable;
            Dictionary<string, float> dictEstados = new Dictionary<string, float>();
            string estado;
            foreach (DataRow row in tabla.Rows)
            {
                estado = row[3].ToString();
                if(dictEstados.ContainsKey(estado))
                    dictEstados[estado]++;
                else
                    dictEstados[estado] = 1;
            }

            // Obteniendo la suma de todos los valores
            var total = dictEstados.Skip(0).Sum(v => v.Value);

            foreach (string key in dictEstados.Keys)
            {
                chartReporte.Series["Estado"].Points.AddXY(key, dictEstados[key]/total);
            }
        }

        private void buttonCerrrar_Click(object sender, EventArgs e) => Close();

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea exportar?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)//Cerrar ventana
                ExportarDatos(dgvEstadoDocentes);
        }
    }
}
