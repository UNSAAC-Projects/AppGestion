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
        public void ImprimirHoraFecha()
        {
            string datetime = DateTime.Now.ToString("dd / MM / yyyy" +"   "+ "hh:mm:ss tt");
            lblFecha.Text = datetime;
            lblDocente.Text = datos.NombreDocente;

           
        }
        public void ExportarDatos(DataGridView datalistado)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application(); // Instancia a la libreria de Microsoft Office
            excel.Application.Workbooks.Add(true); //Con esto añadimos una hoja en el Excel para exportar los archivos
            int IndiceColumna = 0;
            foreach (DataGridViewColumn columna in datalistado.Columns) //Aquí empezamos a leer las columnas del listado a exportar
            {
                IndiceColumna++;
                excel.Cells[1, IndiceColumna] = columna.Name;
            }
            int IndiceFila = 0;
            foreach (DataGridViewRow fila in datalistado.Rows) //Aquí leemos las filas de las columnas leídas
            {
                IndiceFila++;
                IndiceColumna = 0;
                foreach (DataGridViewColumn columna in datalistado.Columns)
                {
                    IndiceColumna++;
                    excel.Cells[IndiceFila + 1, IndiceColumna] = fila.Cells[columna.Name].Value;
                }
            }
            excel.Visible = true;
        }
        private void buttonGUARDAR_Click(object sender, EventArgs e)
        {
            ExportarDatos(dgvAsistencia);
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
    }
}
