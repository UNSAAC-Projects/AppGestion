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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureCancelAsignaturas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureMinAsignaturas_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

      
    }
}
