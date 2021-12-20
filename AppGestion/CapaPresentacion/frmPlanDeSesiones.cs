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
using System.Runtime.InteropServices;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class frmPlanDeSesiones : Form
    {
        N_PlanSesiones oPlanSesiones = new N_PlanSesiones();
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;

        public frmPlanDeSesiones(string CodCatalogo, string NombreAsignatura, string Grupo)
        {
            InitializeComponent();
            MostrarPlanSesiones(CodCatalogo);
            MostrarNombreAsignatura(NombreAsignatura, Grupo);
            MoverModificarColumnas();
        }

        private void MostrarNombreAsignatura(string nombreAsignatura, string grupo)
        {
            lblNombreAsignatura.Text = nombreAsignatura + " - " + "GRUPO " + grupo;
        }

        private void MoverModificarColumnas()
        {
            dgvPlanSesiones.Columns["Eliminar"].DisplayIndex=6;
            dgvPlanSesiones.Columns["Observacion"].DisplayIndex = 5;
            dgvPlanSesiones.Columns["Completado"].DisplayIndex = 4;
        }

        public void MostrarPlanSesiones(string CodCatalogo)
        {
            N_PlanSesiones pvista = new N_PlanSesiones();
            dgvPlanSesiones.DataSource = pvista.ListandoPlanSesiones(CodCatalogo);
        }

        private void btnClosePlanSesiones_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinPlanSesiones_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void dgvPlanSesiones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvPlanSesiones.Rows[e.RowIndex].Cells["Eliminar"].Selected)
            //{
            //    DialogResult dialogResult = MessageBox.Show("¿Seguro que desea eliminar?", "Alerta", MessageBoxButtons.YesNo);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        dgvPlanSesiones.Rows.RemoveAt(e.RowIndex) ;


            //    }
            //}
        }

        private void dgvPlanSesiones_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                    !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {

                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = dgvPlanSesiones.DoDragDrop(
                    dgvPlanSesiones.Rows[rowIndexFromMouseDown],
                    DragDropEffects.Move);
                }
            }

        }

        private void dgvPlanSesiones_MouseDown(object sender, MouseEventArgs e)
        {
            // Get the index of the item the mouse is below.
            rowIndexFromMouseDown = dgvPlanSesiones.HitTest(e.X, e.Y).RowIndex;
            if (rowIndexFromMouseDown != -1)
            {
                // Remember the point where the mouse down occurred. 
                // The DragSize indicates the size that the mouse can move 
                // before a drag event should be started.                
                Size dragSize = SystemInformation.DragSize;

                // Create a rectangle using the DragSize, with the mouse position being
                // at the center of the rectangle.
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                                                               e.Y - (dragSize.Height / 2)),
                                    dragSize);
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;

        }

        private void dgvPlanSesiones_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;

        }

        private void dgvPlanSesiones_DragDrop(object sender, DragEventArgs e)
        {
            // The mouse locations are relative to the screen, so they must be 
            // converted to client coordinates.
            Point clientPoint = dgvPlanSesiones.PointToClient(new Point(e.X, e.Y));

            // Get the row index of the item the mouse is below. 
            rowIndexOfItemUnderMouseToDrop =
                dgvPlanSesiones.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            // If the drag operation was a move then remove and insert the row.
            if (e.Effect == DragDropEffects.Move)
            {
                DataGridViewRow rowToMove = e.Data.GetData(
                    typeof(DataGridViewRow)) as DataGridViewRow;
                dgvPlanSesiones.Rows.RemoveAt(rowIndexFromMouseDown);
                dgvPlanSesiones.Rows.Insert(rowIndexOfItemUnderMouseToDrop, rowToMove);

            }

        }

        private void dgvPlanSesiones_DoubleClick(object sender, EventArgs e)
        {

        }

        private void pnlPlanDeSeciones_Paint(object sender, PaintEventArgs e)
        {

        }
        //Movimiento panel
        int posY = 0;
        int posX = 0;
        private void pnlPlanDeSeciones_MouseMove(object sender, MouseEventArgs e)
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
