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
        public static PrivateFontCollection MyFontCollection = new PrivateFontCollection();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            

            ApplicationConfiguration.Initialize();
<<<<<<< Updated upstream
            Database.Initialize();
=======
            StudentDB.Initialize();

            LoadFont();
            MainForm = new LoginForm();
>>>>>>> Stashed changes
            Application.Run(MainForm);
            
        }

        public static void LoadFont()
        {
            string fontPath = Path.Combine(Application.StartupPath, "Resources", "SpriteGraffiti-Regular.ttf");
            MyFontCollection.AddFontFile(fontPath);
            fontPath = Path.Combine(Application.StartupPath, "Resources", "SpriteGraffiti-Shadow.ttf");
            MyFontCollection.AddFontFile(fontPath);
            //form.Font = new Font(MyFontCollection.Families[0], 9, FontStyle.Regular);
        }
    }
}