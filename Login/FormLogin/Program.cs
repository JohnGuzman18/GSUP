using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login;

namespace Login
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Splash());
        

            Splash sp = new Splash();
            if (sp.ShowDialog() == DialogResult.OK) 
            {
                Application.Run(new LoginPrincipal());
            }


        }
    }
}
