﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmReporteDetalladoAvance : Form
    {
        readonly N_ReporteSesiones oReporteSesiones = new N_ReporteSesiones();
        public frmReporteDetalladoAvance(string CodCatalogo, string NombreAsignatura, string Grupo)
        {
            InitializeComponent();
            MostrarPlanSesiones(CodCatalogo);
            MostrarNombreAsignatura(NombreAsignatura, Grupo);
            MoverModificarColumnas();
            
        }
        private void MoverModificarColumnas()
        {
            dgvAvanceDetallado.Columns["Horas"].Visible = false;
            dgvAvanceDetallado.Columns["VariacionHora"].Visible = false;
            
        }
    public void MostrarPlanSesiones(string CodCatalogo)
        {
            N_PlanSesiones pvista = new N_PlanSesiones();
            dgvAvanceDetallado.DataSource = pvista.ListandoPlanSesiones(CodCatalogo);
            int NroSesionesCompletados = 0;
            int NroSesionesNOCompletados = 0;
            foreach (DataGridViewRow fila in dgvAvanceDetallado.Rows)
            {
                if (fila.Cells["Finalizado"].Value.ToString() == "SI")
                {
                    fila.Cells["Finalizado"].Value = "Completado";
                    NroSesionesCompletados++;
                }
                else if (fila.Cells["Finalizado"].Value.ToString() == "NO")
                {
                    fila.Cells["Finalizado"].Value = "No completado";
                    NroSesionesNOCompletados++;
                }
            }
            nrocompletos.Text = NroSesionesCompletados.ToString();
            nroNOcompletos.Text = NroSesionesNOCompletados.ToString();

        }
        private void MostrarNombreAsignatura(string nombreAsignatura, string grupo)
        {
            lblNombreAsignatura.Text = nombreAsignatura + " - " + "GRUPO " + grupo;
        }

    }
}
