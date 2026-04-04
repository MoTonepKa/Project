using Project.Data;
using Project.Forms;

namespace Project
{
    internal static class Program
    {
        public static Form MainForm = new LoginForm();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Database.Initialize();
            Application.Run(MainForm);
        }
    }
}