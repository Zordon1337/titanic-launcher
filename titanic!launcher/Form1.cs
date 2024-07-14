using titanic_launcher.Tabs;

namespace titanic_launcher
{
    public partial class Form1 : Form
    {

        User u = api.getUser(277);
        tHome tHome = new tHome();
        tSettings tSettings = new tSettings();
        public Form1()
        {
            InitializeComponent();
            container.Controls.Clear();
            container.Controls.Add(tHome);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Username.Text = u.Username;
            PP.Text = $"PP: {((int)(u.StdScore.PP)).ToString()}";
            RankedScore.Text = $"Ranked Score: {u.StdScore.RankedScore.ToString("N0")}";
            TotalScore.Text = $"Total Score: {u.StdScore.TotalScore.ToString("N0")}";
            this.userImage.ImageLocation = u.ImagePath;
        }

        private void userInfopanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void onModeChange(object sender, EventArgs e)
        {
            switch (tSettings.comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        PP.Text = $"PP: {((int)(u.StdScore.PP)).ToString()}";
                        RankedScore.Text = $"Ranked Score: {u.StdScore.RankedScore.ToString("N0")}";
                        TotalScore.Text = $"Total Score: {u.StdScore.TotalScore.ToString("N0")}";
                        break;
                    }
                case 1:
                    {
                        PP.Text = $"PP: {((int)(u.TaikoScore.PP)).ToString()}";
                        RankedScore.Text = $"Ranked Score: {u.TaikoScore.RankedScore.ToString("N0")}";
                        TotalScore.Text = $"Total Score: {u.TaikoScore.TotalScore.ToString("N0")}";
                        break;
                    }
                case 2:
                    {
                        PP.Text = $"PP: {((int)(u.CtbScore.PP)).ToString()}";
                        RankedScore.Text = $"Ranked Score: {u.CtbScore.RankedScore.ToString("N0")}";
                        TotalScore.Text = $"Total Score: {u.CtbScore.TotalScore.ToString("N0")}";
                        break;
                    }
                case 3:
                    {
                        PP.Text = $"PP: {((int)(u.ManiaScore.PP)).ToString()}";
                        RankedScore.Text = $"Ranked Score: {u.ManiaScore.RankedScore.ToString("N0")}";
                        TotalScore.Text = $"Total Score: {u.ManiaScore.TotalScore.ToString("N0")}";
                        break;
                    }

            }
        }
        private void container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabHome_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            container.Controls.Add(tHome);
        }

        private void tabSettings_Click(object sender, EventArgs e)
        {
            tSettings.comboBox1.SelectedIndexChanged += this.onModeChange;
            container.Controls.Clear();
            container.Controls.Add(tSettings);
        }
    }
}
