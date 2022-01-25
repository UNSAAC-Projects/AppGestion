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

        private void cbCursosReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Obtener codCursoAsignatura
            string codCursoAsig = cbCursosReporte.Text.Substring(0, 6);
            string codCatalogo = oCursosDocente.ObtenerCodCatalogo(codCursoAsig);
            //Actualizar reporte con los datos de la asignatura selecionada
            MostrarReporte(codCatalogo);
        }
    }
}
