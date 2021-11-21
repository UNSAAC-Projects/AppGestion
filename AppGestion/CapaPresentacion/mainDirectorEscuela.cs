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
        public mainDirectorEscuela()
        {
            InitializeComponent();
            MostrarTablaAsignatura();
            OcultarMoverAncharColumnas();
        }
        public void OcultarMoverAncharColumnas()
        {
            dgvAsignaturas.Columns[0].DisplayIndex =10;
            dgvAsignaturas.Columns[1].DisplayIndex = 10;
            dgvAsignaturas.Columns[2].DisplayIndex = 10;//0

            dgvAsignaturas.Columns[0].Width = 30;
            dgvAsignaturas.Columns[1].Width = 30;
            dgvAsignaturas.Columns[2].Width = 40;
            dgvAsignaturas.Columns[3].Width = 40;
            dgvAsignaturas.Columns[4].Width = 70;
            dgvAsignaturas.Columns[5].Width = 200;
            dgvAsignaturas.Columns[6].Width = 50;
            dgvAsignaturas.Columns[7].Width = 70;
            dgvAsignaturas.Columns[8].Width = 80;
            dgvAsignaturas.Columns[9].Width = 60;
            
        }
        public void MostrarTablaAsignatura()
        {
            N_Asignatura oAsignatura = new N_Asignatura();
            dgvAsignaturas.DataSource = oAsignatura.ListandoAsignaturas();

        }

        private void mainDirectorEscuela_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ContenedorLogin_Paint(object sender, PaintEventArgs e)
        {

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
                EditCatalogo frm = new EditCatalogo();
                //----------- EXCLUISVAMENTE EL NUEVO CODIGO ASIGNATURA ---------------------------
                N_CursoCatalogo oAsignatura = new N_CursoCatalogo();
                
                frm.Show();
            }
        }
    }
}
