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
                
                    entities.IdCatalogo = textIdCatalogo.Text;
                    entities.NroSemestre = textNroSemestre.Text;
                    entities.CodAsignatura = textCodigo.Text;// + cmbGrupo.Text + "IN";
                    entities.Grupo = cmbGrupo.Text;
                    entities.Aula = textAula.Text;
                    entities.CodDocente = "D001";
                    business.CreandoCursoCatalogo(entities);


                    // HORARIO
                    ComboBox[] Dias = { cmbDia1, cmbDia2, cmbDia3 };
                    TextBox[] HInicio = {textHInicio1, textHInicio2, textHInicio3};
                    TextBox[] HFin = { textHFin1, textHFin2, textHFin3 };
                    
                    int i = 0;
                    entitiesHorario.IdCatalogo = textIdCatalogo.Text;
                    while (i<3)
                    {
                        entitiesHorario.Dia = Dias[i].Text;
                        entitiesHorario.HoraInicio = HInicio[i].Text;
                        entitiesHorario.HoraFin = HFin[i].Text;
                        businessHorario.CreandoHorario(entitiesHorario);
                        i++;
                    }
                    Close();
               /*
                catch (Exception ex)
                {
                    MessageBox.Show("No se peuede agregar");
                }*/
            }
        }
    }
}
