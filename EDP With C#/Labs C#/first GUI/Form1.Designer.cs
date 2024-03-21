namespace first_GUI
{
    partial class one
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
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Cursor = Cursors.SizeAll;
            textBox1.Font = new Font("SimSun", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox1.ForeColor = Color.DarkGreen;
            textBox1.Location = new Point(27, 25);
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(272, 25);
            textBox1.TabIndex = 0;
            textBox1.Text = "Hey Faysel";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.WordWrap = false;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.DoubleClick += textBox1_DoubleClick;
            // 
            // one
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(893, 450);
            Controls.Add(textBox1);
            ForeColor = Color.Red;
            Name = "one";
            Text = "Form1";
            Load += one_Load;
            Click += one_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
    }
}