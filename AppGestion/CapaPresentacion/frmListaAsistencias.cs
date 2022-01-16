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
    public partial class frmListaAsistencias : Form
    {
        //Variables de solo lectura
        readonly N_ListaAsistencias oListaAsistencias = new N_ListaAsistencias();
        readonly N_CursosDocente oCursosDocente = new N_CursosDocente();

        public frmListaAsistencias()
        {
            InitializeComponent();
        }
             
        public void MostrarListaAsistencias()
        {
            string idCatalogo = cboAsistenciaCurso.SelectedItem.ToString();//(CORREGIR)
            dgvAsistenciaReporte.DataSource = oListaAsistencias.ListarAsitenciaCurso(idCatalogo);
        }
        private void FrmReporteAsistencia_Load(object sender, EventArgs e)
        {
            MostrarItemsComboBox();   
            MostrarListaAsistencias();
        }
        void MostrarItemsComboBox()
        {
            DataTable dt = oCursosDocente.ListarCursosDocente(datos.CodDocente);
            int n = dt.Rows.Count;
            string grupoAsignatura, nombreAsignatura;
            
            //Recorrer filas del DataTable
            foreach (DataRow row in dt.Rows)
            {
                grupoAsignatura = row[0].ToString(); //GrupoAsignatura (ex: IF342)
                nombreAsignatura = row[1].ToString(); //Nombre de la asignatura
                cboAsistenciaCurso.Items.Add($"{grupoAsignatura} - {nombreAsignatura}");
            }
            //Seleccionar valor por defecto del combobox
            cboAsistenciaCurso.SelectedIndex = 0;
        }

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
            MostrarListaAsistencias();        
        }

        private void btnMinimizarFrmReporte_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCancelarFrmReporte_Click(object sender, EventArgs e)
        {
            Close();
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
