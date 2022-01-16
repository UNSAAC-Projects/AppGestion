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
            //Obtener codigo (ex: IF324)
            string codGrupoAsignatura = cboAsistenciaCurso.SelectedItem.ToString().Substring(0,6);
            //Obtener IdCatalogo
            string idCatalogo = oCursosDocente.ObtenerCodCatalogo(codGrupoAsignatura);
            //Mostrar asistencias
            dgvAsistenciaReporte.DataSource = oListaAsistencias.ListarAsitenciaCurso(idCatalogo);
        }
        private void FrmReporteAsistencia_Load(object sender, EventArgs e)
        {
            //Mostrar items del combobox
            MostrarItemsComboBox();   
            //Mostrar lista de asistencias
            MostrarListaAsistencias();
            //Mover columna
            dgvAsistenciaReporte.Columns["Asistencia"].DisplayIndex = 3;
            //Ocultar columna
            dgvAsistenciaReporte.Columns["IdCatalogo"].Visible = false;
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
            if (e.RowIndex >= 0) //Si no se hizo click en el encabezado
            {
                DataGridViewRow row = dgvAsistenciaReporte.Rows[e.RowIndex];
                if (row.Cells["Asistencia"].Selected)
                {
                    N_CursoCatalogo oCursoCatalogo = new N_CursoCatalogo();
                    //Obtener cod curso y luego codcatalogo
                    //string codAsignatura = row.Cells["CODIGO"].Value.ToString();
                    //string NombreCurso = row.Cells["NOMBRE"].Value.ToString();
                    //string Grupo = row.Cells["GRUPO"].Value.ToString();
                    //string codCatalogo = oDocente.ObtenerCodCatalogo(codAsignatura);
                    // hasta aqui esta bien 
                    //Obtener IdCatalogo
                    string idCatalogo = row.Cells["IdCatalogo"].Value.ToString();
                    string nombreCurso = cboAsistenciaCurso.SelectedItem.ToString();
                    string strFecha = row.Cells["Fecha"].Value.ToString();
                    DateTime fecha = DateTime.Parse(strFecha);
                    frmAsistencia frm = new frmAsistencia(idCatalogo, nombreCurso, fecha);
                    frm.ShowDialog();
                }
            }
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
