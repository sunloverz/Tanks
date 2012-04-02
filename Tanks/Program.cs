using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

namespace Tanks
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Controller_MainForm(Convert.ToInt32(arg[0]),Convert.ToInt32(arg[1]),Convert.ToInt32(arg[2]),Convert.ToInt32(arg[3])));
            Application.Run(new Controller_MainForm(260, 4, 5, 40));
        }
    }
}
