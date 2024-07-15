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
            listBox1 = new ListBox();
            ClientImage = new PictureBox();
            InstallBtn = new Button();
            RunBtn = new Button();
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
            InstallBtn.Location = new Point(650, 283);
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
            RunBtn.Location = new Point(516, 283);
            RunBtn.Name = "RunBtn";
            RunBtn.Size = new Size(128, 28);
            RunBtn.TabIndex = 2;
            RunBtn.Text = "Run";
            RunBtn.UseVisualStyleBackColor = false;
            RunBtn.Visible = false;
            RunBtn.Click += RunBtn_Click;
            // 
            // tHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 11, 11);
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
        }

        #endregion

        private ListBox listBox1;
        private PictureBox ClientImage;
        private Button InstallBtn;
        private Button RunBtn;
    }
}
