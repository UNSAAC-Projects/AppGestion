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

namespace CapaPresentacion
{
    public partial class ReporteAsistenciasAlumnos : Form
    {
        readonly N_ReporteAsistencia oreporteasistencia = new N_ReporteAsistencia();
        readonly N_CursosDocente D = new N_CursosDocente();

        public string CodDocente;
        public ReporteAsistenciasAlumnos()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReporteAsistenciasAlumnos_Load(object sender, EventArgs e)
        {
            CargarCombo();
            comboBoxCursosReporte.SelectedIndex = 0;
            //mostrarReporte();
            comboBoxUnidad.SelectedIndex = 0;
        }

        private void mostrarReporte()
        {
            string NombreAsig = comboBoxCursosReporte.Text;
            string IdCat = oreporteasistencia.recuperarIdCat(NombreAsig, CodDocente);
            dgvReporteAsistencia.DataSource = oreporteasistencia.ReporteAsistencia(IdCat, "2022-01-10", "2022-03-02");
            //dgvReporteAsistencia.Columns.Add("Porcentaje", "Porcentaje de Asistencia");
            if (!dgvReporteAsistencia.Columns.Contains("Porcentaje"))
            {
                dgvReporteAsistencia.Columns.Add("Porcentaje", "Porcentaje de Asistencia");
            }
            int M;
            string valorFila;
            M = dgvReporteAsistencia.Columns.Count;
            foreach (DataGridViewRow m in dgvReporteAsistencia.Rows)
            {
                int asistencia;
                asistencia = 0;
                for (int i = 2; i < M - 1; i++)
                {
                    valorFila = m.Cells[i].Value.ToString();
                    if (valorFila == "P")
                    {
                        asistencia++;
                    }
                }
                float PORCENTAJE =(((float)asistencia * 100 / (float)(M - 3))) ;
                //float PORCENTAJE = 70;
                PORCENTAJE = (float)Math.Round(PORCENTAJE,2);
                m.Cells["Porcentaje"].Value = PORCENTAJE.ToString() +"%";
            }
        }

        private void comboBoxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCursosReporte.DropDownStyle = ComboBoxStyle.DropDownList;
            mostrarReporte();
        }
        void CargarCombo()
        {
            DataTable dt = new DataTable();
            dt = D.ListarCursosDocente(datos.CodDocente);
            int n = dt.Rows.Count;
            int i = 0;
            while(i < n)
            {
                comboBoxCursosReporte.Items.Add(dt.Rows[i][1].ToString());
                i = i + 1;
            }
            //comboBoxCursosReporte.SelectedIndex = 0;


        }
        DataSet result;

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarFrmReporte_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizarFrmReporte_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
