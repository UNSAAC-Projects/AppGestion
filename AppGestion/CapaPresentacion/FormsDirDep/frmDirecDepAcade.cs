using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using CapaNegocio;
using Excel;
using CapaEntidades;
using System.IO;

namespace CapaPresentacion
{
    public partial class frmDirecDepAcade : Form
    {
        //Declaracion variables
        DataSet result;
        N_Login oLogin = new N_Login();

        //Constructor
        public frmDirecDepAcade(string CodDocente)
        {
            InitializeComponent();
            MostrarTablaCatalogo();
            MoverModificarColumnas();
            MostrarNombreUsuario(CodDocente);
        }

        private void MostrarNombreUsuario(string codDocente)
        {
            labelNombre.Text = oLogin.ObtenerNombreUsuario(codDocente);
        }

        #region Módulos
        private void MoverModificarColumnas()
        {
            //Mostrar encabezado
            dgvCatalogo.ColumnHeadersVisible = true;

            // Mover columnas editar
            dgvCatalogo.Columns[0].DisplayIndex = 13;

            //Modificar ancho de columnas
            dgvCatalogo.Columns["CURSO"].Width = 250;
            dgvCatalogo.Columns["CRED"].Width = 50;
            dgvCatalogo.Columns["TIPO"].Width = 40;
            dgvCatalogo.Columns["GRUPO"].Width = 60;
            dgvCatalogo.Columns["HT"].Width = 40;
            dgvCatalogo.Columns["HP"].Width = 40;
            dgvCatalogo.Columns["DIA"].Width = 60;
            dgvCatalogo.Columns["HORA INICIO"].Width = 50;
            dgvCatalogo.Columns["HORA FIN"].Width = 50;
            dgvCatalogo.Columns["AULA"].Width = 50;
            dgvCatalogo.Columns["NOMBRES"].Width = 100;
            dgvCatalogo.Columns["APELLIDOS"].Width =150;
            dgvCatalogo.Columns["EDITAR"].Width = 50;

        }

        private void MostrarTablaCatalogo()
        {
            // Modulo para mostrar el catalogo en el formulario principal del director de escuela
            N_CursoCatalogo oCursoCatalogo = new N_CursoCatalogo();
            dgvCatalogo.DataSource = oCursoCatalogo.ListarCatalogoDA(); //DA: director académico
        }

        public void ExportarDatos(DataGridView listadoCatalogo)
        {
            Microsoft.Office.Interop.Excel.Application exportarCatalogo = new Microsoft.Office.Interop.Excel.Application();
            exportarCatalogo.Application.Workbooks.Add(true);
            int indexColumn = 0;
            foreach (DataGridViewColumn columna in listadoCatalogo.Columns)
            {
                if (columna.Name != "EDITAR")
                {
                    indexColumn++;
                    exportarCatalogo.Cells[1, indexColumn] = columna.Name;
                }
            }
            int indexfila = 0;
            foreach (DataGridViewRow fila in listadoCatalogo.Rows)
            {
                indexfila++;
                indexColumn = 0;
                foreach (DataGridViewColumn columna in listadoCatalogo.Columns)
                {
                    if (columna.Name != "EDITAR")
                    {
                        indexColumn++;
                        exportarCatalogo.Cells[indexfila + 1, indexColumn] = fila.Cells[columna.Name].Value;
                    }
                }
            }
            exportarCatalogo.Visible = true;
        }

        DataView ImportarDatos(string nombrearchivo)
        {
            string conexion = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}; Extended Properties'Excel 12.0;'",nombrearchivo);
           
            OleDbConnection conector = new OleDbConnection(conexion);
            conector.Open();


            OleDbCommand consulta = new OleDbCommand("select *  from [Hoja1$]", conector);
            OleDbDataAdapter adaptador = new OleDbDataAdapter
            {
                SelectCommand = consulta
            };
            

            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            conector.Close();
            return ds.Tables[0].DefaultView;
        }
        #endregion

        #region Eventos
        private void buttonDISTRIBUCION_Click(object sender, EventArgs e)
        {
            buttonIMPORTAR.BackColor = Color.FromArgb(12, 61, 92);
            frmDistDocentes c = new frmDistDocentes();
            c.Show();
        }

