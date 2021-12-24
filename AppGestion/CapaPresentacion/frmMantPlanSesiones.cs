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
    public partial class frmMantPlanSesiones : Form
    {
        public bool Update = false;
        E_PlanSesiones entities = new E_PlanSesiones();
        N_PlanSesiones business = new N_PlanSesiones();
        public frmMantPlanSesiones()
        {
            InitializeComponent();
        }

        bool validar_actualizar()
        {
            bool M = true;
            if (txtUnidad.Text == "")
            {
                MessageBox.Show("Ingrese Unidad de la Asignatura");
                M = false;
            }
            else if (txtCapitulo.Text == "")
            {
                MessageBox.Show("Ingrese Capitulo de la Asignatura");
                M = false;
            }
            else if (txtTema.Text == "")
            {
                MessageBox.Show("Ingrese Tema de la Asignatura");
                M = false;
            }
            else if (txtHoras.Text == "")
            {
                MessageBox.Show("Ingrese Horas de dictado del Tema");
                M = false;
            }
            return M;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //if (Update == false)
            //{
            //    try
            //    {
            //        bool R = validar_actualizar();

            //        if (R)
            //        {
            //            entities.Unidad = txtUnidad.Text;
            //            entities.Capitulo = txtCapitulo.Text;
            //            entities.Tema = txtTema.Text;
            //            entities.HorasProgramadas = txtHoras.Text;
            //            entities.Fecha = txtFecha.Text;
                        
            //            business.CreandoPlanSesiones(entities);

            //            MessageBox.Show("Agregado Exitosamente");
            //            Close();
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("No se puede agregar");
            //    }
            //}
            //if (Update == true)
            //{
            //    try
            //    {
            //        bool R = validar_actualizar();

            //        if (R == true)
            //        {
            //            entities.Unidad = txtUnidad.Text;
            //            entities.Capitulo = txtCapitulo.Text;
            //            entities.Tema = txtTema.Text;
            //            entities.HorasProgramadas = txtHoras.Text;
            //            entities.Fecha = txtFecha.Text;


            //            business.EditandoPlanSesiones(entities);
            //            MessageBox.Show("Modificado Exitosamente");
            //            Close();

            //            Update = false;
            //        }



            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("No se pudo editar " + ex);
            //    }
            //}

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
