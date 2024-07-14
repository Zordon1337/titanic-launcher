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
            // 
            // tHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 11, 11);
            Controls.Add(listBox1);
            ForeColor = Color.White;
            Name = "tHome";
            Size = new Size(797, 328);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
    }
}
