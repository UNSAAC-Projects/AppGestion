using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using CapaNegocio;
using Excel;
using CapaEntidades;
using System.IO;
using CapaPresentacion.FormsDirDep;

namespace CapaPresentacion
{
    public partial class frmDirecDepAcade : Form
    {
        //Declaracion variables
        DataSet result;
        N_Login oLogin = new N_Login();

        private bool OpcionCatalogo;
        private bool OpcionLISTAR;
        private bool OpcionDISTRIBUCION;

        //Constructor
        public frmDirecDepAcade(string CodDocente)
        {
            InitializeComponent();
            MostrarNombreUsuario(CodDocente);
        }
        //Pantalla Completa
        public void PantallaOk()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        private void MostrarNombreUsuario(string codDocente)
        {
            labelNombre.Text = oLogin.ObtenerNombreUsuario(codDocente);
        }

        #region Módulos



        public void ExportarDatos(DataGridView listadoCatalogo)
        {
            Microsoft.Office.Interop.Excel.Application exportarCatalogo = new Microsoft.Office.Interop.Excel.Application();
            exportarCatalogo.Application.Workbooks.Add(true);
            int indexColumn = 0;
            foreach (DataGridViewColumn columna in listadoCatalogo.Columns)
            {
                if (columna.Name != "EDITAR")
                {
                    indexColumn++;
                    exportarCatalogo.Cells[1, indexColumn] = columna.Name;
                }
            }
            int indexfila = 0;
            foreach (DataGridViewRow fila in listadoCatalogo.Rows)
            {
                indexfila++;
                indexColumn = 0;
                foreach (DataGridViewColumn columna in listadoCatalogo.Columns)
                {
                    if (columna.Name != "EDITAR")
                    {
                        indexColumn++;
                        exportarCatalogo.Cells[indexfila + 1, indexColumn] = fila.Cells[columna.Name].Value;
                    }
                }
            }
            exportarCatalogo.Visible = true;
        }

        DataView ImportarDatos(string nombrearchivo)
        {
            string conexion = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}; Extended Properties'Excel 12.0;'",nombrearchivo);
           
            OleDbConnection conector = new OleDbConnection(conexion);
            conector.Open();


            OleDbCommand consulta = new OleDbCommand("select *  from [Hoja1$]", conector);
            OleDbDataAdapter adaptador = new OleDbDataAdapter
            {
                SelectCommand = consulta
            };
            

            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            conector.Close();
            return ds.Tables[0].DefaultView;
        }
        #endregion

        #region Eventos
        private void buttonDISTRIBUCION_Click(object sender, EventArgs e)
        {
            //buttonIMPORTAR.BackColor = Color.FromArgb(12, 61, 92);
            AbrirFormulariosEnPanelContenedor(new frmDistDocentes());
            //frmDistDocentes c = new frmDistDocentes();
            //c.Show();
            //
            OpcionCatalogo = false;
            OpcionLISTAR = false;
            OpcionDISTRIBUCION = true;

            //Restaurar backcolors
            btnCatalogo.BackColor = Color.FromArgb(33, 47, 60);
            buttonLISTAR.BackColor = Color.FromArgb(33, 47, 60);
            buttonDISTRIBUCION.BackColor = Color.WhiteSmoke;

            //Restaurar forecolors
            btnCatalogo.ForeColor = Color.FromArgb(212, 172, 13);
            buttonLISTAR.ForeColor = Color.FromArgb(212, 172, 13);
            buttonDISTRIBUCION.ForeColor = Color.FromArgb(33, 47, 60);
        }

