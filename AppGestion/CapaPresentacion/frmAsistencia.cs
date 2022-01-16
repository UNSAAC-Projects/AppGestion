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
    public partial class frmAsistencia : Form
    {
        //FrmLogin L = new FrmLogin();
        readonly N_ListaAsistencias oListaAsistencias = new N_ListaAsistencias();
        readonly N_PlanSesiones oPlanSesiones = new N_PlanSesiones();

        private string IdCatalogo, NombreAsignatura;
        private DateTime Fecha;

        public string CodAsignatura;

        int indexTema; //Indice del siguiente tema a dictar

        public frmAsistencia()
        {
            InitializeComponent();
        }
        public frmAsistencia(string pIdCatalogo, string pNombreAsignatura)
        {
            InitializeComponent();
            IdCatalogo = pIdCatalogo;
            NombreAsignatura = pNombreAsignatura;
            Fecha = DateTime.Now;
        }
        public frmAsistencia(string pIdCatalogo, string pNombreAsignatura, DateTime pFecha)
        {
            InitializeComponent();
            IdCatalogo = pIdCatalogo;
            NombreAsignatura = pNombreAsignatura;
            Fecha = pFecha;
        }

        private void btnMINIMIZAR_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAsistencia_Load(object sender, EventArgs e)
        {
            //Mostar lista de alumnos matriculados
            MostrarListaMatriculados(Fecha);
            // Mostrar temas a dictar en el combobox
            MostrarTemas();

            lblNroAlumnos.Text = dgvAsistencia.Rows.Count.ToString();
            lblNombreAsignatura.Text = NombreAsignatura;

            //Ocultar columna Asistio
            dgvAsistencia.Columns["Asistio"].Visible = false;
           
            ImprimirHoraFecha();
            ContarAsistencia();
        }
        private void MostrarListaMatriculados(DateTime Date)
        {
            N_CursoCatalogo oCursoCatalogo = new N_CursoCatalogo();
            //DateTime Date = DateTime.Now;
            //DateTime Date = new DateTime(2022, 01, 16);
            dgvAsistencia.DataSource = oCursoCatalogo.ListarMatriculados(IdCatalogo, Date);
            foreach (DataGridViewRow row in dgvAsistencia.Rows)
            {
                string a = Convert.ToString(row.Cells["Asistio"].Value);
                if (a == "")
                {
                    row.Cells["Asistencia"].Value = "F";
                }
                if (a == "F")
                {
                    row.Cells["Asistencia"].Value = "F";
                }
                if (a == "P")
                {
                    row.Cells["Asistencia"].Value = "P";
                }
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
            long nro =UInt32.Parse(lblNroAlumnos.Text) - contador;
            lblFaltaron.Text = nro.ToString();
        }
        private void MostrarTemas()
        {// Mostrar el listado de temas en comboBoxTema

            //Obtener lista de temas e id del siguiente tema
            List<string> listItems = oPlanSesiones.ObtenerTemasProximos(IdCatalogo, out int indexSiguienteTema);
            //Mostrar temas en combobox
            object[] arrayItems = listItems.ToArray(); //Convertir a array
            comboBoxTema.Items.AddRange(arrayItems); //Insertar valores
            comboBoxTema.SelectedText = arrayItems[indexSiguienteTema].ToString(); //Valor por defecto
            indexTema = indexSiguienteTema;
        }

        public void ImprimirHoraFecha()
        {
            string datetime;
            datetime = Fecha.ToString("dd / MM / yyyy" +"   "+ "hh:mm:ss tt");
            lblFecha.Text = datetime;
            lblDocente.Text = datos.NombreDocente;
        }

        bool  ExportarDatos(DataGridView datalistado)
        {
            //var DateAndTime = DateTime.Now;
            DateTime Date = DateTime.Now;
            //DateTime Date = new DateTime(2022,01,16);

            string name = NombreAsignatura;
            //Guardar asistencia de alumnos
            foreach (DataGridViewRow row in dgvAsistencia.Rows)
            {
                E_Asistencia_alumnos entities = new E_Asistencia_alumnos();
                N_Asistencia_alumnos busines = new N_Asistencia_alumnos();

                string asistencia = Convert.ToString(row.Cells["Asistencia"].Value);
                string codalumno = Convert.ToString(row.Cells["CodAlumno"].Value);
                string nombres = Convert.ToString(row.Cells["Nombres"].Value);
                string observacion = Convert.ToString(row.Cells["Observacion"].Value);
                //insertar datos en la bd
                entities.fecha = Date;
                entities.idcatalogo = IdCatalogo;
                entities.codalumno = codalumno;
                entities.nombres = nombres;
                entities.asistio = asistencia;
                entities.observacion = observacion;
                busines.InsertarAsistenciaAlumno(entities);
            }
            //Iniciar entidad ListaAsistencias para guardar datos de la asistencia
            E_ListaAsistencias eListaAsistencias = new E_ListaAsistencias();
            eListaAsistencias.fecha = Date;
            eListaAsistencias.tema = comboBoxTema.Text;
            eListaAsistencias.idcatalogo = IdCatalogo;
            //Guardar o actualizar datos de la asistencia en la tabla TListaAsistencias
            oListaAsistencias.GuardarDatosAsistencia(eListaAsistencias);

            return true;
        }
        private void buttonGUARDAR_Click(object sender, EventArgs e)
        {
            if (ExportarDatos(dgvAsistencia))
            {
                //Guardar un tema si no está en el combo box o actualizarlo como tema completado
                GuardarActualizarTema();

                MessageBox.Show("Guardado exitosamente...");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al guardar...");
            }
        }

        private void GuardarActualizarTema()
        {
            string item = comboBoxTema.Text.Trim();
            if (comboBoxTema.Items.Contains(item))
            {
                //Actualizar como completado (falta completar)
            }
            else
            {
                //Agregar tema a plan sesiones
                oPlanSesiones.InsertarNuevoTema(indexTema, IdCatalogo, item);
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

        private void dgvAsistencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ContarAsistencia();
            dgvAsistencia.Columns["CodAlumno"].ReadOnly = true;
            dgvAsistencia.Columns["Nombres"].ReadOnly = true;
        }
    }
}
