using System.Runtime.InteropServices;
using titanic_launcher.Tabs;

namespace titanic_launcher
{

    public partial class Form1 : Form
    {


        tHome tHome = new tHome();
        tSettings tSettings = new tSettings();
        public Form1()
        {
            Settings.ReadFromConfig();
            InitializeComponent();
            container.Controls.Clear();
            container.Controls.Add(tHome);
            this.FormClosed += FormClosing;
        }
        private void FormClosing(object sender, EventArgs e)
        {
            Settings.WriteToConfig();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Settings.sUsername != "")
                Settings.u = api.getUser(Settings.sUsername);
            if (Settings.u != null)
            {
                Username.Text = Settings.u.Username;
                PP.Text = $"PP: {((int)(Settings.u.StdScore.PP)).ToString()}";
                RankedScore.Text = $"Ranked Score: {Settings.u.StdScore.RankedScore.ToString("N0")}";
                TotalScore.Text = $"Total Score: {Settings.u.StdScore.TotalScore.ToString("N0")}";
                Accuracy.Text = $"Accuracy: {float.Round(Settings.u.StdScore.Accuracy * 100, 2)}%";
                LevelLabel.Text = $"Level: {Settings.u.CalculateLevel(Settings.u.StdScore).lvl}";
                var levelInfo = Settings.u.CalculateLevel(Settings.u.StdScore);
                progressBar1.Value = (int)(((double)levelInfo.current_xp * 100) / levelInfo.required_xp);

                this.userImage.ImageLocation = Settings.u.ImagePath;
            }
            else
            {
                Username.Text = "User not logged in";
            }
            
            progressBar1.Visible = !Settings.bHideLevelProgress;
        }

        private void userInfopanel_Paint(object sender, PaintEventArgs e)
        {


        }
        private void onProgressCheck(object sender, EventArgs e)
        {
            progressBar1.Visible = !Settings.bHideLevelProgress;
        }
        private void onModeChange(object sender, EventArgs e)
        {
            if (Settings.u == null)
                return;
            Settings.FavoriteMode = tSettings.comboBox1.SelectedIndex;
            switch (tSettings.comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        Username.Text = Settings.u.Username;
                        PP.Text = $"PP: {((int)(Settings.u.StdScore.PP)).ToString()}";
                        RankedScore.Text = $"Ranked Score: {Settings.u.StdScore.RankedScore.ToString("N0")}";
                        TotalScore.Text = $"Total Score: {Settings.u.StdScore.TotalScore.ToString("N0")}";
                        Accuracy.Text = $"Accuracy: {float.Round(Settings.u.StdScore.Accuracy * 100, 2)}%";
                        LevelLabel.Text = $"Level: {Settings.u.CalculateLevel(Settings.u.StdScore).lvl}";
                        progressBar1.Value = (int)((Settings.u.CalculateLevel(Settings.u.StdScore).current_xp * 100) / Settings.u.CalculateLevel(Settings.u.StdScore).required_xp);
                        this.userImage.ImageLocation = Settings.u.ImagePath;
                        break;
                    }
                case 1:
                    {
                        Username.Text = Settings.u.Username;
                        PP.Text = $"PP: {((int)(Settings.u.TaikoScore.PP)).ToString()}";
                        RankedScore.Text = $"Ranked Score: {Settings.u.TaikoScore.RankedScore.ToString("N0")}";
                        TotalScore.Text = $"Total Score: {Settings.u.TaikoScore.TotalScore.ToString("N0")}";
                        Accuracy.Text = $"Accuracy: {float.Round(Settings.u.TaikoScore.Accuracy * 100, 2)}%";
                        LevelLabel.Text = $"Level: {Settings.u.CalculateLevel(Settings.u.TaikoScore).lvl}";
                        progressBar1.Value = (int)((Settings.u.CalculateLevel(Settings.u.TaikoScore).current_xp * 100) / Settings.u.CalculateLevel(Settings.u.TaikoScore).required_xp);
                        this.userImage.ImageLocation = Settings.u.ImagePath;
                        break;
                    }
                case 2:
                    {
                        Username.Text = Settings.u.Username;
                        PP.Text = $"PP: {((int)(Settings.u.CtbScore.PP)).ToString()}";
                        RankedScore.Text = $"Ranked Score: {Settings.u.CtbScore.RankedScore.ToString("N0")}";
                        TotalScore.Text = $"Total Score: {Settings.u.CtbScore.TotalScore.ToString("N0")}";
                        Accuracy.Text = $"Accuracy: {float.Round(Settings.u.CtbScore.Accuracy * 100, 2)}%";
                        LevelLabel.Text = $"Level: {Settings.u.CalculateLevel(Settings.u.CtbScore).lvl}";
                        progressBar1.Value = (int)((Settings.u.CalculateLevel(Settings.u.CtbScore).current_xp * 100) / Settings.u.CalculateLevel(Settings.u.CtbScore).required_xp);
                        this.userImage.ImageLocation = Settings.u.ImagePath;
                        break;
                    }
                case 3:
                    {
                        Username.Text = Settings.u.Username;
                        PP.Text = $"PP: {((int)(Settings.u.ManiaScore.PP)).ToString()}";
                        RankedScore.Text = $"Ranked Score: {Settings.u.ManiaScore.RankedScore.ToString("N0")}";
                        TotalScore.Text = $"Total Score: {Settings.u.ManiaScore.TotalScore.ToString("N0")}";
                        Accuracy.Text = $"Accuracy: {float.Round(Settings.u.ManiaScore.Accuracy * 100, 2)}%";
                        LevelLabel.Text = $"Level: {Settings.u.CalculateLevel(Settings.u.ManiaScore).lvl}";
                        progressBar1.Value = (int)((Settings.u.CalculateLevel(Settings.u.ManiaScore).current_xp * 100) / Settings.u.CalculateLevel(Settings.u.ManiaScore).required_xp);
                        this.userImage.ImageLocation = Settings.u.ImagePath;
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
        private void onUserNameUpdate(object sender, EventArgs e)
        {
            
        }
        private void StatsTimer_Tick(object sender, EventArgs e)
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
