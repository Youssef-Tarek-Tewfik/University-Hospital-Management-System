using System;
using System.Windows.Forms;
using University_Hospital_Management_System.ProjectClasses;
using University_Hospital_Management_System.ProjectForms;

namespace University_Hospital_Management_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            OrclDatabase database = new OrclDatabase();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthForm());
        }
    }
}
