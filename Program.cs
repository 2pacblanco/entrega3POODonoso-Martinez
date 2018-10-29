using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmonGráfico
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
            //ControllerLucha lucha = new ControllerLucha(); falta agregar parametro participante para crear controlador lucha revisar
            //ControllerMdl modelo = new ControllerMdl();
            
            Application.Run(new Form1());
        }
    }
}
