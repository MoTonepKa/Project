using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
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

        public static void LoadFont(Form form)
        {
            PrivateFontCollection MyFontCollection = new PrivateFontCollection();
            string fontPath = Path.Combine(Application.StartupPath, "Resources", "RobotoSlab-Regular.ttf");

            if (File.Exists(fontPath))
                MyFontCollection.AddFontFile(fontPath);
            else
                MessageBox.Show("Файл шрифта не найден по пути: " + fontPath);

            form.Font = new Font(MyFontCollection.Families[0], 9, FontStyle.Regular);
        }
    }
}