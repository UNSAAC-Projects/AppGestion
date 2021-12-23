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
using System.Diagnostics;

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

        public string ObtenerRutaProyecto()
        {//Método para obtener la ruta del proyecto
            string rutaProyecto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
            return rutaProyecto;
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
            else if (row.Cells["SubirSilabo"].Selected)
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "|*.pdf", ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string Ruta = ofd.FileName; //Obtener ruta del archivo
                        string CodGrupoAsignatura = row.Cells["GrupoAsignatura"].Value.ToString();
                        string CodCatalogo = ocursosDocente.ObtenerCodCatalogo(CodGrupoAsignatura);
                        //Verificar si existe ya un silabo
                        if (oSilabo.ExisteSilabo(CodCatalogo)) //Si existe
                        {
                            //Actualizar contenido del silabo
                            oSilabo.ActualizarSilabo(Ruta, CodCatalogo);
                        }
                        else //Si no existe
                        {
                            oSilabo.SubirSilabo(Ruta, CodCatalogo); //Subir silabo
                        }
                        MessageBox.Show("Se subio correctamente el silabo");
                    }
                }
            }
            else if (row.Cells["VerSilabo"].Selected)
            {
                string CodGrupoAsignatura = row.Cells["GrupoAsignatura"].Value.ToString();
                string CodCatalogo = ocursosDocente.ObtenerCodCatalogo(CodGrupoAsignatura);
                byte[] bytesSilabo= oSilabo.ObtenerBytesSilabo(CodCatalogo);
                if(bytesSilabo != null) //Si existe silabo
                {
                    string NombrePDF = "Silabo";
                    //Crear ruta temporal del pdf
                    string rutaPDF = $"{ObtenerRutaProyecto()}\\tempFiles\\{NombrePDF}.pdf";
                    //Crear pdf en la carpeta temporal
                    File.WriteAllBytes(rutaPDF, bytesSilabo);
                    //Abrir pdf
                    ProcessStartInfo startInfo = new ProcessStartInfo(rutaPDF);
                    Process.Start(startInfo);
                }
                else //Si no existe silabo
                {
                    MessageBox.Show("No existe silabo", "Advertencia"); //Mostrar mensaje
                }
            }
        }

        private void pnlVistaCursosAsig_Paint(object sender, PaintEventArgs e)
        {

        }

        //Movimiento panel
        int posY = 0;
        int posX = 0;
        private void pnlVistaCursosAsig_MouseMove(object sender, MouseEventArgs e)
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

        private void frmVistaCursosDocente_Load(object sender, EventArgs e)
        {

        }
    }
}
