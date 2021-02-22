using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Database;

namespace Hypercube
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainWindow = new MainWindow();
            var users = new DatabaseContent().Users.ToList();
            mainWindow.SetGridData(users);

            Application.Run(mainWindow);
        }
    }
}
