using System;
using CmlLib.Core;
using System.Windows.Forms;
using CmlLib.Core.Auth;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Net;
using System.Collections.Generic;

namespace WindowsFormsApp1.Properties
{
    public partial class MainScreen : Form
    {
        const string FORGE_WEB_PATH = "https://github.com/GeoPlayerRu/NWLauncher/blob/main/NewWorldLauncher/Modpack/Forge/forge-1.12.2-14.23.5.2859-installer.jar?raw=true";
        const string MODSDIR_WEB_PATH = "https://github.com/GeoPlayerRu/NWLauncher/blob/main/NewWorldLauncher/Modpack/Mods/";
        readonly string[] MODS = { "CustomNPCs", "FTBLib", "FTBQuests","ItemFilters"};
        readonly string USER_PATH = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        private string _nickname;
        private MSession session = null; 
   
        public MainScreen()
        {
            InitializeComponent();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            _nickname = NameBox.Text;
            session = MSession.GetOfflineSession(_nickname);
        }

        private async void PlayButton_Click(object sender, EventArgs e)
        {

            if (session == null)
            {
                MessageBox.Show("Вы не ввели или ввели неправильный логин!");
                return;
            }

            PlayButton.Enabled = false;
            NameBox.Enabled = false;

            //Докачивание и установка недостающих компонентов
            var client = new WebClient();

            if (Directory.Exists(USER_PATH + @"\AppData\Roaming\.minecraft\versions\1.12.2-forge-14.23.5.2859") == false)
            {
               
                MessageBox.Show("Похоже, что у вас не установлен Forge. Сейчас будет запущена его установка, от вас требуется лишь нажать OK.");
                
                client.DownloadFile(FORGE_WEB_PATH,Path.GetTempPath()+ "forge.jar");
                await Task.Run(() => InstallForgeAsync(Path.GetTempPath()+ "forge.jar"));
            }

            if (!Directory.Exists(@"\AppData\Roaming\.minecraft\mods\"))
            {
                Directory.CreateDirectory(@"\AppData\Roaming\.minecraft\mods\");
            }

            foreach(string mod in MODS)
            {
                Console.WriteLine(File.Exists(USER_PATH + $"\\AppData\\Roaming\\.minecraft\\mods\\{mod}.jar"));
                if(File.Exists(USER_PATH + $"\\AppData\\Roaming\\.minecraft\\mods\\{mod}.jar") == false)
                {
                    client.DownloadFile(MODSDIR_WEB_PATH+mod+".jar?raw=true", USER_PATH + $"\\AppData\\Roaming\\.minecraft\\mods\\{mod}.jar");
                }
            }
            
            //Запуск игры
            var path = new MinecraftPath();
            var launcher = new CMLauncher(path);

            var launchOptions = new MLaunchOption
            {
                MaximumRamMb= 1024,
                Session = session,
            };

            var process = await launcher.CreateProcessAsync("1.12.2-forge-14.23.5.2859", launchOptions);
            process.Start();

            Close();
        }
        private void InstallForgeAsync(string file)
        {
            var process = new Process();
            process.StartInfo.FileName = file;
            process.Start();

            process.WaitForExit();
        }

        private void Heading_Click(object sender, EventArgs e)
        {

        }
    }
}
