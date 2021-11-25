using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class FormDirecDepAcade : Form
    {
        public FormDirecDepAcade()
        {
            InitializeComponent();
            MostrarTablaCatalogo();
            MoverModificarColumnas();
        }

        private void MoverModificarColumnas()
        {
            // Mover columnas editar y eliminar
            dgvCatalogo.Columns[0].DisplayIndex = 13;
            dgvCatalogo.Columns[1].DisplayIndex = 13;

        }

        private void MostrarTablaCatalogo()
        {
            // Modulo para mostrar el catalogo en el formulario principal del director de escuela
            N_CursoCatalogo oCursoCatalogo = new N_CursoCatalogo();
            dgvCatalogo.DataSource = oCursoCatalogo.ListarCatalogoDA(); //DA: director académico
        }

        #region Módulos
        DataView ImportarDatos(string nombrearchivo)
        {
            string conexion = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;DataSource={0}; Extended Properties'Excel 12.0;'", nombrearchivo);
            OleDbConnection conector = default(OleDbConnection);
            conector = new OleDbConnection(conexion);
            conector.Open();
            OleDbCommand consulta = new OleDbCommand("Select *  from [Hoja1$]", conector);
            OleDbDataAdapter adaptador = new OleDbDataAdapter();
            adaptador.SelectCommand = consulta;

            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            conector.Close();
            return ds.Tables[0].DefaultView;
        }
        #endregion

        #region Eventos
        private void button1_Click(object sender, EventArgs e)
        {
            buttonIMPORTAR.BackColor = Color.FromArgb(12, 61,92);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonLISTAR.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void buttonDISTRIBUCION_Click(object sender, EventArgs e)
        {
            buttonIMPORTAR.BackColor = Color.FromArgb(12, 61, 92);
            FormDistDocente c = new FormDistDocente();
            c.Show();
        }

        private void buttonLISTAR_Click(object sender, EventArgs e)
        {
            buttonIMPORTAR.BackColor = Color.FromArgb(12, 61, 92);
            FormListaDocentes p = new FormListaDocentes();
            p.Show();
        }

        private void buttonIMPORTAR_Click(object sender, EventArgs e)
        {
            buttonIMPORTAR.BackColor = Color.FromArgb(12, 61, 92);
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = " Excel | * .xls;*.xlsx;";
            openFileDialog.Title = "Selecionar Archivo ";
            if(openFileDialog.ShowDialog()== DialogResult.OK)
            {
                dgvCatalogo.DataSource = ImportarDatos(openFileDialog.FileName);
            }

        }
        
        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();        
        }

        private void btnMINIMIZAR_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void dgvCatalogo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvCatalogo.Rows[e.RowIndex].Cells["ELIMINAR"].Selected)
            //{
            //    DialogResult dialogResult = MessageBox.Show("¿Seguro que desea eliminar?", "Some Title", MessageBoxButtons.YesNo);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        //do something
            //    }
            //    else if (dialogResult == DialogResult.No)
            //    {
            //        //do something else
            //    }

            //}
            if (dgvCatalogo.Rows[e.RowIndex].Cells["EDITAR"].Selected)
            {
                frmAsignarDocente form = new frmAsignarDocente();
                form.ShowDialog();
            }
        }
    }
}
