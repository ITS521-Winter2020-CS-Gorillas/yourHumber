using ITS521.CS.Gorillas.UI;
using System;
using System.Windows.Forms;

namespace ITS521.CS.Gorillas.Business {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
