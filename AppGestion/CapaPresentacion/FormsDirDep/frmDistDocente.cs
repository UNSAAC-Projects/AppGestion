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

            // Mover columnas editar
            dgvCargaAcademica.Columns[0].DisplayIndex = 5;

        }

        private void MostrarTablaDocentes()
        {
            N_Docente oDocente = new N_Docente();
            dgvCargaAcademica.DataSource =  oDocente.ListarDistribucionDocentes();
        }

        private void pictureBoxCerrarTENTATIVA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMINIMIZARTENTATIVA_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void dgvCargaAcademica_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCargaAcademica.Rows[e.RowIndex].Cells["VER"].Selected)
            {
                ////Obtener cod curso
                //string CodCursoCatalogo = dgvCargaAcademica.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();

                //frmAsignarDocente form = new frmAsignarDocente(CodCursoCatalogo);
                ////Recuperar información de la tabla
                //form.textBoxCodigo.Text = CodCursoCatalogo;
                //form.textBoxCurso.Text = dgvCatalogo.Rows[e.RowIndex].Cells["CURSO"].Value.ToString();
                //form.textBoxHT.Text = dgvCatalogo.Rows[e.RowIndex].Cells["HT"].Value.ToString();
                //form.textBoxHP.Text = dgvCatalogo.Rows[e.RowIndex].Cells["HP"].Value.ToString();
                //form.textBoxCreditos.Text = dgvCatalogo.Rows[e.RowIndex].Cells["CRED"].Value.ToString();
                //form.textBoxAula.Text = dgvCatalogo.Rows[e.RowIndex].Cells["AULA"].Value.ToString();
                //form.textBoxGrupo.Text = dgvCatalogo.Rows[e.RowIndex].Cells["GRUPO"].Value.ToString();
                //form.ShowDialog();
                string codDocente = dgvCargaAcademica.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
                frmHorarioDocente form = new frmHorarioDocente(codDocente);
                form.ShowDialog();
            }
        }
    }
}
