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
    public partial class frmReporteEstadoAlumnos : Form
    {
        readonly N_ReporteEstadoAlumnos oReporteEstado = new N_ReporteEstadoAlumnos();
        readonly N_CursosDocente oCursosDocente = new N_CursosDocente();
        readonly N_Docente oDocente = new N_Docente();
        private string CodDocente;
        public frmReporteEstadoAlumnos(string pCodDocente)
        {
            InitializeComponent();
            CodDocente = pCodDocente;
        }

        private void MostrarItemsComboBox(string[] Asignaturas)
        {
            //Mostrar cursos
            cbCursosReporte.Items.AddRange(Asignaturas);
        }
        
        private void MostrarReporte(string IdCatalogo)
        {
            dgvEstadoAlumnos.DataSource = oReporteEstado.MostrarReporteEstado(IdCatalogo, DateTime.Now);
        }

        private void frmReporteEstadoAlumno_Load(object sender, EventArgs e)
        {
            try
            {
                //Obtener cursos que dicta el docente
                string[] Asignaturas = oDocente.CursosDocente(CodDocente);
                if (Asignaturas != null) //Si tiene asignaturas dictando
                {
                    MostrarItemsComboBox(Asignaturas); //Mostrar opciones en comboBox
                    cbCursosReporte.SelectedIndex = 0;

                    //Obtener codCursoAsignatura
                    string codCursoAsig = cbCursosReporte.Text.Substring(0, 6);
                    string codCatalogo = oCursosDocente.ObtenerCodCatalogo(codCursoAsig);
                    MostrarReporte(codCatalogo); //Mostrar reporte de plan de sesiones

                    //Mostrar datos en el PieChart
                    MostrarPieChart();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("¡No existen asistencias registradas!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void MostrarPieChart()
        {
            DataTable tabla = dgvEstadoAlumnos.DataSource as DataTable;
            Dictionary<string, float> dictEstados = new Dictionary<string, float>();
            string estado;
            foreach (DataRow row in tabla.Rows)
            {
                estado = row[2].ToString();
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



        private void cbCursosReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Obtener codCursoAsignatura
            string codCursoAsig = cbCursosReporte.Text.Substring(0, 6);
            string codCatalogo = oCursosDocente.ObtenerCodCatalogo(codCursoAsig);
            //Actualizar reporte con los datos de la asignatura selecionada
            MostrarReporte(codCatalogo);
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea exportar?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)//Cerrar ventana
                ExportarDatos(dgvEstadoAlumnos);
        }

        private void buttonCerrrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
