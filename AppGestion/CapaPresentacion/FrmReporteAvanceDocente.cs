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
    public partial class FrmReporteAvanceDocente : Form
    {
        N_ReporteSesiones oReporteSesiones = new N_ReporteSesiones();
       
        public FrmReporteAvanceDocente()
        {
            InitializeComponent();
        }


        private void FrmReporteAvanceDocente_Load(object sender, EventArgs e)
        {
            MostrarReporte(datos.CodDocente);
            agregarPorcentajeAvance();
            cargarDatosGrafico();
        }
        private void agregarPorcentajeAvance()
        {
            DataTable dt = new DataTable();
            dt = oReporteSesiones.MostrarReporteSesionesDocente(datos.CodDocente);
            int nroFilas = dt.Rows.Count;
            for (int k = 0; k < nroFilas; k++)
            {
                string valor = dt.Rows[k]["CantidadAvance"].ToString();
                dgvAvanceDocenteSesion.Rows[k].Cells["Porcentaje"].Value = valor + "%";
               
            }
            dgvAvanceDocenteSesion.Columns["Porcentaje"].DisplayIndex = 1;
            dgvAvanceDocenteSesion.Columns["Asignatura"].DisplayIndex = 0;
        }
        private void cargarDatosGrafico()
        {
           
            DataTable dt = new DataTable();
            dt = oReporteSesiones.MostrarReporteSesionesDocente(datos.CodDocente);
            int nroFilas = dt.Rows.Count;
            chart1.Titles.Add("Avacen por curso");
            for ( int k=0;k<nroFilas;k++)
            {
                chart1.Series["Series1"].Points.AddXY(dt.Rows[k]["Asignatura"], dt.Rows[k]["CantidadAvance"]);
            }

        }
        private void MostrarReporte(string IdDocente)
        {
            dgvAvanceDocenteSesion.DataSource = oReporteSesiones.MostrarReporteSesionesDocente(IdDocente);
            dgvAvanceDocenteSesion.Columns["CantidadAvance"].Visible = false;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
