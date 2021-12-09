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
    public partial class mainDirectorEscuela : Form
    {
        N_Asignatura oAsignatura = new N_Asignatura();
        N_Login oLogin = new N_Login();
        public mainDirectorEscuela(string CodDocente)
        {
            InitializeComponent();
            MostrarTablaAsignatura();
            OcultarMoverAncharColumnas();
            MostrarNombreUsuario(CodDocente);
        }

        private void MostrarNombreUsuario(string CodDocente)
        {
            labelNombre.Text = oLogin.ObtenerNombreUsuario(CodDocente);
        }

        public void OcultarMoverAncharColumnas()
        {
            dgvAsignaturas.Columns[0].DisplayIndex =10;
            dgvAsignaturas.Columns[1].DisplayIndex = 10;
            dgvAsignaturas.Columns[2].DisplayIndex = 10;//0

            dgvAsignaturas.Columns[0].Width = 70;
            dgvAsignaturas.Columns[1].Width = 50;
            dgvAsignaturas.Columns[2].Width = 50;
            dgvAsignaturas.Columns[3].Width = 80;
            dgvAsignaturas.Columns[4].Width = 60;
            dgvAsignaturas.Columns[5].Width = 250;
            dgvAsignaturas.Columns[6].Width = 50;
            dgvAsignaturas.Columns[7].Width = 70;
            dgvAsignaturas.Columns[8].Width = 90;
            dgvAsignaturas.Columns[9].Width = 90;
        }
        public void MostrarTablaAsignatura()
        {
            N_Asignatura oAsignatura = new N_Asignatura();
            dgvAsignaturas.DataSource = oAsignatura.ListandoAsignaturas();

        }

        public void BuscarAsignatura(string search)
        {
            N_Asignatura oAsignatura = new N_Asignatura();
            dgvAsignaturas.DataSource = oAsignatura.BuscandoAsignatura(search);

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BuscarAsignatura(txtBuscar.Text);
        }

        private void dgvAsignaturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvAsignaturas.Rows[e.RowIndex].Cells["CrearGrupo"].Selected)
            {
                DialogResult dialogResult = MessageBox.Show("¿Seguro que desea crear un nuevo grupo?", "Alerta", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    EditCatalogo frm = new EditCatalogo();

                    N_CursoCatalogo oAsignatura = new N_CursoCatalogo();
                    frm.textCodigo.Text = dgvAsignaturas.Rows[e.RowIndex].Cells["CodAsignatura"].Value.ToString();
                    frm.textNombreCurso.Text = dgvAsignaturas.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    frm.textCreditos.Text = dgvAsignaturas.Rows[e.RowIndex].Cells["Creditos"].Value.ToString();
                    frm.textIdCatalogo.Text = oAsignatura.New();
                    if (Convert.ToInt32(dgvAsignaturas.Rows[e.RowIndex].Cells["Creditos"].Value) < 4)
                    {
                        frm.cmbDia3.Enabled = false;
                        frm.textHInicio3.Enabled = false;
                        frm.textHFin3.Enabled = false;
                        frm.cmbTipo3.Enabled = false;
                        frm.textIdCatalogo.Enabled = false;
                    }
                    frm.Show();
                }

            }
            if (dgvAsignaturas.Rows[e.RowIndex].Cells["Eliminar"].Selected)
            {
                DialogResult dialogResult = MessageBox.Show("¿Seguro que desea eliminar?", "Alerta", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string delete = dgvAsignaturas.Rows[e.RowIndex].Cells["CodAsignatura"].Value.ToString();
                    oAsignatura.EliminandoAsignatura(delete);

                    MostrarTablaAsignatura();
                }
            }
            if (dgvAsignaturas.Rows[e.RowIndex].Cells["Editar"].Selected)
            {
                frmMantAsignatura frm = new frmMantAsignatura();
                frm.Update = true;
                frm.textCodAsignatura.Enabled = false;
                frm.textIDPlan.Enabled = false;
                frm.textCodAsignatura.Text = dgvAsignaturas.Rows[e.RowIndex].Cells["CodAsignatura"].Value.ToString();
                frm.textIDPlan.Text = dgvAsignaturas.Rows[e.RowIndex].Cells["IDPlan"].Value.ToString();
                frm.textNombre.Text = dgvAsignaturas.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                frm.textCreditos.Text = dgvAsignaturas.Rows[e.RowIndex].Cells["Creditos"].Value.ToString();
                frm.cmbCategoria.Text = dgvAsignaturas.Rows[e.RowIndex].Cells["Categoria"].Value.ToString();
                frm.textHorasPracticas.Text = dgvAsignaturas.Rows[e.RowIndex].Cells["HorasPracticas"].Value.ToString();
                frm.textHorasTeoricas.Text = dgvAsignaturas.Rows[e.RowIndex].Cells["HorasTeoricas"].Value.ToString();
                frm.textPrerrequisitos.Text = dgvAsignaturas.Rows[e.RowIndex].Cells["Prerrequisitos"].Value.ToString();
                frm.ShowDialog();
                MostrarTablaAsignatura();
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            frmMantAsignatura frm = new frmMantAsignatura();
            frm.ShowDialog();
            frm.Update = false;
            MostrarTablaAsignatura();
        }

        private void pictureMINIMIZE1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureCANCEL1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerCatalogo_Click_1(object sender, EventArgs e)
        {
            frmVistaCatalogo frm = new frmVistaCatalogo();
            frm.ShowDialog();
        }

        private void pictureMaxDirectorEscuela_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void panelPrinciapl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
