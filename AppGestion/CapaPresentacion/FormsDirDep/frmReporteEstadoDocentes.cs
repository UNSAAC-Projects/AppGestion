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

        private void frmReporteEstadoAlumno_Load(object sender, EventArgs e)
        {
            //Mostrar reporte
            MostrarReporte();

            //Mostrar datos en el PieChart
            MostrarPieChart();      
        }

        private void MostrarPieChart()
        {
            DataTable tabla = dgvEstadoDocentes.DataSource as DataTable;
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
    }
}
