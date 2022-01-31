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
    public partial class frmReporteDetalladoAvance : Form
    {
        readonly N_ReporteSesiones oReporteSesiones = new N_ReporteSesiones();
        public frmReporteDetalladoAvance(string CodCatalogo, string NombreAsignatura, string Grupo)
        {
            InitializeComponent();
            MostrarPlanSesiones(CodCatalogo);
            MostrarNombreAsignatura(NombreAsignatura, Grupo);
            MoverModificarColumnas();
            
        }
        private void MoverModificarColumnas()
        {
            dgvAvanceDetallado.Columns["Horas"].Visible = false;
            dgvAvanceDetallado.Columns["VariacionHora"].Visible = false;
            
        }
        public void MostrarPlanSesiones(string CodCatalogo)
        {
            N_PlanSesiones pvista = new N_PlanSesiones();
            dgvAvanceDetallado.DataSource = pvista.ListandoPlanSesiones(CodCatalogo);
            decimal NroSesionesCompletados = 0;
            decimal NroSesionesNOCompletados = 0;
            foreach (DataGridViewRow fila in dgvAvanceDetallado.Rows)
            {
                if (fila.Cells["Finalizado"].Value.ToString() == "SI")
                {
                    fila.Cells["Finalizado"].Value = "Completado";
                    NroSesionesCompletados++;
                }
                else if (fila.Cells["Finalizado"].Value.ToString() == "NO")
                {
                    fila.Cells["Finalizado"].Value = "No completado";
                    NroSesionesNOCompletados++;
                }
            }

            decimal cantTemas = dgvAvanceDetallado.Rows.Count;
            decimal TotalCompletos = (NroSesionesCompletados / cantTemas) * 100;
            decimal TotalNOCompletos = (NroSesionesNOCompletados / cantTemas) * 100;

            nrocompletos.Text =decimal.Round(TotalCompletos,2) .ToString() + "%";
            nroNOcompletos.Text = decimal.Round(TotalNOCompletos,2).ToString() + "%";


        }
        private void MostrarNombreAsignatura(string nombreAsignatura, string grupo)
        {
            lblNombreAsignatura.Text = nombreAsignatura + " - " + "GRUPO " + grupo;
        }

        private void dgvAvanceDetallado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmReporteDetalladoAvance_Load(object sender, EventArgs e)
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
        private void buttonExportar_Click(object sender, EventArgs e)
        {
            ExportarDatos(dgvAvanceDetallado);
        }

        private void buttonCerrrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nrocompletos_Click(object sender, EventArgs e)
        {

        }
    }
}
