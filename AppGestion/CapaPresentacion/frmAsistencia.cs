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
        FrmLogin L = new FrmLogin();
        E_Asistencia entities = new E_Asistencia();
        N_PlanSesiones oPlanSesiones = new N_PlanSesiones();

        string IdCatalogo, NombreAsignatura;
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
            // Mostrar temas a dictar en el combobox
            MostrarTemas();

            // Mostrar nombre de la asignatura
            lblAsignatura.Text = NombreAsignatura;

            // Mostrar relacion de alumnos matriculados
            dgvAsistencia.Columns["Observacion"].DisplayIndex = 3;
            dgvAsistencia.Columns["ALUMNO"].DisplayIndex = 1;
            dgvAsistencia.Columns["APELLIDOS Y NOMBRES"].DisplayIndex = 2;
            //dgvAsistencia.Columns["ALUMNO"].DisplayIndex = 2;
            //dgvAsistencia.Columns["APELLIDOS Y NOMBRES"].DisplayIndex = 3;
            //dgvAsistencia.Columns["A"].DisplayIndex = 4;
            
            //dgvAsistencia.Columns[0].Width = 40;
            dgvAsistencia.Columns[3].Width = 68;
            dgvAsistencia.Columns[4].Width = 260;
            dgvAsistencia.Columns.Remove("1");
            dgvAsistencia.Columns.Remove("2");
            dgvAsistencia.Columns.Remove("3");
            dgvAsistencia.Columns.Remove("4");
            dgvAsistencia.Columns.Remove("5");
            dgvAsistencia.Columns.Remove("Obs");
            dgvAsistencia.Columns.Remove("Column9");
            dgvAsistencia.Columns.Remove("NRO");
            ImprimirHoraFecha();
        }

        private void MostrarTemas()
        {// Mostrar el listado de temas en comboBoxTema

            //Obtener lista de temas e id del siguiente tema
            List<string> listItems = oPlanSesiones.ObtenerTemasProximos(IdCatalogo, out int indexSiguienteTema);
            //Mostrar temas en combobox
            object[] arrayItems = listItems.ToArray(); //Convertir a array
            comboBoxTema.Items.AddRange(arrayItems); //Insertar valores
            comboBoxTema.SelectedText = arrayItems[indexSiguienteTema].ToString(); //Valor por defecto
        }

        public void ImprimirHoraFecha()
        {
            string datetime;
            datetime = DateTime.Now.ToString("dd / MM / yyyy" +"   "+ "hh:mm:ss tt");
            lblFecha.Text = datetime;
            lblDocente.Text = datos.NombreDocente;
        }

        public string ObtenerRutaProyecto()
        {//Método para obtener la ruta del proyecto
            string rutaProyecto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
            return rutaProyecto;
        }

        bool  ExportarDatos(DataGridView datalistado)
        {
            //concatenar con el nombre del tema.
            N_Asistencia A = new N_Asistencia();

            var DateAndTime = DateTime.Now;
            string Date = DateTime.Now.ToString("ddMMyyyy");

            string name = datos.NombreCurso + Date;

            string ruta = $@"{ObtenerRutaProyecto()}\..\ListaAlumnosDia\" + name + ".xlsx";
            //string ruta = @"D:\8vosemestre\Ing.Software\proyecto\ListaAlumnosDia\"+name+".xlsx";
            SLDocument osLDocument = new SLDocument();
            System.Data.DataTable dt = new System.Data.DataTable();
            //registrar columnas
            dt.Columns.Add("ASISTENCIA",typeof(string));
            dt.Columns.Add("ALUMNOS", typeof(string));
            dt.Columns.Add("APELLIDOS Y NOMBRES", typeof(string));
            dt.Columns.Add("OBSERVACION", typeof(string));
            //registrar filas
            foreach (DataGridViewRow row in dgvAsistencia.Rows)
            {
                string asistencia = Convert.ToString(row.Cells["Asistencia"].Value);
                string alumnos = Convert.ToString(row.Cells["ALUMNO"].Value);
                string apellidos = Convert.ToString(row.Cells["APELLIDOS Y NOMBRES"].Value);
                string observacion = Convert.ToString(row.Cells["Observacion"].Value);
                dt.Rows.Add(asistencia, alumnos, apellidos, observacion);
            }
            osLDocument.ImportDataTable(1,1,dt,true);
            osLDocument.SaveAs(ruta);
            //insertar lista a la base de datos
            entities.curso = datos.NombreCurso;
            entities.tema = comboBoxTema.Text;
            entities.fecha = lblFecha.Text;
            entities.asistencia =ruta;
            entities.idcatalogo = datos.CodCatalogo;
            A.CreandoCurso_Asistencia(entities);
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
                //Actualizar como completado
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
                row.Cells["Asistencia"].Value = true;
            }
        }

        private void buttonDESMARCAR_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAsistencia.Rows)
            {
                row.Cells["Asistencia"].Value = false;
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
            
            dgvAsistencia.Columns["ALUMNO"].ReadOnly = true;
            dgvAsistencia.Columns["APELLIDOS Y NOMBRES"].ReadOnly = true;
            
        }
    }
}
