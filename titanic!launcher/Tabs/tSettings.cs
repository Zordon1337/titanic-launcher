using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace titanic_launcher.Tabs
{
    public partial class tSettings : UserControl
    {
        public tSettings()
        {
            InitializeComponent();
        }

        private void tSettings_Load(object sender, EventArgs e)
        {

            label2.Text = Settings.version.ToString();
            this.usernameBox.Text = Settings.sUsername;
            this.comboBox1.SelectedIndex = Settings.FavoriteMode;
            this.checkBox1.Checked = Settings.bHideLevelProgress;
            this.customManifest.Text = Settings.manifest;
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            Settings.bHideLevelProgress = this.checkBox1.Checked;
        }

        private void label2_Paint(object sender, PaintEventArgs e)
        {
            label2.Location = new Point(774 - label2.Width, 313);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Settings.sUsername = usernameBox.Text;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Settings.u != null)
            {
                if (Settings.u.Username == usernameBox.Text)
                {
                    MessageBox.Show("Maybe change username in first place?", "what are trying to do");
                    return;
                }
            }

            bool smethod = Settings.u == null;
            try
            {
                new WebClient().DownloadString($"https://osu.lekuru.xyz/api/profile/{Settings.sUsername}");
            } catch
            {

                MessageBox.Show("Please enter correct username", "Ah shit, here we go again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!smethod)
            {

                string olduser = Settings.u.Username;
                var thr = new Thread(() =>
                {
                    Settings.u = api.getUser(Settings.sUsername);

                });
                thr.Start();
                while (Settings.u.Username == olduser)
                { }
            }
            else
            {
                var thr = new Thread(() =>
                {
                    Settings.u = api.getUser(Settings.sUsername);

                });
                thr.Start();
                while (Settings.u == null)
                { }
            }



            this.comboBox1.SelectedIndex = 1;
            this.comboBox1.SelectedIndex = 0;
        }

        private void SaveCustomManifestBtn_Click(object sender, EventArgs e)
        {
            Settings.manifest = this.customManifest.Text;
            Settings.clients = api.getClients();
            Settings.bClientUpdateRequired = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings.manifest = "https://osu.lekuru.xyz/api/clients";
            this.customManifest.Text = Settings.manifest;
            Settings.clients = api.getClients();
            Settings.bClientUpdateRequired = true;
        }
    }
}
