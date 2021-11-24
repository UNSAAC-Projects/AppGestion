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

namespace CapaPresentacion
{
    public partial class FormDirecDepAcade : Form
    {
        public FormDirecDepAcade()
        {
            InitializeComponent();
        }
        DataView ImportarDatos(string nombrearchivo)
        {
            string conexion = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;DataSource={0}; Extended Properties'Excel 12.0;'", nombrearchivo);
            OleDbConnection conector = default (OleDbConnection);
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonIMPORTAR.BackColor = Color.FromArgb(12, 61,92);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonLISTAR.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void FormDiecDepAcade_Load(object sender, EventArgs e)
        {

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
                dataGridViewIMPORTAR.DataSource = ImportarDatos(openFileDialog.FileName);
            }

        }

        private void labelLAURO_Click(object sender, EventArgs e)
        {

        }

        private void buttonDESCARGAR_Click(object sender, EventArgs e)
        {

        }

        private void buttonIMPRIMIR_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewIMPORTAR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
         
        }

        private void btnMINIMIZAR_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
