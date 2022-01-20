using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;
using System.Data;

namespace CapaPresentacion
{
    public partial class frmAsistenciaDiariaDocentes : Form
    {
        FrmLogin L = new FrmLogin();
        E_ListaAsistencias entities = new E_ListaAsistencias();
        N_PlanSesiones oPlanSesiones = new N_PlanSesiones();
        N_AsistenciaDiariaDocentes oADiariaDocentes = new N_AsistenciaDiariaDocentes();

        public string CodAsignatura;

        public frmAsistenciaDiariaDocentes()
        {
            InitializeComponent();
        }

        private void frmAsistencia_Load(object sender, EventArgs e)
        {
            // Mostrar los docentes activos en el semestre actual
            MostrarDocentesActivos();
            // Ocultar columna Asistio
            dgvAsistencia.Columns["Asistio"].Visible = false;
            //Mostrar nro de docentes
            labelNroDocentes.Text = dgvAsistencia.Rows.Count.ToString();
            //Mostrar hora  y fecha 
            MostrarHoraFecha();
            //Contar asistentes y faltantes
            ContarAsistencia();
        }
        private void MostrarDocentesActivos()
        {
            N_AsistenciaDiariaDocentes oADiariaDocentes = new N_AsistenciaDiariaDocentes();
            //string fecha = DateTime.Now.ToString("dd-MM-yyyy");
            DateTime fecha = DateTime.Now;
            string semestreLectivo = "2021-II"; //Falta detectar automáticamente
            dgvAsistencia.DataSource = oADiariaDocentes.ListarDocentesActivos(semestreLectivo, fecha);
            foreach (DataGridViewRow row in dgvAsistencia.Rows)
            {
                // Obtener valor de la columna Asistio
                string value = Convert.ToString(row.Cells["Asistio"].Value);
                // Marcar o descarmar combobox de acuardo al valor de value
                if (value == "") row.Cells["Asistencia"].Value = "F";
                else if (value == "F") row.Cells["Asistencia"].Value = "F";
                else if (value == "P") row.Cells["Asistencia"].Value = "P";
            }
        }
        public void ContarAsistencia()
        {
            int contador = 0;
            foreach (DataGridViewRow fila in dgvAsistencia .Rows)
            {
                if (fila.Cells["Asistencia"].Value.ToString() == "P")
                {
                    contador = contador + 1;
                }
            }
            
            lblAsistio.Text = contador.ToString();
            long nro =UInt32.Parse(labelNroDocentes.Text) - contador;
            lblFaltaron.Text = nro.ToString();
        }

        public void MostrarHoraFecha()
        {
            string fecha, hora;
            //Recuperar hora y fecha del sistema
            fecha = DateTime.Now.ToString("dd/MM/yyyy");
            hora = DateTime.Now.ToString("hh:mm tt");
            //Mostrar fecha y hora en los labels
            labelFecha.Text = fecha;
            labelHora.Text = hora;
        }

        public bool  GuardarDatos()
        {
            //Recuperar tabla
            DataTable tabla = dgvAsistencia.DataSource as DataTable;
            //Obtener fecha en formato mes-dia-año
            string fecha = DateTime.Now.ToString("MM-dd-yyyy");
            //Guardar asistencias
            oADiariaDocentes.GuardarAsistenciasDiarias(tabla, fecha);
            return true;
        }
        private void buttonGUARDAR_Click(object sender, EventArgs e)
        {
            if (GuardarDatos())
            {
                MessageBox.Show("Guardado exitosamente...");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al guardar...");
            }
        }

        private void buttonMARCAR_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAsistencia.Rows)
            {
                row.Cells["Asistencia"].Value = "P";
               
            }
            ContarAsistencia();
        }

        private void buttonDESMARCAR_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAsistencia.Rows)
            {
                row.Cells["Asistencia"].Value = "F";
            }
            ContarAsistencia();
        }

        private void dgvAsistencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ContarAsistencia();

            if (dgvAsistencia.Rows[e.RowIndex].Cells["Asistencia"].Selected)
            {
                dgvAsistencia.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        //Movimiento panel
        int posY = 0;
        int posX = 0;
        private void pnlAsistencia_MouseMove(object sender, MouseEventArgs e)
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

        private void dgvAsistencia_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvAsistencia.Rows[e.RowIndex].Cells["Asistencia"].Selected)
                {
                    //ver el valor del checkbox
                    string valorAsistencia = dgvAsistencia.Rows[e.RowIndex].Cells["Asistencia"].Value.ToString();
                    if (valorAsistencia == "P")
                    {
                        dgvAsistencia.Rows[e.RowIndex].Cells["Asistio"].Value = "P";
                    }
                    else
                    {
                        dgvAsistencia.Rows[e.RowIndex].Cells["Asistio"].Value = "F";
                    }
                }
            }
        }

        private void pnlAsistencia_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