        private void buttonLISTAR_Click(object sender, EventArgs e)
        {
           // buttonIMPORTAR.BackColor = Color.FromArgb(12, 61, 92);
            AbrirFormulariosEnPanelContenedor(new frmAsistenciaDiariaDocentes());
            //frmListaDocentes p = new frmListaDocentes();
            //p.Show();
            //
            OpcionCatalogo = false;
            OpcionLISTAR = true;
            OpcionDISTRIBUCION = false;

            //Restaurar backcolors
            btnCatalogo.BackColor = Color.FromArgb(33, 47, 60);
            buttonLISTAR.BackColor = Color.WhiteSmoke;
            buttonDISTRIBUCION.BackColor = Color.FromArgb(33, 47, 60);

            //Restaurar forecolors
            btnCatalogo.ForeColor = Color.FromArgb(212, 172, 13);
            buttonLISTAR.ForeColor = Color.FromArgb(33, 47, 60);
            buttonDISTRIBUCION.ForeColor = Color.FromArgb(212, 172, 13);
        }

        
        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();        
        }

        private void btnMINIMIZAR_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxMaxRest_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
        #endregion

        private Form formActivado = null;
        private void AbrirFormulariosEnPanelContenedor(Form FormHijo)
        {
            if (formActivado != null)
                formActivado.Close();
            formActivado = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.Dock = DockStyle.Fill;
            panelContenedor3.Controls.Add(FormHijo);
            panelContenedor3.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();

        }

        private void frmDirecDepAcade_Load(object sender, EventArgs e)
        {
            PantallaOk();
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            AbrirFormulariosEnPanelContenedor(new FrmPrincipalDirecAcademico());
            //
            OpcionCatalogo = true;
            OpcionLISTAR = false;
            OpcionDISTRIBUCION = false;

            //Restaurar backcolors
            btnCatalogo.BackColor = Color.WhiteSmoke;
            buttonLISTAR.BackColor = Color.FromArgb(33, 47, 60);
            buttonDISTRIBUCION.BackColor = Color.FromArgb(33, 47, 60);

            //Restaurar forecolors
            btnCatalogo.ForeColor = Color.FromArgb(33, 47, 60);
            buttonLISTAR.ForeColor = Color.FromArgb(212, 172, 13);
            buttonDISTRIBUCION.ForeColor = Color.FromArgb(212, 172, 13);
        }
        //mostrar Hora y Fecha
        private void timerHoraFecha_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
            labelFecha.Text = DateTime.Now.ToString("dddd mmmm, yyyy");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de que quieres cerrar Sesion?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void buttonReporteAsistenciaDocentes_Click(object sender, EventArgs e)
        {
            AbrirFormulariosEnPanelContenedor(new frmReporteAsistenciaDocente());
        }

        private void btnReporteDetalladoA_Click(object sender, EventArgs e)
        {
            AbrirFormulariosEnPanelContenedor(new frmDirecListaAsignaturas());
            //
           
        }

        private void panelContenedor3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
               
        }

        private void btnReporteDocenteAvance_Click(object sender, EventArgs e)
        {
            //FrmReporteAvanceDocentesDepartamento O = new FrmReporteAvanceDocentesDepartamento();
            //O.ShowDialog();
            AbrirFormulariosEnPanelContenedor(new FrmReporteAvanceDocentesDepartamento());
        }

        private void btnReporteEstadoDocentes_Click(object sender, EventArgs e)
        {
            AbrirFormulariosEnPanelContenedor(new frmReporteEstadoDocentes());
        }


        /* private void buttonIMPORTAR_Click(object sender, EventArgs e)
         {


             buttonIMPORTAR.BackColor = Color.FromArgb(12, 61, 92);
             using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook 97-2003|*.xls|Excel Workbook|*.xlsx", ValidateNames = true })
             {
                 if (ofd.ShowDialog() == DialogResult.OK)
                 {
                     FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                     IExcelDataReader reader;
                     if (ofd.FilterIndex == 1)
                     {
                         reader = ExcelReaderFactory.CreateBinaryReader(fs);
                     }
                     else
                     {
                         reader = ExcelReaderFactory.CreateOpenXmlReader(fs);
                     }
                     reader.IsFirstRowAsColumnNames = true;
                     result = reader.AsDataSet();
                     //dgvCatalogo.DataSource = result.Tables[0];
                     reader.Close();



                 }
             }
         }*/
    }
}
