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

            //chartReporte.Series["Estado"].Points.AddXY("Normal", 0.534);
            //chartReporte.Series["Estado"].Points.AddXY("Desistió", 0.221);
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
