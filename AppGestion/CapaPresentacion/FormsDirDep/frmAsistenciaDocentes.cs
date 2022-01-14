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
    public partial class frmAsistenciaDocentes : Form
    {
        FrmLogin L = new FrmLogin();
        E_Asistencia entities = new E_Asistencia();
        N_PlanSesiones oPlanSesiones = new N_PlanSesiones();

        public string CodAsignatura;
        int indexTema; //Indice del siguiente tema a dictar

        public frmAsistenciaDocentes()
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
            //MostrarListaMatriculados();
            // Mostrar los docentes activos en el semestre actual
            MostrarDocentesActivos();


            lblNroAlumnos.Text = dgvAsistencia.Rows.Count.ToString();

            // Mostrar relacion de alumnos matriculados
            dgvAsistencia.Columns["Asistio"].Visible = false;
           
            ImprimirHoraFecha();
            ContarAsistencia();


        }
        private void MostrarDocentesActivos()
        {
            //N_CursoCatalogo oCursoCatalogo = new N_CursoCatalogo();
            //string Date = DateTime.Now.ToString("dd-MM-yyyy");
            ////string Date ="11-01-2022";
            //dgvAsistencia.DataSource = oCursoCatalogo.ListarMatriculados(IdCatalogo, Date);
            //int asisten = 0;
            //foreach (DataGridViewRow row in dgvAsistencia.Rows)
            //{
            //    string a = Convert.ToString(row.Cells["Asistio"].Value);
            //    if (a == "")
            //    {
            //        row.Cells["Asistencia"].Value = "F";
            //    }
            //    if (a == "F")
            //    {
            //        row.Cells["Asistencia"].Value = "F";
            //    }
            //    if (a == "P")
            //    {
            //        row.Cells["Asistencia"].Value = "P";
            //    }
            //}
            ////asisten
           
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
            long nro =UInt32.Parse(lblNroAlumnos.Text) - contador;
            lblFaltaron.Text = nro.ToString();
        }

        public void ImprimirHoraFecha()
        {
            string datetime;
            datetime = DateTime.Now.ToString("dd / MM / yyyy" +"   "+ "hh:mm:ss tt");
            lblFecha.Text = datetime;
            //lblDocente.Text = datos.NombreDocente;
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
            dgvAsistencia.Columns["CodAlumno"].ReadOnly = true;
            dgvAsistencia.Columns["Nombres"].ReadOnly = true;
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
