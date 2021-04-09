using Hypercube.Forms;
using System;
using System.Windows.Forms;

namespace Hypercube
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainWindow = new BrowserForm();
            Application.Run(mainWindow);

            //using (var databaseContent = new DatabaseContent())
            //{
            //    var users = databaseContent.Users.ToList();
            //    mainWindow.SetGridData(users);


            //}
        }
    }
}
