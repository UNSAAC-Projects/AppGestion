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
    public partial class ReporteAsistenciasAlumnos : Form
    {
        readonly N_ReporteAsistencia oreporteasistencia = new N_ReporteAsistencia();
        readonly N_CursosDocente D = new N_CursosDocente();

        public string CodDocente;
        public ReporteAsistenciasAlumnos()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReporteAsistenciasAlumnos_Load(object sender, EventArgs e)
        {
            //Obtener cursos del docente
            DataTable tablaCursos = D.ListarCursosDocente(datos.CodDocente);
            if(tablaCursos != null)
            {
                MostrarItemsComboBox(tablaCursos);
                comboBoxCursosReporte.SelectedIndex = 0;
                //comboBoxUnidad.SelectedIndex = 0;
            }
        }

        private void mostrarReporte()
        {
            string NombreAsig = comboBoxCursosReporte.Text;
            string IdCat = oreporteasistencia.recuperarIdCat(NombreAsig, CodDocente);
            string limInferior = dtpFechaInferior.Value.ToString("yyyy-MM-dd");
            string limSuperior = dtpFechaSuperior.Value.ToString("yyyy-MM-dd");
            dgvReporteAsistencia.DataSource = oreporteasistencia.ReporteAsistencia(IdCat, limInferior, limSuperior);
            //dgvReporteAsistencia.Columns.Add("Porcentaje", "Porcentaje de Asistencia");
            if (!dgvReporteAsistencia.Columns.Contains("Porcentaje"))
            {
                dgvReporteAsistencia.Columns.Add("Porcentaje", "Porcentaje de Asistencia");
            }
            int M;
            string valorFila;
            M = dgvReporteAsistencia.Columns.Count;
            foreach (DataGridViewRow m in dgvReporteAsistencia.Rows)
            {
                int asistencia;
                asistencia = 0;
                for (int i = 2; i < M - 1; i++)
                {
                    valorFila = m.Cells[i].Value.ToString();
                    if (valorFila == "P")
                    {
                        asistencia++;
                    }
                }
                float PORCENTAJE =(((float)asistencia * 100 / (float)(M - 3))) ;
                //float PORCENTAJE = 70;
                PORCENTAJE = (float)Math.Round(PORCENTAJE,2);
                m.Cells["Porcentaje"].Value = PORCENTAJE.ToString() +"%";
            }
        }

        private void comboBoxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvReporteAsistencia.Columns.Clear();
            comboBoxCursosReporte.DropDownStyle = ComboBoxStyle.DropDownList;
            mostrarReporte();
        }
        void MostrarItemsComboBox(DataTable tablaCursos)
        {
            int n = tablaCursos.Rows.Count;
            int i = 0;
            while(i < n)
            {
                comboBoxCursosReporte.Items.Add(tablaCursos.Rows[i][1].ToString());
                i++;
            }
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

        private void btnCancelarFrmReporte_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimizarFrmReporte_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void dtpFechaInferior_ValueChanged(object sender, EventArgs e)
        {
            dgvReporteAsistencia.Columns.Clear();
            mostrarReporte();
        }

        private void dtpFechaSuperior_ValueChanged(object sender, EventArgs e)
        {
            dgvReporteAsistencia.Columns.Clear();
            mostrarReporte();
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            ExportarDatos(dgvReporteAsistencia);
        }
    }
}
