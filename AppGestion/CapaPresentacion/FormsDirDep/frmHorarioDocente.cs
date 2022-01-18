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
    public partial class frmHorarioDocente : Form
    {
        public frmHorarioDocente(string CodDocente)
        {
            InitializeComponent();
            MostrarTablaHorarioDocente(CodDocente);
            MostrarHorasDictado();
        }

        private void MostrarTablaHorarioDocente(string codDocente)
        {
            N_Docente oDocente = new N_Docente();
            dgvHorarioDocente.DataSource = oDocente.MostrarHorarioDocente(codDocente);
        }

        private void MostrarHorasDictado()
        {
            string value;
            int horasDictado, total = 0;
            foreach (DataGridViewRow row in dgvHorarioDocente.Rows)
            {
                value = row.Cells["HORAS"].Value.ToString();
                horasDictado =  int.Parse(value);
                total += horasDictado;
            }
            textBoxHDictado.Text = total.ToString();
        }
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        //Movimiento panel
        int posY = 0;
        int posX = 0;
        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

    }
}
