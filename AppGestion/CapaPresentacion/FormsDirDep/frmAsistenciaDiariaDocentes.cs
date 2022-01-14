using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SpreadsheetLight;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmAsistenciaDiariaDocentes : Form
    {
        FrmLogin L = new FrmLogin();
        E_Asistencia entities = new E_Asistencia();
        N_PlanSesiones oPlanSesiones = new N_PlanSesiones();

        public string CodAsignatura;
        int indexTema; //Indice del siguiente tema a dictar

        public frmAsistenciaDiariaDocentes()
        {
            InitializeComponent();
        }

        private void btnMINIMIZAR_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAsistencia_Load(object sender, EventArgs e)
        {
            // Mostrar los docentes activos en el semestre actual
            MostrarDocentesActivos();
            // Ocultar columna Asistio
            dgvAsistencia.Columns["Asistió"].Visible = false;
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
                string value = Convert.ToString(row.Cells["Asistió"].Value);
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

        bool  ExportarDatos(DataGridView datalistado)
        {
            ////concatenar con el nombre del tema.
            //N_Asistencia A = new N_Asistencia();

            //var DateAndTime = DateTime.Now;
            //string Date = DateTime.Now.ToString("dd-MM-yyyy");
            ////string Date = "11-01-2022";

            //string name = NombreAsignatura;
            ////registrar filas
            //foreach (DataGridViewRow row in dgvAsistencia.Rows)
            //{
            //    E_Asistencia_alumnos entities = new E_Asistencia_alumnos();
            //    N_Asistencia_alumnos busines = new N_Asistencia_alumnos();

            //    string asistencia = Convert.ToString(row.Cells["Asistencia"].Value);
            //    string codalumno = Convert.ToString(row.Cells["CodAlumno"].Value);
            //    string nombres = Convert.ToString(row.Cells["Nombres"].Value);
            //    string observacion = Convert.ToString(row.Cells["Observacion"].Value);
            //    //insertar datos en la bd
            //    entities.fecha = Date;
            //    entities.idcatalogo = IdCatalogo;
            //    entities.codalumno = codalumno;
            //    entities.nombres = nombres;
            //    entities.asistio = asistencia;
            //    entities.observacion = observacion;
            //    busines.InsertarAsistenciaAlumno(entities);
            //}
            return true;
        }
        private void buttonGUARDAR_Click(object sender, EventArgs e)
        {
            if (ExportarDatos(dgvAsistencia))
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
        }

        private void buttonDESMARCAR_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAsistencia.Rows)
            {
                row.Cells["Asistencia"].Value = "F";
            }
        }

        private void dgvAsistencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ContarAsistencia();
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

    }
}
