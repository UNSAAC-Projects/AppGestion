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
    public partial class frmReporteEstadoAlumno : Form
    {
        readonly N_ReporteEstadoAlumnos oReporteEstado = new N_ReporteEstadoAlumnos();

        public frmReporteEstadoAlumno()
        {
            InitializeComponent();
        }
        /*
        void MostrarItemsComboBox(DataTable tablaCursos)
        {
            int n = tablaCursos.Rows.Count;
            string grupoAsignatura, nombreAsignatura;

            //Recorrer filas del DataTable
            foreach (DataRow row in tablaCursos.Rows)
            {
                grupoAsignatura = row[0].ToString(); //GrupoAsignatura (ex: IF342)
                nombreAsignatura = row[1].ToString(); //Nombre de la asignatura
                cboAsistenciaCurso.Items.Add($"{grupoAsignatura} - {nombreAsignatura}");
            }
            //Seleccionar valor por defecto del combobox
            cboAsistenciaCurso.SelectedIndex = 0;
        }
        */
        private void frmReporteEstadoAlumno_Load(object sender, EventArgs e)
        {
            /*
            //Obtener cursos que dicta el docente
            //string[] Asignaturas = oDocente.CursosDocente(CodDocente);
            if (Asignaturas != null) //Si tiene asignaturas dictando
            {
                //MostrarItemsComboBox(Asignaturas); //Mostrar opciones en comboBox
                //comboBoxAsignaturas.SelectedIndex = 0;

                //Obtener codCursoAsignatura
                string codCursoAsig = comboBoxAsignaturas.Text.Substring(0, 6);
                string codCatalogo = oCursosDocente.ObtenerCodCatalogo(codCursoAsig);
                MostrarReporte(codCatalogo); //Mostrar reporte de plan de sesiones
            }
            */
        }

        private void MostrarReporte()
        {
            //dgvEstadoAlumnos.DataSource = oReporteEstado.MostrarReporteEstado();
        }
        
    }
}
