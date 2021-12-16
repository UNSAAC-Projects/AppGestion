using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel;
using System.IO;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmDocente : Form
    {
        DataSet result;
        N_Login oLogin = new N_Login();
       
        public string Docente;

        public frmDocente(string CodDocente)
        {
            InitializeComponent();
            //Mostrar nombre de usuario
            MostrarNombreUsuario(CodDocente);
            //Mostrar horario del docente o mensaje si no tiene ningun curso
            MostrarHorarioxDia(CodDocente); 
            Docente = CodDocente;
            
        }

        private void MostrarNombreUsuario(string codDocente)
        {
            labelNombre.Text = oLogin.ObtenerNombreUsuario(codDocente);
           
            datos.NombreDocente = labelNombre.Text;
           
        }

        private void btnVerCursosDocente_Click(object sender, EventArgs e)
        {
            frmVistaCursosDocente frm = new frmVistaCursosDocente(Docente); 
            frm.ShowDialog();
        }

        private void btnMINIMIZAR_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ContenedorLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MostrarHorarioxDia(string codDocente)
        {
            //Obtener día
            ObtenerTiempo(out _, out _, out string dia);
            dia = "VIERNES";
            //Mostrar tabla
            N_Docente oDocente = new N_Docente();
            // Obtener tabla de horarios del dia actual
            var table = oDocente.MostrarHorarioDocenteDia(codDocente, dia);
            //Verificar si la tabla no está vacio
            if (table != null && table.Rows.Count > 0)
            {
                dgvCursosDocente.DataSource = table; //Mostrar tabla
                MoverModificarColumnas(); //Modificar columnas
            }
            else //Si está vacio
            {
                //Mostrar mensaje
                dgvCursosDocente.Visible = false; //Ocultar datagridview
                labelMensaje.Visible = true; //Mostrar label
                pictureBoxLibros.Visible = true; // Mostrar imagen
            }
        }

        private void MoverModificarColumnas()
        {
            //Mostrar encabezado
            dgvCursosDocente.ColumnHeadersVisible = true; // Mostrar encabezado
            //dgvCatalogo.ColumnHeadersVisible = true;

            // Mover columnas 
            dgvCursosDocente.Columns["TEMA"].DisplayIndex = 7;
            dgvCursosDocente.Columns["ASISTENCIA"].DisplayIndex = 7;

            ////Modificar ancho de columnas
            dgvCursosDocente.Columns["CODIGO"].Width = 70;
            dgvCursosDocente.Columns["NOMBRE"].Width = 240;
            dgvCursosDocente.Columns["TIPO"].Width = 50;
            dgvCursosDocente.Columns["GRUPO"].Width = 60;
            ///////////////////
            //dgvCursosDocente.Columns["HORAS"].Width = 70;
            ///////////////////
            dgvCursosDocente.Columns["AULA"].Width = 60;
            dgvCursosDocente.Columns["TEMA"].Width = 300;
            dgvCursosDocente.Columns["ASISTENCIA"].Width = 80;
            
        }

        public void ObtenerTiempo(out string fecha, out string hora, out string dia)
        {
            fecha = DateTime.Now.ToString("dd/MM/yyyy");
            hora = DateTime.Now.ToString("HH:mm:ss tt");
            dia = "";
            int nroDia = (int)DateTime.Now.DayOfWeek;
            switch (nroDia)
            {
                case 0: dia = "DOMINGO"; break;
                case 1: dia = "LUNES"; break;
                case 2: dia = "MARTES"; break;
                case 3: dia = "MIERCOLES"; break;
                case 4: dia = "JUEVES"; break;
                case 5: dia = "VIERNES"; break;
                case 6: dia = "SABADO"; break;
            }
        }

        //private void buttonGetDate_Click(object sender, EventArgs e)
        //{
        //    string fecha, hora, dia;
        //    ObtenerTiempo(out fecha, out hora, out dia);
        //    MessageBox.Show($"Dia: {fecha}\nHora: {hora}\nDia: {dia}");
        //}

        private void dgvCursosDocente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvCursosDocente.Rows[e.RowIndex];
            if (row.Cells["ASISTENCIA"].Selected)
            {
                //Obtener cod curso
                string CodCursoCatalogo = row.Cells["CODIGO"].Value.ToString();

                frmAsistencia form = new frmAsistencia();
               
                //Recuperar información de la tabla
                //form.textBoxCodigo.Text = CodCursoCatalogo;
                //form.textBoxCurso.Text = row.Cells["CURSO"].Value.ToString();
                form.ShowDialog();
            }
        }

        private void frmDocente_Load(object sender, EventArgs e)
        {
           
        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void dgvCursosDocente_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) //Si no se hizo click en el encabezado
            {
                DataGridViewRow row = dgvCursosDocente.Rows[e.RowIndex];
                if (row.Cells["ASISTENCIA"].Selected)
                {
                    //Obtener cod curso
                    string CodCursoCatalogo = row.Cells["CODIGO"].Value.ToString();

                    frmAsistencia form = new frmAsistencia();
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
                            form.dgvAsistencia.DataSource = result.Tables[0];
                            reader.Close();
                        }
                    }
                    //Recuperar información de la tabla
                    //form.textBoxCodigo.Text = CodCursoCatalogo;
                    //form.textBoxCurso.Text = row.Cells["CURSO"].Value.ToString();
                    form.ShowDialog();
                }
            }   
        }
    }
}
