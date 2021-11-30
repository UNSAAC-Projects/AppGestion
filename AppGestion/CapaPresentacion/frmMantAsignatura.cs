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
    public partial class frmMantAsignatura : Form
    {
        public bool Update = false;
        E_Asignatura entities = new E_Asignatura();
        N_Asignatura business = new N_Asignatura();
        public frmMantAsignatura()
        {
            InitializeComponent();
        }
        bool validar_actualizar()
        {
            bool M = true;
            if (textNombre.Text == "")
            {
                MessageBox.Show("Ingrese Nombre de la Asinatura");
                M = false;
            }
            else if (textCreditos.Text == "")
            {
                MessageBox.Show("Ingrese Creditos de la Asignatura");
                M = false;
            }
            else if (textCreditos.Text == "")
            {
                MessageBox.Show("Ingrese Creditos de la Asignatura");
                M = false;
            }
            else if (cmbCategoria.Text == "")
            {
                MessageBox.Show("Ingrese Categoria de la Asignatura");
                M = false;
            }
            else if (textHorasPracticas.Text == "")
            {
                MessageBox.Show("Ingrese Horas practicas de la Asignatura");
                M = false;
            }
            else if (textHorasTeoricas.Text == "")
            {
                MessageBox.Show("Ingrese Horas teoricas de la Asignatura");
                M = false;
            }
            else if (textPrerrequisitos.Text == "")
            {
                MessageBox.Show("Ingrese Prerequisitos de la Asignatura");
                M = false;
            }
            return M;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Update == false)
            {
                try
                {
                    bool R = validar_actualizar();
                    
                    if(R)
                    {
                        entities.codAsigantura = textCodAsignatura.Text;
                        entities.idPlan = textIDPlan.Text;
                        entities.nombre = textNombre.Text;
                        entities.creditos = textCreditos.Text;
                        entities.categoria = cmbCategoria.Text;
                        entities.horasPracticas = textHorasPracticas.Text;
                        entities.horasTeoricas = textHorasTeoricas.Text;
                        entities.prerrequisitos = textPrerrequisitos.Text;
                        business.CreandoAsignatura(entities);

                        MessageBox.Show("Agregado Exitosamente");
                        Close();
                    }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se peuede agregar");
                }
            }
            if (Update == true)
            {
                try
                {
                    bool R = validar_actualizar();

                    if (R==true)
                    {
                        entities.codAsigantura = textCodAsignatura.Text;
                        textCodAsignatura.Enabled = false;
                        entities.idPlan = textIDPlan.Text;
                        entities.nombre = textNombre.Text;
                        entities.creditos = textCreditos.Text;
                        entities.categoria = cmbCategoria.Text;
                        entities.horasPracticas = textHorasPracticas.Text;
                        entities.horasTeoricas = textHorasTeoricas.Text;
                        entities.prerrequisitos = textPrerrequisitos.Text;


                        business.EditandoAsignatura(entities);
                        MessageBox.Show("Modificado Exitosamente");
                        Close();

                        Update = false;
                    }
                    
                    
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar " + ex);
                }
            }

        }

        private void btnMinMantAsignatura_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaxMantAsignatura_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMantAsignatura_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
