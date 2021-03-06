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
        public string DocPractico = "";
        public string DocTeorico = "";
         E_CursoCatalogo entities = new E_CursoCatalogo();
        N_CursoCatalogo business = new N_CursoCatalogo();

        E_Horario entitiesHorario = new E_Horario();
        N_Horario businessHorario = new N_Horario();
        public EditCatalogo()
        {
            InitializeComponent();
        }
        bool validar(int Creditos)
        {
            bool M = true;
            if (Creditos > 3)
            {
                if (cmbGrupo.Text == "")
                {
                    MessageBox.Show("Complete el grupo del curso");
                    M = false;
                }
                else if (textSemestreLectivo.Text == "")
                {
                    MessageBox.Show("Complete el semestre lectivo del curso");
                    M = false;
                }
                else if (textAula.Text == "")
                {
                    MessageBox.Show("Complete el aula del curso");
                    M = false;
                }
                else if (cmbDia1.Text == "")
                {
                    MessageBox.Show("Complete el horario del curso");
                    M = false;
                }
                else if (textHInicio1.Text == "")
                {
                    MessageBox.Show("Complete el horario del curso");
                    M = false;
                }
                else if (textHFin1.Text == "")
                {
                    MessageBox.Show("Complete el horario del curso");
                    M = false;
                }
                else if (cmbTipo1.Text == "")
                {
                    MessageBox.Show("Complete el horario del curso");
                    M = false;
                }
                else if (cmbDia2.Text == "")
                {
                    MessageBox.Show("Complete el horario del curso");
                    M = false;
                }
                else if (textHInicio2.Text == "")
                {
                    MessageBox.Show("Complete el horario del curso");
                    M = false;
                }
                else if (textHFin2.Text == "")
                {
                    MessageBox.Show("Complete el horario del curso");
                    M = false;
                }
                else if (cmbTipo2.Text == "")
                {
                    MessageBox.Show("Complete el horario del curso");
                    M = false;
                }
                else if (cmbDia3.Text == "")
                {
                    MessageBox.Show("Complete el horario del curso");
                    M = false;
                }
                else if (textHInicio3.Text == "")
                {
                    MessageBox.Show("Complete el horario del curso");
                    M = false;
                }
                else if (textHFin3.Text == "")
                {
                    MessageBox.Show("Complete el horario del curso");
                    M = false;
                }
                else if (cmbTipo3.Text == "")
                {
                    MessageBox.Show("Complete el horario del curso");
                    M = false;
                }
                return M;
            }
            else
            {
                if (cmbGrupo.Text == "")
                {
                    MessageBox.Show("Complete el grupo del curso");
                    M = false;
                }
                else if (textAula.Text == "")
                {
                    MessageBox.Show("Complete el aula del curso");
                    M = false;
                }
                else if (cmbDia1.Text == "")
                {
                    MessageBox.Show("Complete el horario del curso");
                    M = false;
                }
                else if (textHInicio1.Text == "")
                {
                    MessageBox.Show("Complete el horario del curso");
                    M = false;
                }
                else if (textHFin1.Text == "")
                {
                    MessageBox.Show("Complete el horario del curso");
                    M = false;
                }
                else if (cmbTipo1.Text == "")
                {
                    MessageBox.Show("Complete el horario del curso");
                    M = false;
                }
                else if (cmbDia2.Text == "")
                {
                    MessageBox.Show("Complete el horario del curso");
                    M = false;
                }
                else if (textHInicio2.Text == "")
                {
                    MessageBox.Show("Complete el horario del curso");
                    M = false;
                }
                else if (textHFin2.Text == "")
                {
                    MessageBox.Show("Complete el horario del curso");
                    M = false;
                }
                else if (cmbTipo2.Text == "")
                {
                    MessageBox.Show("Complete el horario del curso");
                    M = false;
                }
                return M;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Update == false)
            {
                try
                {
                    int cred = Convert.ToInt32(textCreditos.Text);
                    if (validar(cred))
                    {
                        entities.IdCatalogo = textIdCatalogo.Text;
                        entities.NroSemestre = textNroSemestre.Text;
                        entities.SemestreLectivo = textSemestreLectivo.Text;
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
                        MessageBox.Show("Modificado Exitosamente");
                        Close();
                    }
                }
                catch
                {
                    MessageBox.Show("No se peuede agregar");
                }

            }
            if (Update == true)
            {

                //try
                //{
                    int cred = Convert.ToInt32(textCreditos.Text);
                    if (validar(cred))
                    {
                        entities.IdCatalogo = textIdCatalogo.Text;
                        textIdCatalogo.Enabled = false;
                        entities.NroSemestre = textNroSemestre.Text;
                        entities.SemestreLectivo = textSemestreLectivo.Text;
                        entities.CodAsignatura = textCodigo.Text;// + cmbGrupo.Text + "IN";
                        entities.Grupo = cmbGrupo.Text;
                        entities.Aula = textAula.Text;
                        entities.CodDocenteTeorico = DocTeorico;
                        entities.CodDocentePractico = DocTeorico;
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
                        MessageBox.Show("Modificado Exitosamente");
                        Close();
                        Update = false;
                    }
                //}
                //catch
                //{
                //    MessageBox.Show("No es posible editar");
                //}
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textIdCatalogo_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        /*private void BtnCancelarEditAsignatura_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea cancelar?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) Close(); //Cerrar ventana
        }*/
    }
}
