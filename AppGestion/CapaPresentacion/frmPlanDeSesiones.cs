using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using System.Runtime.InteropServices;
using CapaEntidades;
using Excel;
using System.IO;


namespace CapaPresentacion
{
    
    public partial class frmPlanDeSesiones : Form
    {
        N_PlanSesiones oPlanSesiones = new N_PlanSesiones();
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;
        DataTable tabla = new DataTable();
        private string IDCatalogo;
        DataSet result;


        public frmPlanDeSesiones(string CodCatalogo, string NombreAsignatura, string Grupo)
        {

            InitializeComponent();
            MostrarPlanSesiones(CodCatalogo);
            MostrarNombreAsignatura(NombreAsignatura, Grupo);
            MoverModificarColumnas();
            IDCatalogo = CodCatalogo;
        }

        private void MostrarNombreAsignatura(string nombreAsignatura, string grupo)
        {
            lblNombreAsignatura.Text = nombreAsignatura + " - " + "GRUPO " + grupo;
        }

        private void MoverModificarColumnas()
        {
            dgvPlanSesiones.Columns["Eliminar"].DisplayIndex=8;
            dgvPlanSesiones.Columns["VariacionH"].DisplayIndex = 7;
            dgvPlanSesiones.Columns["Completado"].DisplayIndex = 5;
            dgvPlanSesiones.Columns["Finalizado"].Visible = false;
            dgvPlanSesiones.Columns["VariacionHora"].Visible = false;
        }

