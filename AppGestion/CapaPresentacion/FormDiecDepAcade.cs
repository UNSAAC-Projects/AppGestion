using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormDiecDepAcade : Form
    {
        public FormDiecDepAcade()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
            
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
