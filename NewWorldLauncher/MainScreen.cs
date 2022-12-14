using System;
using CmlLib.Core;
using System.Windows.Forms;
using CmlLib.Core.Auth;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Properties
{
    public partial class MainScreen : Form
    {
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
            
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)+ "\\AppData\\Roaming\\.minecraft\\versions\\1.12.2-forge-14.23.5.2859") == false)
            {
                MessageBox.Show("Похоже, что у вас не установлен Forge. Сейчас будет запущена его установка, от вас требуется лишь нажать OK.");
                await Task.Run(() => InstallForgeAsync("C:\\Users\\vesel\\source\\repos\\NWLauncher\\WindowsFormsApp1\\Modpack\\Forge\\forge-1.12.2-14.23.5.2859-installer.jar"));
            }
            if(session == null)
            {
                MessageBox.Show("Вы не ввели или ввели неправильный логин!");
                return;
            }

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
    }
}
