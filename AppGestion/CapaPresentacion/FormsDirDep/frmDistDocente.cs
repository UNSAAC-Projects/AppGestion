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
    public partial class frmDistDocentes : Form
    {
        public frmDistDocentes()
        {
            InitializeComponent();
            MostrarTablaDocentes();
            MoverModificarColumnas();
        }

        private void MoverModificarColumnas()
        {
            //Mostrar encabezado
            dgvCargaAcademica.ColumnHeadersVisible = true;

            //Mover columnas editar
            dgvCargaAcademica.Columns[0].DisplayIndex = 5;

            //Ocultar columnas
            //dgvCargaAcademica.Columns["HORAS DICTADO"].Visible = false;
            dgvCargaAcademica.Columns["TITULO ACADEMICO"].Visible = false;
        }

        private void MostrarTablaDocentes()
        {
            N_Docente oDocente = new N_Docente();
            dgvCargaAcademica.DataSource =  oDocente.ListarDistribucionDocentes();
        }

        private void dgvCargaAcademica_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvCargaAcademica.Rows[e.RowIndex];
            if (row.Cells["VER"].Selected)
            {
                // Recuperando el código del docente
                string codDocente = row.Cells["CODIGO"].Value.ToString();

                // Creando nuevo formulario
                frmHorarioDocente form = new frmHorarioDocente(codDocente);

                // Obtener datos de las columnas
                form.textBoxCodigo.Text = codDocente;
                form.textBoxNombres.Text = row.Cells["NOMBRES"].Value.ToString();
                form.textBoxApellidos.Text = row.Cells["APELLIDOS"].Value.ToString();
                form.textBoxEstado.Text = row.Cells["ESTADO"].Value.ToString();
                //form.textBoxHDictado.Text = row.Cells["HORAS DICTADO"].Value.ToString();
                form.ShowDialog();
            }
        }

        private void buttonCerrar_Click(object sender, EventArgs e) => Close();

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
