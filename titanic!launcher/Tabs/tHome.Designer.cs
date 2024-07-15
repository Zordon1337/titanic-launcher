namespace titanic_launcher.Tabs
{
    partial class tHome
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listBox1 = new ListBox();
            ClientImage = new PictureBox();
            InstallBtn = new Button();
            RunBtn = new Button();
            BeatmapsLabel = new Label();
            SkinsLabel = new Label();
            ShowGameFilesBtn = new Button();
            UninstallBtn = new Button();
            RefreshManifest = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            RefreshDetails = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)ClientImage).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(17, 17, 17);
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.ForeColor = Color.White;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(-2, -2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(189, 330);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // ClientImage
            // 
            ClientImage.BackColor = Color.Black;
            ClientImage.Location = new Point(187, -1);
            ClientImage.Name = "ClientImage";
            ClientImage.Size = new Size(610, 215);
            ClientImage.SizeMode = PictureBoxSizeMode.Zoom;
            ClientImage.TabIndex = 1;
            ClientImage.TabStop = false;
            ClientImage.Click += ClientImage_Click;
            // 
            // InstallBtn
            // 
            InstallBtn.BackColor = Color.Blue;
            InstallBtn.FlatStyle = FlatStyle.Popup;
            InstallBtn.Location = new Point(650, 287);
            InstallBtn.Name = "InstallBtn";
            InstallBtn.Size = new Size(128, 28);
            InstallBtn.TabIndex = 2;
            InstallBtn.Text = "Install";
            InstallBtn.UseVisualStyleBackColor = false;
            InstallBtn.Visible = false;
            InstallBtn.Click += button1_Click;
            // 
            // RunBtn
            // 
            RunBtn.BackColor = Color.Green;
            RunBtn.FlatStyle = FlatStyle.Popup;
            RunBtn.Location = new Point(193, 220);
            RunBtn.Name = "RunBtn";
            RunBtn.Size = new Size(128, 28);
            RunBtn.TabIndex = 2;
            RunBtn.Text = "Run";
            RunBtn.UseVisualStyleBackColor = false;
            RunBtn.Visible = false;
            RunBtn.Click += RunBtn_Click;
            // 
            // BeatmapsLabel
            // 
            BeatmapsLabel.AutoSize = true;
            BeatmapsLabel.Location = new Point(193, 251);
            BeatmapsLabel.Name = "BeatmapsLabel";
            BeatmapsLabel.Size = new Size(65, 15);
            BeatmapsLabel.TabIndex = 3;
            BeatmapsLabel.Text = "Beatmaps: ";
            BeatmapsLabel.Visible = false;
            // 
            // SkinsLabel
            // 
            SkinsLabel.AutoSize = true;
            SkinsLabel.Location = new Point(193, 266);
            SkinsLabel.Name = "SkinsLabel";
            SkinsLabel.Size = new Size(40, 15);
            SkinsLabel.TabIndex = 3;
            SkinsLabel.Text = "Skins: ";
            SkinsLabel.Visible = false;
            // 
            // ShowGameFilesBtn
            // 
            ShowGameFilesBtn.BackColor = Color.LightSeaGreen;
            ShowGameFilesBtn.FlatStyle = FlatStyle.Popup;
            ShowGameFilesBtn.Location = new Point(327, 220);
            ShowGameFilesBtn.Name = "ShowGameFilesBtn";
            ShowGameFilesBtn.Size = new Size(128, 28);
            ShowGameFilesBtn.TabIndex = 2;
            ShowGameFilesBtn.Text = "Show Gamefiles";
            ShowGameFilesBtn.UseVisualStyleBackColor = false;
            ShowGameFilesBtn.Visible = false;
            ShowGameFilesBtn.Click += ShowGameFilesBtn_Click;
            // 
            // UninstallBtn
            // 
            UninstallBtn.BackColor = Color.Red;
            UninstallBtn.FlatStyle = FlatStyle.Popup;
            UninstallBtn.Location = new Point(461, 220);
            UninstallBtn.Name = "UninstallBtn";
            UninstallBtn.Size = new Size(128, 28);
            UninstallBtn.TabIndex = 2;
            UninstallBtn.Text = "Uninstall";
            UninstallBtn.UseVisualStyleBackColor = false;
            UninstallBtn.Visible = false;
            UninstallBtn.Click += UninstallBtn_Click;
            // 
            // RefreshManifest
            // 
            RefreshManifest.Interval = 1000;
            RefreshManifest.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 281);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 3;
            label1.Text = "Last Played: ";
            label1.Visible = false;
            // 
            // RefreshDetails
            // 
            RefreshDetails.Tick += timer1_Tick_1;
            // 
            // tHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 11, 11);
            Controls.Add(SkinsLabel);
            Controls.Add(label1);
            Controls.Add(BeatmapsLabel);
            Controls.Add(ShowGameFilesBtn);
            Controls.Add(UninstallBtn);
            Controls.Add(RunBtn);
            Controls.Add(InstallBtn);
            Controls.Add(ClientImage);
            Controls.Add(listBox1);
            ForeColor = Color.White;
            Name = "tHome";
            Size = new Size(797, 328);
            Load += tHome_Load;
            ((System.ComponentModel.ISupportInitialize)ClientImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private PictureBox ClientImage;
        private Button InstallBtn;
        private Button RunBtn;
        private Label BeatmapsLabel;
        private Label SkinsLabel;
        private Button ShowGameFilesBtn;
        private Button UninstallBtn;
        private System.Windows.Forms.Timer RefreshManifest;
        private Label label1;
        private System.Windows.Forms.Timer RefreshDetails;
    }
}
