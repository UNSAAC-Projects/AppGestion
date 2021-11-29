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
using CapaEntidades;
using System.Runtime.InteropServices;


namespace CapaPresentacion
{
    public partial class EditCatalogo : Form
    {
        public bool Update = false;
        E_CursoCatalogo entities = new E_CursoCatalogo();
        N_CursoCatalogo business = new N_CursoCatalogo();

        E_Horario entitiesHorario = new E_Horario();
        N_Horario businessHorario = new N_Horario();
        public EditCatalogo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Update == false)
            {
                try
                {
                    entities.IdCatalogo = textIdCatalogo.Text;
                    entities.NroSemestre = textNroSemestre.Text;
                    entities.CodAsignatura = textCodigo.Text;// + cmbGrupo.Text + "IN";
                    entities.Grupo = cmbGrupo.Text;
                    entities.Aula = textAula.Text;
                    entities.CodDocenteTeorico = "D000";
                    entities.CodDocentePractico = "D000";
                    business.CreandoCursoCatalogo(entities);

                    // HORARIO
                    ComboBox[] Dias = { cmbDia1, cmbDia2, cmbDia3 };
                    TextBox[] HInicio = { textHInicio1, textHInicio2, textHInicio3 };
                    TextBox[] HFin = { textHFin1, textHFin2, textHFin3 };
                    ComboBox[] Tipo = { cmbTipo1, cmbTipo2, cmbTipo3 };

                    int i = 0;
                    int creditos = Convert.ToInt32(textCreditos.Text);
                    entitiesHorario.IdCatalogo = textIdCatalogo.Text;
                    if (creditos > 3)
                    {
                        while (i < 3)
                        {
                            entitiesHorario.Dia = Dias[i].Text;
                            entitiesHorario.HoraInicio = HInicio[i].Text;
                            entitiesHorario.HoraFin = HFin[i].Text;
                            entitiesHorario.Tipo = Tipo[i].Text;
                            businessHorario.CreandoHorario(entitiesHorario);
                            i++;
                        }
                    }
                    if (creditos < 4)
                    {
                        while (i < 2)
                        {
                            entitiesHorario.Dia = Dias[i].Text;
                            entitiesHorario.HoraInicio = HInicio[i].Text;
                            entitiesHorario.HoraFin = HFin[i].Text;
                            entitiesHorario.Tipo = Tipo[i].Text;
                            businessHorario.CreandoHorario(entitiesHorario);
                            i++;
                        }
                    }
                    Close();
                }
                catch 
                {
                    MessageBox.Show("No se peuede agregar");
                }

            }
            if (Update == true) 
            {
                try
                {
                    entities.IdCatalogo = textIdCatalogo.Text;
                    textIdCatalogo.Enabled = false;
                    entities.NroSemestre = textNroSemestre.Text;
                    entities.CodAsignatura = textCodigo.Text;// + cmbGrupo.Text + "IN";
                    entities.Grupo = cmbGrupo.Text;
                    entities.Aula = textAula.Text;
                    entities.CodDocenteTeorico = "D000";
                    entities.CodDocentePractico = "D000";
                    business.EditandoCursoCatalogo(entities);

                    // HORARIO
                    ComboBox[] Dias = { cmbDia1, cmbDia2, cmbDia3 };
                    TextBox[] HInicio = { textHInicio1, textHInicio2, textHInicio3 };
                    TextBox[] HFin = { textHFin1, textHFin2, textHFin3 };
                    ComboBox[] Tipo = { cmbTipo1, cmbTipo2, cmbTipo3 };

                    int i = 0;
                    int creditos = Convert.ToInt32(textCreditos.Text);
                    entitiesHorario.IdCatalogo = textIdCatalogo.Text;
                    if (creditos > 3)
                    {
                        while (i < 3)
                        {
                            entitiesHorario.Dia = Dias[i].Text;
                            entitiesHorario.HoraInicio = HInicio[i].Text;
                            entitiesHorario.HoraFin = HFin[i].Text;
                            entitiesHorario.Tipo = Tipo[i].Text;
                            businessHorario.CreandoHorario(entitiesHorario);
                            i++;
                        }
                    }
                    if (creditos < 4)
                    {
                        while (i < 2)
                        {
                            entitiesHorario.Dia = Dias[i].Text;
                            entitiesHorario.HoraInicio = HInicio[i].Text;
                            entitiesHorario.HoraFin = HFin[i].Text;
                            entitiesHorario.Tipo = Tipo[i].Text;
                            businessHorario.CreandoHorario(entitiesHorario);
                            i++;
                        }
                    }
                    Close();
                    Update = false;
                }
                catch 
                {
                    MessageBox.Show("No es posible editar");
                }
            }
            
        }

        private void pictureCancelAsignaturas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureMinAsignaturas_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #region Procedure to drag form
        //Añadir using System.Runtime.InteropServices para usar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);
        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        /*private void BtnCancelarEditAsignatura_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea cancelar?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) Close(); //Cerrar ventana
        }*/
    }
}
