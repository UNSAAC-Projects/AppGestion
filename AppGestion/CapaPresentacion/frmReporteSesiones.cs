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
    public partial class frmReporteSesiones : Form
    {
        N_ReporteSesiones oReporteSesiones = new N_ReporteSesiones();
        N_CursosDocente oCursosDocente = new N_CursosDocente();
        N_Docente oDocente = new N_Docente();

        private string CodDocente;
        public frmReporteSesiones(string pCodDocente)
        {
            InitializeComponent();
            CodDocente = pCodDocente;
        }

        private void frmReportesSesiones_Load(object sender, EventArgs e)
        {
            //Obtener cursos que dicta el docente
            string[] Asignaturas = oDocente.CursosDocente(CodDocente);
            if(Asignaturas != null) //Si tiene asignaturas dictando
            {
                MostrarItemsComboBox(Asignaturas); //Mostrar opciones en comboBox
                comboBoxAsignaturas.SelectedIndex = 0;

                //Obtener codCursoAsignatura
                string codCursoAsig = comboBoxAsignaturas.Text.Substring(0, 6);
                string codCatalogo = oCursosDocente.ObtenerCodCatalogo(codCursoAsig);
                MostrarReporte(codCatalogo); //Mostrar reporte de plan de sesiones

                //Ocultar columnas
                dgvReporteSesiones.Columns["Fecha"].Visible = false;
                dgvReporteSesiones.Columns["Total Asistentes"].Visible = false;
                dgvReporteSesiones.Columns["Total faltantes"].Visible = false;
            }
        }

        private void MostrarItemsComboBox(string[] Asignaturas)
        {
            //Mostrar cursos
            comboBoxAsignaturas.Items.AddRange(Asignaturas);
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

        private void comboBoxAsignaturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Obtener codCursoAsignatura
            string codCursoAsig = comboBoxAsignaturas.Text.Substring(0,6);
            string codCatalogo = oCursosDocente.ObtenerCodCatalogo(codCursoAsig);
            //Actualizar reporte con los datos de la asignatura selecionada
            MostrarReporte(codCatalogo);
        }
        private void buttonExportar_Click(object sender, EventArgs e) => ExportarDatos(dgvReporteSesiones);

        private void buttonCerrrar_Click(object sender, EventArgs e) => Close();

        private void btnCerrarFrmReportesSesiones_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvReporteSesiones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
