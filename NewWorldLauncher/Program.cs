using System.Diagnostics;
using System;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
using System.IO;
using System.Text;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        private static readonly string USER_PATH = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!Directory.Exists(USER_PATH + @"\AppData\Roaming\.minecraft\"))
            {
                FirstLaunch();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
            
        }

        static void FirstLaunch()
        {
            string work_directory = USER_PATH + @"\AppData\Roaming\.minecraft\";
            Directory.CreateDirectory(work_directory);

            File.Create(work_directory+"launcher_profiles.json").Close();
            StreamWriter writer = new StreamWriter(work_directory + "launcher_profiles.json");
            writer.WriteLine("{");
            writer.WriteLine("\"profiles\" : {},");
            writer.WriteLine("\"settings\" : {}");
            writer.WriteLine("}");
            writer.Close();

        }
    }
}
