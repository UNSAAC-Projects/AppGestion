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
    public partial class frmDirecDepAcade : Form
    {
        public frmDirecDepAcade()
        {
            InitializeComponent();
            MostrarTablaCatalogo();
            MoverModificarColumnas();
        }

        #region Módulos
        private void MoverModificarColumnas()
        {
            //Mostrar encabezado
            dgvCatalogo.ColumnHeadersVisible = true;
            // Mover columnas editar y eliminar
            dgvCatalogo.Columns[0].DisplayIndex = 12;

        }

        private void MostrarTablaCatalogo()
        {
            // Modulo para mostrar el catalogo en el formulario principal del director de escuela
            N_CursoCatalogo oCursoCatalogo = new N_CursoCatalogo();
            dgvCatalogo.DataSource = oCursoCatalogo.ListarCatalogoDA(); //DA: director académico
        }

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
                //Obtener cod curso
                string CodCursoCatalogo = dgvCatalogo.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();

                frmAsignarDocente form = new frmAsignarDocente(CodCursoCatalogo);
                //Recuperar información de la tabla
                form.textBoxCodigo.Text = CodCursoCatalogo;
                form.textBoxCurso.Text = dgvCatalogo.Rows[e.RowIndex].Cells["CURSO"].Value.ToString();
                form.textBoxHT.Text = dgvCatalogo.Rows[e.RowIndex].Cells["HT"].Value.ToString();
                form.textBoxHP.Text = dgvCatalogo.Rows[e.RowIndex].Cells["HP"].Value.ToString();
                form.textBoxCreditos.Text = dgvCatalogo.Rows[e.RowIndex].Cells["CRED"].Value.ToString();
                form.textBoxAula.Text = dgvCatalogo.Rows[e.RowIndex].Cells["AULA"].Value.ToString();
                form.textBoxGrupo.Text = dgvCatalogo.Rows[e.RowIndex].Cells["GRUPO"].Value.ToString();
                form.ShowDialog();
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            //Verificar si existen todos los cursos del catálogo
            int nroRows = dgvCatalogo.Rows.Count;
            bool existeCodCursoCatalogo;
            string codAsignatura, grupo, nombre, codCursoCatalogo;
            N_CursoCatalogo oCursoCatalogo = new N_CursoCatalogo();

            for (int i = 0; i < nroRows; i++)
            {
                codAsignatura = dgvCatalogo.Rows[i].Cells["CODIGO"].Value.ToString();
                grupo = dgvCatalogo.Rows[i].Cells["GRUPO"].Value.ToString();
                nombre = dgvCatalogo.Rows[i].Cells["CURSO"].Value.ToString();
                codCursoCatalogo = $"{codAsignatura}{grupo}IN";
                existeCodCursoCatalogo = oCursoCatalogo.ExisteCursoCatalogo(codCursoCatalogo);
                if (!existeCodCursoCatalogo) //Si no existe
                {
                    MessageBox.Show($"El curso {codCursoCatalogo} - {nombre} no existe. Verifique la información e intente de nuevo.", "Alerta");
                    break;
                }
            }
        }
    }
}