        public void MostrarPlanSesiones(string CodCatalogo)
        {
            N_PlanSesiones pvista = new N_PlanSesiones();
            dgvPlanSesiones.DataSource = pvista.ListandoPlanSesiones(CodCatalogo);
            foreach (DataGridViewRow fila in dgvPlanSesiones.Rows)
            {
                if (fila.Cells["Finalizado"].Value.ToString() =="SI")
                {
                    fila.Cells["Completado"].Value = "SI";
                }
                if (fila.Cells["VariacionHora"].Value.ToString() == "+1")
                {
                    fila.Cells["VariacionH"].Value = "+1";
                }
                else if (fila.Cells["VariacionHora"].Value.ToString() == "+2")
                {
                    fila.Cells["VariacionH"].Value = "+2";
                }
                else if (fila.Cells["VariacionHora"].Value.ToString() == "+3")
                {
                    fila.Cells["VariacionH"].Value = "+3";
                }
                else if (fila.Cells["VariacionHora"].Value.ToString() == "+4")
                {
                    fila.Cells["VariacionH"].Value = "+4";
                }
                else if (fila.Cells["VariacionHora"].Value.ToString() == "0")
                {
                    fila.Cells["VariacionH"].Value = "0";
                }
                else if (fila.Cells["VariacionHora"].Value.ToString() == "-1")
                {
                    fila.Cells["VariacionH"].Value = "-1";
                }
                else if (fila.Cells["VariacionHora"].Value.ToString() == "-2")
                {
                    fila.Cells["VariacionH"].Value = "-2";
                }
                else if (fila.Cells["VariacionHora"].Value.ToString() == "-3")
                {
                    fila.Cells["VariacionH"].Value = "-3";
                }
                else if (fila.Cells["VariacionHora"].Value.ToString() == "-4")
                {
                    fila.Cells["VariacionH"].Value = "-4";
                }
                
            }
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
            if (dgvPlanSesiones.Rows[e.RowIndex].Cells["Eliminar"].Selected)
            {
                DialogResult dialogResult = MessageBox.Show("¿Seguro que desea eliminar?", "Alerta", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    tabla = dgvPlanSesiones.DataSource as DataTable;
                    tabla.Rows.RemoveAt(e.RowIndex);
                    dgvPlanSesiones.DataSource = tabla;
                }
            }

            if (dgvPlanSesiones.Rows[e.RowIndex].Cells["Completado"].Selected)
            {
                dgvPlanSesiones.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
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

        private void btnNuevaFila_Click(object sender, EventArgs e)
        {
            int indice = dgvPlanSesiones.CurrentRow.Index;

            //validar seleccion de fila
            if (indice != -1)
            {
                tabla = dgvPlanSesiones.DataSource as DataTable;
                DataRow fila = tabla.NewRow();
                fila["Finalizado"]= "NO";
                //fila["VariacionHora"] = "0";
                tabla.Rows.InsertAt(fila, indice+1);
  
            }
            else
            {
                MessageBox.Show("No se selecciono ninguna fila");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            tabla = dgvPlanSesiones.DataSource as DataTable;
            oPlanSesiones.GuardarPlanSesiones(tabla, IDCatalogo);

            MessageBox.Show("Los cambios se guardaron correctamente");
        }

        private void dgvPlanSesiones_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                if (dgvPlanSesiones.Rows[e.RowIndex].Cells["Completado"].Selected)
                {
                    //ver el valor del checkbox
                    if ((dgvPlanSesiones.Rows[e.RowIndex].Cells["Completado"].Value.ToString()) == "SI")
                    {
                        dgvPlanSesiones.Rows[e.RowIndex].Cells["Finalizado"].Value = "SI";
                    }
                    else
                    {
                        dgvPlanSesiones.Rows[e.RowIndex].Cells["Finalizado"].Value = "NO";
                    }
                }

                //

                if (dgvPlanSesiones.Rows[e.RowIndex].Cells["VariacionH"].Selected)
                {
                    //ver el valor del checkbox
                    if ((dgvPlanSesiones.Rows[e.RowIndex].Cells["VariacionH"].Value.ToString() =="+1"))
                    {
                        dgvPlanSesiones.Rows[e.RowIndex].Cells["VariacionHora"].Value = "+1";
                    }
                    else if ((dgvPlanSesiones.Rows[e.RowIndex].Cells["VariacionH"].Value.ToString() == "+2"))
                    {
                        dgvPlanSesiones.Rows[e.RowIndex].Cells["VariacionHora"].Value = "+2";
                    }
                    else if ((dgvPlanSesiones.Rows[e.RowIndex].Cells["VariacionH"].Value.ToString() == "+3"))
                    {
                        dgvPlanSesiones.Rows[e.RowIndex].Cells["VariacionHora"].Value = "+3";
                    }
                    else if ((dgvPlanSesiones.Rows[e.RowIndex].Cells["VariacionH"].Value.ToString() == "+4"))
                    {
                        dgvPlanSesiones.Rows[e.RowIndex].Cells["VariacionHora"].Value = "+4";
                    }
                    else if ((dgvPlanSesiones.Rows[e.RowIndex].Cells["VariacionH"].Value.ToString() == "0"))
                    {
                        dgvPlanSesiones.Rows[e.RowIndex].Cells["VariacionHora"].Value = "0";
                    }
                    else if ((dgvPlanSesiones.Rows[e.RowIndex].Cells["VariacionH"].Value.ToString() == "-1"))
                    {
                        dgvPlanSesiones.Rows[e.RowIndex].Cells["VariacionHora"].Value = "-1";
                    }
                    else if ((dgvPlanSesiones.Rows[e.RowIndex].Cells["VariacionH"].Value.ToString() == "-2"))
                    {
                        dgvPlanSesiones.Rows[e.RowIndex].Cells["VariacionHora"].Value = "-2";
                    }
                    else if ((dgvPlanSesiones.Rows[e.RowIndex].Cells["VariacionH"].Value.ToString() == "-3"))
                    {
                        dgvPlanSesiones.Rows[e.RowIndex].Cells["VariacionHora"].Value = "-3";
                    }
                    else if ((dgvPlanSesiones.Rows[e.RowIndex].Cells["VariacionH"].Value.ToString() == "-4"))
                    {
                        dgvPlanSesiones.Rows[e.RowIndex].Cells["VariacionHora"].Value = "-4";
                    }
                }
            }
           
        }

        private void frmPlanDeSesiones_Load(object sender, EventArgs e)
        {
            MostrarPlanSesiones(IDCatalogo);
        }


        private void btnImportarDatos_Click(object sender, EventArgs e)
        {
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
                    dgvPlanSesiones.DataSource = result.Tables[0];

                    reader.Close();

                }
            }
        }

    }
}
