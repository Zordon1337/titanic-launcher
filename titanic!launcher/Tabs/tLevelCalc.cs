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
    public partial class tLevelCalc : UserControl
    {
        public tLevelCalc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long currentxp = 0; // current xp
            Level currentlevel = new Level();
            int expectedlevel = (int)numericUpDown1.Value;
            
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        currentxp = Settings.u.StdScore.TotalScore;
                        currentlevel = Settings.u.CalculateLevel(Settings.u.StdScore);
                        break;

                    }
                case 1:
                    {
                        currentxp = Settings.u.TaikoScore.TotalScore;
                        currentlevel = Settings.u.CalculateLevel(Settings.u.TaikoScore);
                        break;
                    }
                case 2:
                    {
                        currentxp = Settings.u.CtbScore.TotalScore;
                        currentlevel = Settings.u.CalculateLevel(Settings.u.CtbScore);
                        break;
                    }
                case 3:
                    {
                        currentxp = Settings.u.ManiaScore.TotalScore;
                        currentlevel = Settings.u.CalculateLevel(Settings.u.ManiaScore);
                        break;
                    }
            }
            if (expectedlevel <= currentlevel.lvl)
            {
                MessageBox.Show("What are you trying to do huh?", "wtf", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            long currentlevelprogress = 0; //xp required to have current level
            for(int i = 1;i < currentlevel.lvl;i++)
            {
                currentlevelprogress += User.toNextLevel[i];
            }
            long currentlevelprogress2 = currentxp - currentlevelprogress; // level progress on current level
            long neededxp = 0;
            for(int i = currentlevel.lvl+1; i < expectedlevel;i++)
            {
                neededxp += User.toNextLevel[i];
            }
            neededxp -= currentlevelprogress2;
            label4.Text = $"Required score: {neededxp.ToString("N0")}";
            MessageBox.Show($@"You need: {neededxp.ToString("N0")} more score to get level up","Result",MessageBoxButtons.OK,MessageBoxIcon.Information);
            label4.Visible = true ;
        }
    }
}
