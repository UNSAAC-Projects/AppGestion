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
using ceTe.DynamicPDF.Viewer;

namespace CapaPresentacion
{
    public partial class frmVistaCursosDocente : Form
    {
        N_Silabo oSilabo = new N_Silabo();
        N_CursosDocente ocursosDocente = new N_CursosDocente();
        public frmVistaCursosDocente(string CodDocente)
        {
            InitializeComponent();
            MostrarCursosDocente(CodDocente);
        }
        public void MostrarCursosDocente(string codDocente)
        {
            N_CursosDocente ovista = new N_CursosDocente();
            dgvCursosDocente.DataSource = ovista.ListandoCursosDocente(codDocente);
        }

        private void btnMinCursosDocente_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnCloseCursosDocente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVistaCursosDocente_Load(object sender, EventArgs e)
        {

        }

        private void dgvCursosDocente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvCursosDocente.Rows[e.RowIndex];
            if (row.Cells["PlanSesiones"].Selected)
            {
                //Obtener cod curso
                string CodGrupoAsignatura = row.Cells["GrupoAsignatura"].Value.ToString();
                string CodCatalogo  = ocursosDocente.ObtenerCodCatalogo(CodGrupoAsignatura) ;
                string NombreAsignatura = row.Cells["Nombre"].Value.ToString();
                string Grupo = row.Cells["Grupo"].Value.ToString();
                frmPlanDeSesiones form = new frmPlanDeSesiones(CodCatalogo, NombreAsignatura, Grupo);
                
                form.ShowDialog();
            }
            if (row.Cells["SubirSilabo"].Selected)
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "|*.pdf", ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        //FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                        string Ruta = @"C:\Users\avill\Downloads\Workbook - Unit 7.pdf";
                        string CodGrupoAsignatura = row.Cells["GrupoAsignatura"].Value.ToString();
                        string CodCatalogo = ocursosDocente.ObtenerCodCatalogo(CodGrupoAsignatura);
                        oSilabo.SubirSilabo(Ruta,CodCatalogo);
                        MessageBox.Show("Se subio Correctamente el archivo");

                    }
                }
            }
            if (row.Cells["VerSilabo"].Selected)
            {
                string CodGrupoAsignatura = row.Cells["GrupoAsignatura"].Value.ToString();
                string CodCatalogo = ocursosDocente.ObtenerCodCatalogo(CodGrupoAsignatura);
                byte[] bytesSilabo= oSilabo.ObtenerBytesSilabo(CodCatalogo);
                PdfViewer pdfViewer = new PdfViewer();

                PdfDocument pdfDocument = new PdfDocument(bytesSilabo);
                pdfViewer.Open(pdfDocument);

            }
        }
    }
}
