using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteriaElCruce
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLuancher());

            
        }

        private static void Application_UseWaitCursorChanged(object sender, EventArgs e)
        {
            // Obtener el estado actual del cursor de espera
            bool useWaitCursor = Application.UseWaitCursor;

            // Cambiar el cursor en todas las ventanas abiertas
            foreach (Form form in Application.OpenForms)
            {
                form.UseWaitCursor = useWaitCursor;
            }
        }

        private static void Application_ThreadExit(object sender, EventArgs e)
        {
            // Restaurar el cursor predeterminado al salir de la aplicación
            Cursor.Current = Cursors.Default;
        }
    }
}
