namespace titanic_launcher.Tabs
{
    partial class tSettings
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
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            usernameBox = new TextBox();
            button1 = new Button();
            customManifest = new TextBox();
            label4 = new Label();
            SaveCustomManifestBtn = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.Location = new Point(16, 296);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(123, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Hide level progress";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckStateChanged += checkBox1_CheckStateChanged;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(18, 18, 18);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Microsoft YaHei", 9F);
            comboBox1.ForeColor = Color.White;
            comboBox1.Items.AddRange(new object[] { "osu!std", "osu!taiko", "osu!catch", "osu!mania" });
            comboBox1.Location = new Point(178, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 25);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 10F);
            label1.Location = new Point(16, 15);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 2;
            label1.Text = "User Stats Gamemode";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(774, 313);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            label2.Click += label2_Click;
            label2.Paint += label2_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 10F);
            label3.Location = new Point(16, 45);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "Username";
            label3.Click += label1_Click;
            // 
            // usernameBox
            // 
            usernameBox.BackColor = Color.Black;
            usernameBox.BorderStyle = BorderStyle.FixedSingle;
            usernameBox.ForeColor = Color.White;
            usernameBox.Location = new Point(98, 45);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(100, 23);
            usernameBox.TabIndex = 4;
            usernameBox.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(205, 42);
            button1.Name = "button1";
            button1.Size = new Size(75, 26);
            button1.TabIndex = 5;
            button1.Text = "Set";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // customManifest
            // 
            customManifest.BackColor = Color.Black;
            customManifest.BorderStyle = BorderStyle.FixedSingle;
            customManifest.ForeColor = Color.White;
            customManifest.Location = new Point(180, 74);
            customManifest.Name = "customManifest";
            customManifest.Size = new Size(100, 23);
            customManifest.TabIndex = 4;
            customManifest.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei", 10F);
            label4.Location = new Point(16, 73);
            label4.Name = "label4";
            label4.Size = new Size(163, 20);
            label4.TabIndex = 2;
            label4.Text = "Custom client manifest";
            label4.Click += label1_Click;
            // 
            // SaveCustomManifestBtn
            // 
            SaveCustomManifestBtn.FlatStyle = FlatStyle.Flat;
            SaveCustomManifestBtn.Location = new Point(286, 74);
            SaveCustomManifestBtn.Name = "SaveCustomManifestBtn";
            SaveCustomManifestBtn.Size = new Size(75, 26);
            SaveCustomManifestBtn.TabIndex = 5;
            SaveCustomManifestBtn.Text = "Save";
            SaveCustomManifestBtn.UseVisualStyleBackColor = true;
            SaveCustomManifestBtn.Click += SaveCustomManifestBtn_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(367, 74);
            button2.Name = "button2";
            button2.Size = new Size(75, 26);
            button2.TabIndex = 5;
            button2.Text = "Default";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 11, 11);
            Controls.Add(button2);
            Controls.Add(SaveCustomManifestBtn);
            Controls.Add(button1);
            Controls.Add(customManifest);
            Controls.Add(usernameBox);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(checkBox1);
            ForeColor = Color.White;
            Name = "tSettings";
            Size = new Size(797, 328);
            Load += tSettings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        public ComboBox comboBox1;
        private Label label2;
        public CheckBox checkBox1;
        private Label label3;
        public TextBox usernameBox;
        private Button button1;
        public TextBox customManifest;
        private Label label4;
        private Button SaveCustomManifestBtn;
        private Button button2;
    }
}
