using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        List<Client> clients = api.getClients();
        public tHome()
        {
            InitializeComponent();
        }

        private void tHome_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("./images"))
            {
                //new Thread(() => { MessageBox.Show("Downloading Images, please wait\nETA: 20s", "lol", MessageBoxButtons.OK, MessageBoxIcon.Warning); }).Start();
            }
            foreach (Client client in clients)
            {
                api.getClientImage(client);
                if (client.Screenshots.Count == 0)
                    continue;
                listBox1.Items.Add(client.Name);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            ClientImage.ImageLocation = api.getClientImage(clients[listBox1.SelectedIndex]);
            if (clients[listBox1.SelectedIndex].isInstalled())
            {
                InstallBtn.Visible = false;
                RunBtn.Location = installpos;
                RunBtn.Visible = true;
                BeatmapsLabel.Visible = true;
                SkinsLabel.Visible = true;
                SkinsLabel.Text = $"Skins: {clients[listBox1.SelectedIndex].getSkins()}";
                BeatmapsLabel.Text = $"Beatmaps: {clients[listBox1.SelectedIndex].getMaps()}";
            } else
            {
                InstallBtn.Visible = true;
                InstallBtn.Location = installpos;
                RunBtn.Visible = false;
                BeatmapsLabel.Visible = false;
                SkinsLabel.Visible = false;
            }

        }

        private void ClientImage_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clients[listBox1.SelectedIndex].Install();
            listBox1_SelectedIndexChanged(sender,e);
        }

        private void RunBtn_Click(object sender, EventArgs e)
        {
            clients[listBox1.SelectedIndex].Run();
        }
    }
}
