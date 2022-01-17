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
            string codGrupoAsignatura = cboAsistenciaCurso.Text.Substring(0,6);
            //Obtener IdCatalogo
            string idCatalogo = oCursosDocente.ObtenerCodCatalogo(codGrupoAsignatura);
            //Mostrar asistencias
            dgvAsistenciaReporte.DataSource = oListaAsistencias.ListarAsitenciaCurso(idCatalogo);
 
        }
        private void FrmReporteAsistencia_Load(object sender, EventArgs e)
        {
            //Recuperar cursos docente
            DataTable tablaCursos = oCursosDocente.ListarCursosDocente(datos.CodDocente);
            if(tablaCursos != null)//Si el docente dicta cursos
            {
                //Mostrar items del combobox
                MostrarItemsComboBox(tablaCursos);
                //Mostrar lista de asistencias
                MostrarListaAsistencias();
                //Mover columna
                dgvAsistenciaReporte.Columns["Asistencia"].DisplayIndex = 3;
                //Ocultar columna
                dgvAsistenciaReporte.Columns["IdCatalogo"].Visible = false;
            }
           
        }
        void MostrarItemsComboBox(DataTable tablaCursos)
        {
            int n = tablaCursos.Rows.Count;
            string grupoAsignatura, nombreAsignatura;

            //Recorrer filas del DataTable
            foreach (DataRow row in tablaCursos.Rows)
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
                    //Recuperar información
                    string idCatalogo = row.Cells["IdCatalogo"].Value.ToString();
                    string nombreCurso = cboAsistenciaCurso.SelectedItem.ToString();
                    string strFecha = row.Cells["Fecha"].Value.ToString();
                    DateTime fecha = DateTime.Parse(strFecha);
                    frmAsistencia frm = new frmAsistencia(idCatalogo, nombreCurso, fecha);
                    frm.ShowDialog();
                    //Actualizar lista de asistencias
                    MostrarListaAsistencias();
                }
            }
        }

        private void cboAsistenciaCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Mostrar asistencias para el nuevo curso seleccionado
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

        private void dgvAsistenciaReporte_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {//Evento para mostrar numeración en el encabezado de la fila

            var grid = sender as DataGridView; //dgv
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                //Alineación de la numeración
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
    }
}
