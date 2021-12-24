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

using Excel;
using System.IO;


namespace CapaPresentacion
{
    public partial class FrmReporteAsistencia : Form
    {
        public FrmReporteAsistencia()
        {
            InitializeComponent();
        }
        N_Asistencia A = new N_Asistencia();
        //frmAsistencia oAsistencia = new frmAsistencia();
        N_CursosDocente D = new N_CursosDocente();
        E_Asistencia Asis = new E_Asistencia();
       
        public void listar_asistencias()
        {
            

            dgvAsistenciaReporte.DataSource = A.listarAsitenciaCurso(cboAsistenciaCurso.SelectedItem.ToString());
            dgvAsistenciaReporte.Columns[5].Visible = false;
            dgvAsistenciaReporte.Columns[6].Visible = false;
            dgvAsistenciaReporte.Columns["ASISTENCIA"].DisplayIndex = 4;
        }
        private void FrmReporteAsistencia_Load(object sender, EventArgs e)
        {
            
            CargarCombo();
            
            listar_asistencias();
        }
        void CargarCombo()
        {
            DataTable dt = new DataTable();
            dt = D.ListandoCursosDocente(datos.CodDocente);
            int n = dt.Rows.Count;
            int i = 0;
            while (i < n)
            {
                cboAsistenciaCurso.Items.Add(dt.Rows[i][1].ToString());
                i = i + 1;
            }
            cboAsistenciaCurso.SelectedIndex = 0;
            

        }
        DataSet result;
        private void dgvAsistenciaReporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow row = dgvAsistenciaReporte.Rows[e.RowIndex];
            //if (row.Cells["ASISTENCIA"].Selected)
            //{
            //    //oAsistencia.ShowDialog();

            //  //  DataTable tabla = new DataTable();


            //    //recuperar la ruta del archivo excel
            //   // tabla = oDocente.MostrarArchivos(codCatalogo);
            //   // string ruta = tabla.Rows[0][0].ToString();
            //    //string contenido = tabla.Rows[0][1].ToString();

            //    FileStream fs = File.Open(@"D:\8vosemestre\Ing.Software\proyecto\ListaAlumnosDia\FUNDAMENTOS DE PROGRAMACION22122021.xlsx", FileMode.Open, FileAccess.Read);
            //    IExcelDataReader reader;
            //    reader = ExcelReaderFactory.CreateBinaryReader(fs);

            //    frmAsistencia form = new frmAsistencia();
            //    reader.IsFirstRowAsColumnNames = true;
            //    result = reader.AsDataSet();
            //    form.dgvAsistencia.DataSource = result.Tables[0];
            //    reader.Close();
            //    form.ShowDialog();
            //}
        }

        private void cboAsistenciaCurso_Click(object sender, EventArgs e)
        {
            
        }

        private void cboAsistenciaCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            listar_asistencias();        
        }

        private void btnMinimizarFrmReporte_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCancelarFrmReporte_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Movimiento panel
        int posY = 0;
        int posX = 0;
        private void pnlFrmReporteAsistencia_MouseMove(object sender, MouseEventArgs e)
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
    }
}
