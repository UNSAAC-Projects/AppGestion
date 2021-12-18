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
using System.Runtime.InteropServices;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class frmVistaCursosDocente : Form
    {
        N_CursosDocente ocursosDocente = new N_CursosDocente();
        public frmVistaCursosDocente(string CodDocente)
        {
            InitializeComponent();
            MostrarCursosDocente(CodDocente);
        }
        public void MostrarCursosDocente(string codDocente)
        {
            N_CursosDocente ovista = new N_CursosDocente();
            dgvCursosDocente.DataSource = ovista.ListandoCursosDocente(codDocente);
        }

        private void btnMinCursosDocente_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnCloseCursosDocente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVistaCursosDocente_Load(object sender, EventArgs e)
        {

        }

        private void dgvCursosDocente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvCursosDocente.Rows[e.RowIndex];
            if (row.Cells["PlanSesiones"].Selected)
            {
                //Obtener cod curso
                string CodGrupoAsignatura = row.Cells["GrupoAsignatura"].Value.ToString();
                string CodCatalogo  = ocursosDocente.ObtenerCodCatalogo(CodGrupoAsignatura) ;
                string NombreAsignatura = row.Cells["Nombre"].Value.ToString();
                string Grupo = row.Cells["Grupo"].Value.ToString();
                frmPlanDeSesiones form = new frmPlanDeSesiones(CodCatalogo, NombreAsignatura, Grupo);
                
                form.ShowDialog();
            }
        }
    }
}
