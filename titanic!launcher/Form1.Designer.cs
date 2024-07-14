namespace titanic_launcher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userInfopanel = new Panel();
            PP = new Label();
            RankedScore = new Label();
            TotalScore = new Label();
            Username = new Label();
            userImage = new PictureBox();
            TabsPanel = new Panel();
            tabSettings = new Button();
            tabHome = new Button();
            container = new Panel();
            Accuracy = new Label();
            userInfopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userImage).BeginInit();
            TabsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // userInfopanel
            // 
            userInfopanel.BorderStyle = BorderStyle.FixedSingle;
            userInfopanel.Controls.Add(Accuracy);
            userInfopanel.Controls.Add(PP);
            userInfopanel.Controls.Add(RankedScore);
            userInfopanel.Controls.Add(TotalScore);
            userInfopanel.Controls.Add(Username);
            userInfopanel.Controls.Add(userImage);
            userInfopanel.Location = new Point(1, 362);
            userInfopanel.Name = "userInfopanel";
            userInfopanel.Size = new Size(798, 86);
            userInfopanel.TabIndex = 0;
            userInfopanel.Paint += userInfopanel_Paint;
            // 
            // PP
            // 
            PP.AutoSize = true;
            PP.Location = new Point(88, 50);
            PP.Name = "PP";
            PP.Size = new Size(24, 15);
            PP.TabIndex = 1;
            PP.Text = "PP:";
            // 
            // RankedScore
            // 
            RankedScore.AutoSize = true;
            RankedScore.Location = new Point(88, 35);
            RankedScore.Name = "RankedScore";
            RankedScore.Size = new Size(84, 15);
            RankedScore.TabIndex = 1;
            RankedScore.Text = "Ranked Score: ";
            // 
            // TotalScore
            // 
            TotalScore.AutoSize = true;
            TotalScore.Location = new Point(88, 20);
            TotalScore.Name = "TotalScore";
            TotalScore.Size = new Size(70, 15);
            TotalScore.TabIndex = 1;
            TotalScore.Text = "Total Score: ";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(88, 5);
            Username.Name = "Username";
            Username.Size = new Size(60, 15);
            Username.TabIndex = 1;
            Username.Text = "Username";
            // 
            // userImage
            // 
            userImage.Location = new Point(3, 5);
            userImage.Name = "userImage";
            userImage.Size = new Size(80, 75);
            userImage.SizeMode = PictureBoxSizeMode.StretchImage;
            userImage.TabIndex = 0;
            userImage.TabStop = false;
            // 
            // TabsPanel
            // 
            TabsPanel.BackColor = Color.FromArgb(20, 20, 20);
            TabsPanel.Controls.Add(tabSettings);
            TabsPanel.Controls.Add(tabHome);
            TabsPanel.Location = new Point(1, -1);
            TabsPanel.Name = "TabsPanel";
            TabsPanel.Size = new Size(798, 38);
            TabsPanel.TabIndex = 1;
            // 
            // tabSettings
            // 
            tabSettings.BackColor = Color.FromArgb(192, 0, 0);
            tabSettings.FlatStyle = FlatStyle.Popup;
            tabSettings.Location = new Point(118, -1);
            tabSettings.Name = "tabSettings";
            tabSettings.Size = new Size(112, 38);
            tabSettings.TabIndex = 0;
            tabSettings.Text = "Settings";
            tabSettings.UseVisualStyleBackColor = false;
            tabSettings.Click += tabSettings_Click;
            // 
            // tabHome
            // 
            tabHome.BackColor = Color.FromArgb(192, 0, 0);
            tabHome.FlatStyle = FlatStyle.Popup;
            tabHome.Location = new Point(0, -1);
            tabHome.Name = "tabHome";
            tabHome.Size = new Size(112, 38);
            tabHome.TabIndex = 0;
            tabHome.Text = "Home";
            tabHome.UseVisualStyleBackColor = false;
            tabHome.Click += tabHome_Click;
            // 
            // container
            // 
            container.Location = new Point(2, 34);
            container.Name = "container";
            container.Size = new Size(797, 328);
            container.TabIndex = 2;
            container.Paint += container_Paint;
            // 
            // Accuracy
            // 
            Accuracy.AutoSize = true;
            Accuracy.Location = new Point(89, 65);
            Accuracy.Name = "Accuracy";
            Accuracy.Size = new Size(59, 15);
            Accuracy.TabIndex = 1;
            Accuracy.Text = "Accuracy:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 11, 11);
            ClientSize = new Size(800, 450);
            Controls.Add(container);
            Controls.Add(TabsPanel);
            Controls.Add(userInfopanel);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "osu!titanic";
            Load += Form1_Load;
            userInfopanel.ResumeLayout(false);
            userInfopanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userImage).EndInit();
            TabsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel userInfopanel;
        private PictureBox userImage;
        private Label RankedScore;
        private Label TotalScore;
        private Label Username;
        private Label PP;
        private Panel TabsPanel;
        private Button tabSettings;
        private Button tabHome;
        private Panel container;
        private Label Accuracy;
    }
}