        private void buttonLISTAR_Click(object sender, EventArgs e)
        {
            buttonIMPORTAR.BackColor = Color.FromArgb(12, 61, 92);
            frmListaDocentes p = new frmListaDocentes();
            p.Show();
        }
        
        private void buttonIMPORTAR_Click(object sender, EventArgs e)
        {
            buttonIMPORTAR.BackColor = Color.FromArgb(12, 61, 92);
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
                    dgvCatalogo.DataSource = result.Tables[0];
                    reader.Close();

                }
            }

        }
        
        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();        
        }

        private void btnMINIMIZAR_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        
        private void dgvCatalogo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvCatalogo.Rows[e.RowIndex];
            if (row.Cells["EDITAR"].Selected)
            {
                //Obtener cod curso
                string CodCursoCatalogo = row.Cells["CODIGO"].Value.ToString();

                frmAsignarDocente form = new frmAsignarDocente(CodCursoCatalogo);
                //Recuperar información de la tabla
                form.textBoxCodigo.Text = CodCursoCatalogo;
                form.textBoxCurso.Text = row.Cells["CURSO"].Value.ToString();
                form.textBoxHT.Text = row.Cells["HT"].Value.ToString();
                form.textBoxHP.Text = row.Cells["HP"].Value.ToString();
                form.textBoxCreditos.Text = row.Cells["CRED"].Value.ToString();
                form.textBoxAula.Text = row.Cells["AULA"].Value.ToString();
                form.textBoxGrupo.Text = row.Cells["GRUPO"].Value.ToString();
                form.ShowDialog();

                //Actualizar tabla catalogo
                MostrarTablaCatalogo();
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            //Definiendo variables
            string codCurso, nombreCurso, tipo;
            string codDocente, nombresDocente, apellidosDocente;
            N_CursoCatalogo oCursoCatalogo = new N_CursoCatalogo();
            N_Docente oDocente = new N_Docente();

            //Recorrer filas del dgvCatalogo
            foreach (DataGridViewRow row in dgvCatalogo.Rows)
            {
                //Recuperar codigo del curso (ex: IF340AIN)
                codCurso = row.Cells["CODIGO"].Value.ToString();

                //Verificar si existe codigo del curso
                if (oCursoCatalogo.ExisteCursoCatalogo(codCurso)) //Si existe curso
                {
                    //Recuperar nombres y apellidos del docente
                    nombresDocente = row.Cells["NOMBRES"].Value.ToString();
                    apellidosDocente = row.Cells["APELLIDOS"].Value.ToString();
                    
                    //Recuperar el tipo de curso
                    tipo = row.Cells["TIPO"].Value.ToString();

                    //Recuperar código del docente
                    codDocente = oDocente.RecuperarCodDocente(nombresDocente, apellidosDocente);
                    if(codDocente!= null) //Si codDocente existe
                    {
                        //Verificar si es docente teorico o práctico
                        if (tipo == "T") oCursoCatalogo.EditarDocenteTeorico(codCurso, codDocente);
                        else if (tipo == "P") oCursoCatalogo.EditarDocentePractico(codCurso, codDocente);
                    }
                    else //Si codDocente no existe
                    {
                        if (tipo == "T") oCursoCatalogo.EditarDocenteTeorico(codCurso, "");   // "" vacio que se convertira a NULL
                        else if (tipo == "P") oCursoCatalogo.EditarDocentePractico(codCurso, "");   // "" vacio que se convertira a NULL
                        MessageBox.Show($"El docente {nombresDocente} {apellidosDocente} no se encuentra registrado. Verifique si sus datos están correctos.", "Alerta");
                    }
                }
                else  // No existe curso
                {
                    //Recuperar nombre del curso
                    nombreCurso = row.Cells["CURSO"].Value.ToString();
                    MessageBox.Show($"El curso {codCurso} - {nombreCurso} no se encuentra registrado en el catálogo.");
                }
            }
            //Reiniciar tabla de catalogo
            MostrarTablaCatalogo();

            //Mensaje de confirmación
            MessageBox.Show("El catálogo se actualizó correctamente.","Mensaje de confirmación");
        }

        private void buttonDESCARGAR_Click(object sender, EventArgs e) => ExportarDatos(dgvCatalogo);

        private void pictureBoxMaxRest_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
        #endregion

    }
}
