using System;
using System.Windows.Forms;
using DevExpress.Skins;

namespace CompoundPrinting {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SkinManager.EnableFormSkins();
            Application.Run(new Form1());
        }
    }
}