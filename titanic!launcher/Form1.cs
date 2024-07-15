using System.Runtime.InteropServices;
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
            Accuracy.Text = $"Accuracy: {float.Round(u.StdScore.Accuracy * 100, 2)}%";
            LevelLabel.Text = $"Level: {u.CalculateLevel(u.StdScore).lvl}";
            progressBar1.Maximum = (int)u.CalculateLevel(u.StdScore).required_xp/100;
            progressBar1.Value = (int)u.CalculateLevel(u.StdScore).current_xp/100;
            this.userImage.ImageLocation = u.ImagePath;

        }

        private void userInfopanel_Paint(object sender, PaintEventArgs e)
        {

            progressBar1.Visible = !Settings.bHideLevelProgress;
        }
        private void onProgressCheck(object sender, EventArgs e)
        {
            progressBar1.Visible = !Settings.bHideLevelProgress;
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
                        Accuracy.Text = $"Accuracy: {float.Round(u.StdScore.Accuracy * 100, 2)}%";
                        LevelLabel.Text = $"Level: {u.CalculateLevel(u.StdScore).lvl}";
                        progressBar1.Value = (int)((u.CalculateLevel(u.StdScore).current_xp * 100) / u.CalculateLevel(u.StdScore).required_xp);
                        break;
                    }
                case 1:
                    {
                        PP.Text = $"PP: {((int)(u.TaikoScore.PP)).ToString()}";
                        RankedScore.Text = $"Ranked Score: {u.TaikoScore.RankedScore.ToString("N0")}";
                        TotalScore.Text = $"Total Score: {u.TaikoScore.TotalScore.ToString("N0")}";
                        Accuracy.Text = $"Accuracy: {float.Round(u.TaikoScore.Accuracy * 100, 2)}%";
                        LevelLabel.Text = $"Level: {u.CalculateLevel(u.TaikoScore).lvl}";
                        progressBar1.Value = (int)((u.CalculateLevel(u.TaikoScore).current_xp * 100) / u.CalculateLevel(u.TaikoScore).required_xp);
                        break;
                    }
                case 2:
                    {
                        PP.Text = $"PP: {((int)(u.CtbScore.PP)).ToString()}";
                        RankedScore.Text = $"Ranked Score: {u.CtbScore.RankedScore.ToString("N0")}";
                        TotalScore.Text = $"Total Score: {u.CtbScore.TotalScore.ToString("N0")}";
                        Accuracy.Text = $"Accuracy: {float.Round(u.CtbScore.Accuracy * 100, 2)}%";
                        LevelLabel.Text = $"Level: {u.CalculateLevel(u.CtbScore).lvl}";
                        progressBar1.Value = (int)((u.CalculateLevel(u.CtbScore).current_xp * 100) / u.CalculateLevel(u.CtbScore).required_xp);
                        break;
                    }
                case 3:
                    {
                        PP.Text = $"PP: {((int)(u.ManiaScore.PP)).ToString()}";
                        RankedScore.Text = $"Ranked Score: {u.ManiaScore.RankedScore.ToString("N0")}";
                        TotalScore.Text = $"Total Score: {u.ManiaScore.TotalScore.ToString("N0")}";
                        Accuracy.Text = $"Accuracy: {float.Round(u.ManiaScore.Accuracy * 100, 2)}%";
                        LevelLabel.Text = $"Level: {u.CalculateLevel(u.ManiaScore).lvl}";
                        progressBar1.Value = (int)((u.CalculateLevel(u.ManiaScore).current_xp * 100) / u.CalculateLevel(u.ManiaScore).required_xp);
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
            tSettings.checkBox1.CheckStateChanged += this.onProgressCheck;
            container.Controls.Clear();
            container.Controls.Add(tSettings);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void LevelLabel_Click(object sender, EventArgs e)
        {

        }
    }
    public static class Utils
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public enum Color { None, Green, Red, Yellow }

        public static void SetState(this ProgressBar pBar, Color newColor, int newValue)
        {
            if (pBar.Value == pBar.Minimum)  // If it has not been painted yet, paint the whole thing using defualt color...
            {                                // Max move is instant and this keeps the initial move from going out slowly 
                pBar.Value = pBar.Maximum;   // in wrong color on first painting
                SendMessage(pBar.Handle, 1040, (IntPtr)(int)Color.Green, IntPtr.Zero);
            }
            pBar.Value = newValue;
            SendMessage(pBar.Handle, 1040, (IntPtr)(int)Color.Green, IntPtr.Zero);     // run it out to the correct spot in default
            SendMessage(pBar.Handle, 1040, (IntPtr)(int)newColor, IntPtr.Zero);        // now turn it the correct color
        }
    }
}
