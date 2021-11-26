﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace CapaPresentacion
{
    public partial class frmAsignarDocentev2 : Form
    {
        public frmAsignarDocentev2()
        {
            InitializeComponent();
        }

        #region Eventos
        private void pictureBoxCerrar_Click(object sender, EventArgs e) => Close();

        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            //Cambiar estado a minimizado
            WindowState = FormWindowState.Minimized;
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea cancelar?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) Close(); //Cerrar ventana
        }
        #endregion

        #region Procedure to drag form
        //Añadir using System.Runtime.InteropServices para usar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);
        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

    }
}