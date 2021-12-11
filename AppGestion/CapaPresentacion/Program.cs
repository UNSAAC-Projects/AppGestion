using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 

        public static ApplicationContext AppContext { get; set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppContext = new ApplicationContext(new frmDocente("D0004"));
            Application.Run(AppContext);
        }

        //Método para intercambiar formularios
        public static void SwitchMainForm(Form newForm)
        {
            var oldMainForm = AppContext.MainForm;
            AppContext.MainForm = newForm;
            oldMainForm?.Close();
            newForm.Show();
        }
    }
}
