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
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class frmAlumnosMatriculados : Form
    {
        readonly N_CursosDocente oCursosDocente = new N_CursosDocente();
        public frmAlumnosMatriculados()
        {
            InitializeComponent();
        }
        private void frmAlumnosMatriculados_Load(object sender, EventArgs e)
        {
            //Recuperar cursos docente
            DataTable tablaCursos = oCursosDocente.ListarCursosDocente(datos.CodDocente);
            if (tablaCursos != null)//Si el docente dicta cursos
            {
                //Mostrar items del combobox
                MostrarItemsComboBox(tablaCursos);
                //Mostrar los alumnos matriculados
                MostrarMatriculados();
            }
        }
        void MostrarMatriculados()
        {
            string codGrupoAsignatura = cboAsistenciaCurso.Text.Substring(0, 6);
            //Obtener IdCatalogo
            string idCatalogo = oCursosDocente.ObtenerCodCatalogo(codGrupoAsignatura);
            dgvMatriculados.DataSource = oCursosDocente.ListarMatriculados(idCatalogo);
        }
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

        private void cboAsistenciaCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarMatriculados();
        }

        private void dgvMatriculados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
