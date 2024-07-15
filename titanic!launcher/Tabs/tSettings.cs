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

        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            Settings.bHideLevelProgress = !Settings.bHideLevelProgress;
        }
    }
}
