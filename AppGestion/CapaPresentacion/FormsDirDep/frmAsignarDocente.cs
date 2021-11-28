using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaNegocio;
using CapaEntidades;


namespace CapaPresentacion
{
    public partial class frmAsignarDocente : Form
    {
        string nombreDocenteP, apellidoDocenteP;
        string nombreDocenteT, apellidoDocenteT;

        public frmAsignarDocente(string CodCursoCatalogo ) //Ex: IF345AIN
        {
            InitializeComponent();
            MostrarTablaHorario(CodCursoCatalogo);
            MoverModificarColumnas();
        }

        private void MoverModificarColumnas()
        {
            // Modificar ancho columnas
            dgvHorarioCurso.Columns["DIA"].Width = 100;
            dgvHorarioCurso.Columns["HORA INICIO"].Width = 70;
            dgvHorarioCurso.Columns["HORA FIN"].Width = 60;
            dgvHorarioCurso.Columns["TIPO"].Width = 50;
            dgvHorarioCurso.Columns["NOMBRES"].Width = 150;

            //Inhabilitar columnas (onlyread)
            //dgvHorarioCurso.Columns[""]
            dgvHorarioCurso.Columns["DIA"].ReadOnly = true;
            dgvHorarioCurso.Columns["HORA INICIO"].ReadOnly = true;
            dgvHorarioCurso.Columns["HORA FIN"].ReadOnly = true;
            dgvHorarioCurso.Columns["TIPO"].ReadOnly = true;

        }

        private void MostrarTablaHorario(string CodCursoCatalogo)
        {
            // Modulo para mostrar el horario de un curso
            N_CursoCatalogo oCursoCatalogo = new N_CursoCatalogo();
            dgvHorarioCurso.DataSource = oCursoCatalogo.MostrarHorarioCurso(CodCursoCatalogo); //DA: director académico

        }


        #region Eventos
        private void pictureBoxCerrar_Click(object sender, EventArgs e) => Close();

        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            //Cambiar estado a minimizado
            WindowState = FormWindowState.Minimized;
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea cancelar?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) Close(); //Cerrar ventana
        }
        #endregion

        #region Procedure to drag form
        //Añadir using System.Runtime.InteropServices para usar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);
        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void dgvHorarioCurso_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            /*
             * DataGridViewRow row = dgvCatalogo.Rows[e.RowIndex];
            if (row.Cells["EDITAR"].Selected)
             */
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            //Definiendo variables
            string codCurso, nombreCurso, tipo;
            string codDocente, nombresDocente, apellidosDocente;
            N_CursoCatalogo oCursoCatalogo = new N_CursoCatalogo();
            N_Docente oDocente = new N_Docente();

            //Recorrer filas del dgvCatalogo
            foreach (DataGridViewRow row in dgvHorarioCurso.Rows)
            {
                //Recuperar codigo del curso (ex: IF340AIN)
                //codCurso = row.Cells["CODIGO"].Value.ToString();
                codCurso = textBoxCodigo.Text;

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
                    if (codDocente != null) //Si codDocente existe
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
                        return; //Cancelar operacion
                    }
                }
                else  // No existe curso
                {
                    //Recuperar nombre del curso
                    nombreCurso = textBoxCurso.Text;
                    MessageBox.Show($"El curso {codCurso} - {nombreCurso} no se encuentra registrado en el catálogo.");
                    return; //Cancelar operacion
                }
            }

            //Mensaje de confirmación
            MessageBox.Show("Asignado correctamente", "Mensaje de confirmación");
            Close(); //Cerrar formulario.
        }
    }
}
