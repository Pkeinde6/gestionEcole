using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionCahierTexte
{
    internal static class Program
    {
        // Force le GPU Nvidia/AMD dédié (au lieu de l'intégré Intel)
        [DllImport("nvapi64.dll", EntryPoint = "fake")]
        static extern int LoadNvApi64();

        [DllImport("nvapi.dll", EntryPoint = "fake")]
        static extern int LoadNvApi32();

        // DPI awareness pour rendu net sur écrans haute résolution
        [DllImport("user32.dll")]
        static extern bool SetProcessDPIAware();

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Activer DPI awareness pour rendu net
            try { SetProcessDPIAware(); } catch { }

            // Priorité haute du processus pour max de réactivité
            try { Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High; } catch { }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Double buffering global pour éliminer le scintillement
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            Application.Run(new Form1());
        }
    }
}
