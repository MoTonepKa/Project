using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Project.Data;
using Project.Models;

namespace Project
{
    internal static class Program
    {
        public static Form MainForm = null;
        public static User User;
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            StudentDB.Initialize();

            DrawInterface.SetupFont();

            MainForm = new LoginForm();
            Application.Run(MainForm);
            
        }

        
    }
}