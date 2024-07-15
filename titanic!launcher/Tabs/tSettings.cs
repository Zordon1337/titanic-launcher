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
    public partial class tSettings : UserControl
    {
        public tSettings()
        {
            InitializeComponent();

        }

        private void tSettings_Load(object sender, EventArgs e)
        {

            label2.Text = Settings.version.ToString();
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            Settings.bHideLevelProgress = !Settings.bHideLevelProgress;
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
            Settings.sUsername = textBox1.Text;

            Settings.u = api.getUser(Settings.sUsername);
            this.comboBox1.SelectedIndex = 0;
        }
    }
}
