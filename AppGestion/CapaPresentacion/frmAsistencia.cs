using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SpreadsheetLight;

namespace CapaPresentacion
{
    public partial class frmAsistencia : Form
    {
        FrmLogin L = new FrmLogin();
        public frmAsistencia()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnMINIMIZAR_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAsistencia_Load(object sender, EventArgs e)
        {
            dgvAsistencia.Columns["Observacion"].DisplayIndex = 3;
            dgvAsistencia.Columns["ALUMNO"].DisplayIndex = 1;
            dgvAsistencia.Columns["APELLIDOS Y NOMBRES"].DisplayIndex = 2;
            //dgvAsistencia.Columns["ALUMNO"].DisplayIndex = 2;
            //dgvAsistencia.Columns["APELLIDOS Y NOMBRES"].DisplayIndex = 3;
            //dgvAsistencia.Columns["A"].DisplayIndex = 4;
            
            //dgvAsistencia.Columns[0].Width = 40;
              dgvAsistencia.Columns[3].Width = 68;
              dgvAsistencia.Columns[4].Width = 260;
              dgvAsistencia.Columns.Remove("1");
              dgvAsistencia.Columns.Remove("2");
              dgvAsistencia.Columns.Remove("3");
              dgvAsistencia.Columns.Remove("4");
              dgvAsistencia.Columns.Remove("5");
              dgvAsistencia.Columns.Remove("Obs");
              dgvAsistencia.Columns.Remove("Column9");
              dgvAsistencia.Columns.Remove("NRO");



            ImprimirHoraFecha();

            

        }
        string datetime;
        string fecha;
        public void ImprimirHoraFecha()
        {
            datetime = DateTime.Now.ToString("dd / MM / yyyy" +"   "+ "hh:mm:ss tt");

            lblFecha.Text = datetime;
            lblDocente.Text = datos.NombreDocente;

           
        }
        bool  ExportarDatos(DataGridView datalistado)
        {
            //concatenar con el nombre del tema.
            
            var DateAndTime = DateTime.Now;
            string Date = DateTime.Now.ToString("ddMMyyyy");

            string name = datos.NombreCurso + Date;


            string ruta = @"D:\8vosemestre\Ing.Software\proyecto\ListaAlumnosDia\"+name+".xlsx";
            SLDocument osLDocument = new SLDocument();
            System.Data.DataTable dt = new System.Data.DataTable();
            //registrar columnas
            dt.Columns.Add("ASISTENCIA",typeof(string));
            dt.Columns.Add("ALUMNOS", typeof(string));
            dt.Columns.Add("APELLIDOS Y NOMBRES", typeof(string));
            dt.Columns.Add("OBSERVACION", typeof(string));
            //registrar filas
            foreach (DataGridViewRow row in dgvAsistencia.Rows)
            {

                string asistencia = Convert.ToString(row.Cells["Asistencia"].Value);
                string alumnos = Convert.ToString(row.Cells["ALUMNO"].Value);
                string apellidos = Convert.ToString(row.Cells["APELLIDOS Y NOMBRES"].Value);
                string observacion = Convert.ToString(row.Cells["Observacion"].Value);
                dt.Rows.Add(asistencia, alumnos, apellidos, observacion);
            }

            osLDocument.ImportDataTable(1,1,dt,true);
            osLDocument.SaveAs(ruta);
            return true;

        }
        private void buttonGUARDAR_Click(object sender, EventArgs e)
        {
            if (ExportarDatos(dgvAsistencia))
            {
                MessageBox.Show("Guardado exitosamente...");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al guardar...");
            }

        }

        private void dgvAsistencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonMARCAR_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAsistencia.Rows)
            {

                row.Cells["Asistencia"].Value = true;
                
            }
        }

        private void buttonDESMARCAR_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAsistencia.Rows)
            {

                row.Cells["Asistencia"].Value = false;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void labelLISTADOCENTE_Click(object sender, EventArgs e)
        {

        }
        //Movimiento panel
        int posY = 0;
        int posX = 0;
        private void pnlAsistencia_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void textBoxTEMA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
