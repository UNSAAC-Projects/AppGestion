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
            
            dgvAsistencia.Columns["NRO"].DisplayIndex = 0;
            dgvAsistencia.Columns["ALUMNO"].DisplayIndex = 1;
            dgvAsistencia.Columns["APELLIDOS Y NOMBRES"].DisplayIndex = 2;
            dgvAsistencia.Columns["A"].DisplayIndex = 3;
            
            dgvAsistencia.Columns[0].Width = 40;
            dgvAsistencia.Columns[1].Width = 60;
            dgvAsistencia.Columns[2].Width = 60;
            dgvAsistencia.Columns[3].Width = 160;
            dgvAsistencia.Columns[4].Visible=false ;
            dgvAsistencia.Columns[5].Visible=true;
            dgvAsistencia.Columns[6].Visible = false;
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
    }
}
