using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace titanic_launcher.Tabs
{
    public partial class tHome : UserControl
    {
        Point installpos = new Point(193, 220);

        public tHome()
        {
            InitializeComponent();
            Settings.ReadFromConfig();
            Settings.clients = api.getClients();
            timer1.Start();
        }

        private void tHome_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("./images"))
            {
                //new Thread(() => { MessageBox.Show("Downloading Images, please wait\nETA: 20s", "lol", MessageBoxButtons.OK, MessageBoxIcon.Warning); }).Start();
            }
            foreach (Client client in Settings.clients)
            {
                api.getClientImage(client);
                if (client.Screenshots.Count < 1)
                    continue;
                if (client.Downloads.Count < 1)
                    continue;
                if (client.Downloads[0] == null)
                    continue;
                listBox1.Items.Add(client.Name);
            }
        }
        private Client FindClient(string value)
        {
            return Settings.clients.Find(x => x.Name == value);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            ClientImage.ImageLocation = api.getClientImage(FindClient(listBox1.Text));
            if (FindClient(listBox1.Text).isInstalled())
            {
                InstallBtn.Visible = false;
                RunBtn.Location = installpos;
                RunBtn.Visible = true;
                BeatmapsLabel.Visible = true;
                SkinsLabel.Visible = true;
                SkinsLabel.Text = $"Skins: {FindClient(listBox1.Text).getSkins()}";
                BeatmapsLabel.Text = $"Beatmaps: {FindClient(listBox1.Text).getMaps()}";
                ShowGameFilesBtn.Visible = true;
                ShowGameFilesBtn.Location = new Point(327, 220);
                UninstallBtn.Visible = true;
                UninstallBtn.Location = new Point(327 + 134, 220);
            }
            else
            {
                InstallBtn.Visible = true;
                InstallBtn.Location = installpos;
                RunBtn.Visible = false;
                BeatmapsLabel.Visible = false;
                SkinsLabel.Visible = false;
                ShowGameFilesBtn.Visible = false;
                UninstallBtn.Visible = false;
            }

        }

        private void ClientImage_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Thread(() => { MessageBox.Show("Client downloading started.\nIt may take some time\nDepends if contabo has good day\nor if you have good internet.", "Titanic!Launcher"); }).Start();
            FindClient(listBox1.Text).Install();
            listBox1_SelectedIndexChanged(sender, e);
        }

        private void RunBtn_Click(object sender, EventArgs e)
        {
            FindClient(listBox1.Text).Run();
        }

        private void ShowGameFilesBtn_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", $"{Application.StartupPath}clients\\{FindClient(listBox1.Text).Name}");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Settings.bClientUpdateRequired)
            {
                listBox1.Items.Clear();
                foreach (Client client in Settings.clients)
                {
                    api.getClientImage(client);
                    if (client.Screenshots.Count < 1)
                        continue;
                    if (client.Downloads.Count < 1)
                        continue;
                    if (client.Downloads[0] == null)
                        continue;
                    listBox1.Items.Add(client.Name);
                }
                Settings.bClientUpdateRequired = false;
            }
        }
    }
}
