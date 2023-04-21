using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ControllerUI ui = new ControllerUI();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //bool result = ui.ConnectToServer();
            //if (result) Application.Run(new Login());
            //else {
            //    MessageBox.Show("Failed to connect to server!");
            //}

        }
    }
}
