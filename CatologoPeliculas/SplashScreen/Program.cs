using Presentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashScreen
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SplachScreen sp = new SplachScreen();
            if (sp.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Registro());
            }
        }
    }
}
