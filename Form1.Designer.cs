namespace WinFormsApp1
{
    partial class From1
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
            button1 = new Button();
            button2 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            folderPathTextBox = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(88, 41);
            button1.Name = "button1";
            button1.Size = new Size(182, 40);
            button1.TabIndex = 0;
            button1.Text = "选择GTAV根目录";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(88, 125);
            button2.Name = "button2";
            button2.Size = new Size(182, 50);
            button2.TabIndex = 1;
            button2.Text = "开始删除";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // folderPathTextBox
            // 
            folderPathTextBox.Location = new Point(12, 89);
            folderPathTextBox.Name = "folderPathTextBox";
            folderPathTextBox.Size = new Size(337, 30);
            folderPathTextBox.TabIndex = 2;
            // 
            // From1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 257);
            Controls.Add(folderPathTextBox);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "From1";
            Text = "GTool";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox folderPathTextBox;
    }
}