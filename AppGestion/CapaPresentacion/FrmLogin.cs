using System.Windows.Forms;
using System.Drawing;

namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        private bool OpcionDocente;
        private bool OpcionDirEscuela;
        private bool OpcionDirDepartamento;

        public FrmLogin()
        {
            InitializeComponent();

            //Inicializando
            OpcionDocente = true;
            buttonDocente.BackColor = Color.White;
            buttonDocente.ForeColor = Color.FromArgb(33, 47, 60);
        }


        #region Eventos
        private void buttonDocente_Click(object sender, System.EventArgs e)
        {
            OpcionDocente = true;
            OpcionDirEscuela = false;
            OpcionDirDepartamento = false;

            //Restaurar backcolors
            buttonDocente.BackColor = Color.White;       
            buttonDirDep.BackColor = Color.FromArgb(33, 47, 60);
            buttonDirEscuela.BackColor = Color.FromArgb(33, 47, 60);

            //Restaurar forecolors
            buttonDocente.ForeColor = Color.FromArgb(33, 47, 60);
            buttonDirDep.ForeColor = Color.White;
            buttonDirEscuela.ForeColor = Color.White;
        }

        private void buttonDirEscuela_Click(object sender, System.EventArgs e)
        {
            OpcionDocente = false;
            OpcionDirEscuela = true;
            OpcionDirDepartamento = false;

            //Restaurar backcolors
            buttonDocente.BackColor = Color.FromArgb(33, 47, 60);
            buttonDirDep.BackColor = Color.FromArgb(33, 47, 60);
            buttonDirEscuela.BackColor = Color.White;

            //Restaurar forecolors
            buttonDocente.ForeColor = Color.White;
            buttonDirDep.ForeColor = Color.White;
            buttonDirEscuela.ForeColor = Color.FromArgb(33, 47, 60);
        }

        private void buttonDirDep_Click(object sender, System.EventArgs e)
        {
            OpcionDocente = false;
            OpcionDirEscuela = false;
            OpcionDirDepartamento = true;

            //Restaurar backcolors
            buttonDocente.BackColor = Color.FromArgb(33, 47, 60);
            buttonDirDep.BackColor = Color.White;
            buttonDirEscuela.BackColor = Color.FromArgb(33, 47, 60);

            //Restaurar forecolors
            buttonDocente.ForeColor = Color.White;
            buttonDirDep.ForeColor = Color.FromArgb(33, 47, 60);
            buttonDirEscuela.ForeColor = Color.White;
        }

        private void buttonCerrar_Click(object sender, System.EventArgs e) => Close();

        #endregion
    }
}
