namespace Worksheet_1
{
    partial class Form3
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            length = new GroupBox();
            lengthTextBox2 = new TextBox();
            lengthLabel3 = new Label();
            lengthButton1 = new Button();
            lengthLabel1 = new Label();
            lengthComboBox1 = new ComboBox();
            lengthLabel2 = new Label();
            lengthComboBox2 = new ComboBox();
            lengthLabel4 = new Label();
            groupBox1 = new GroupBox();
            weightLabel4 = new Label();
            weightComboBox2 = new ComboBox();
            weightLabel2 = new Label();
            weightComboBox1 = new ComboBox();
            weightTextBox1 = new TextBox();
            weightLabel3 = new Label();
            weightButton1 = new Button();
            weightLabel1 = new Label();
            length.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // length
            // 
            length.BackColor = Color.Yellow;
            length.BackgroundImageLayout = ImageLayout.None;
            length.Controls.Add(lengthLabel4);
            length.Controls.Add(lengthComboBox2);
            length.Controls.Add(lengthLabel2);
            length.Controls.Add(lengthComboBox1);
            length.Controls.Add(lengthTextBox2);
            length.Controls.Add(lengthLabel3);
            length.Controls.Add(lengthButton1);
            length.Controls.Add(lengthLabel1);
            length.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            length.Location = new Point(78, 61);
            length.Name = "length";
            length.Size = new Size(406, 348);
            length.TabIndex = 7;
            length.TabStop = false;
            length.Text = "length";
            // 
            // lengthTextBox2
            // 
            lengthTextBox2.Location = new Point(211, 152);
            lengthTextBox2.Name = "lengthTextBox2";
            lengthTextBox2.Size = new Size(135, 34);
            lengthTextBox2.TabIndex = 5;
            // 
            // lengthLabel3
            // 
            lengthLabel3.AutoSize = true;
            lengthLabel3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lengthLabel3.Location = new Point(10, 152);
            lengthLabel3.Name = "lengthLabel3";
            lengthLabel3.Size = new Size(195, 32);
            lengthLabel3.TabIndex = 3;
            lengthLabel3.Text = "Value To Convert";
            // 
            // lengthButton1
            // 
            lengthButton1.BackColor = Color.LawnGreen;
            lengthButton1.Location = new Point(276, 268);
            lengthButton1.Name = "lengthButton1";
            lengthButton1.Size = new Size(99, 46);
            lengthButton1.TabIndex = 4;
            lengthButton1.Text = "Convert";
            lengthButton1.UseVisualStyleBackColor = false;
            // 
            // lengthLabel1
            // 
            lengthLabel1.AutoSize = true;
            lengthLabel1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lengthLabel1.Location = new Point(10, 63);
            lengthLabel1.Name = "lengthLabel1";
            lengthLabel1.Size = new Size(147, 30);
            lengthLabel1.TabIndex = 1;
            lengthLabel1.Text = "Convert From";
            // 
            // lengthComboBox1
            // 
            lengthComboBox1.DisplayMember = "KM";
            lengthComboBox1.FormattingEnabled = true;
            lengthComboBox1.Items.AddRange(new object[] { "Meter (m)", "Kilometer (km)", "Centimeter (cm)", "Millimeter (mm)", "Micrometer (µm)", "Nanometer (nm)", "Inch (in)", "Foot (ft)", "Yard (yd)", "Mile (mi)" });
            lengthComboBox1.Location = new Point(154, 57);
            lengthComboBox1.Name = "lengthComboBox1";
            lengthComboBox1.Size = new Size(79, 36);
            lengthComboBox1.TabIndex = 6;
            // 
            // lengthLabel2
            // 
            lengthLabel2.AutoSize = true;
            lengthLabel2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lengthLabel2.Location = new Point(253, 57);
            lengthLabel2.Name = "lengthLabel2";
            lengthLabel2.Size = new Size(36, 30);
            lengthLabel2.TabIndex = 7;
            lengthLabel2.Text = "To";
            // 
            // lengthComboBox2
            // 
            lengthComboBox2.DisplayMember = "Miles";
            lengthComboBox2.FormattingEnabled = true;
            lengthComboBox2.Items.AddRange(new object[] { "Meter (m)", "Kilometer (km)", "Centimeter (cm)", "Millimeter (mm)", "Micrometer (µm)", "Nanometer (nm)", "Inch (in)", "Foot (ft)", "Yard (yd)", "Mile (mi)" });
            lengthComboBox2.Location = new Point(309, 57);
            lengthComboBox2.Name = "lengthComboBox2";
            lengthComboBox2.Size = new Size(79, 36);
            lengthComboBox2.TabIndex = 8;
            // 
            // lengthLabel4
            // 
            lengthLabel4.AutoSize = true;
            lengthLabel4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lengthLabel4.ForeColor = Color.Red;
            lengthLabel4.Location = new Point(66, 228);
            lengthLabel4.Name = "lengthLabel4";
            lengthLabel4.Size = new Size(0, 32);
            lengthLabel4.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Yellow;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(weightLabel4);
            groupBox1.Controls.Add(weightComboBox2);
            groupBox1.Controls.Add(weightLabel2);
            groupBox1.Controls.Add(weightComboBox1);
            groupBox1.Controls.Add(weightTextBox1);
            groupBox1.Controls.Add(weightLabel3);
            groupBox1.Controls.Add(weightButton1);
            groupBox1.Controls.Add(weightLabel1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(585, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(406, 348);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Weight";
            // 
            // weightLabel4
            // 
            weightLabel4.AutoSize = true;
            weightLabel4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            weightLabel4.ForeColor = Color.Red;
            weightLabel4.Location = new Point(66, 228);
            weightLabel4.Name = "weightLabel4";
            weightLabel4.Size = new Size(0, 32);
            weightLabel4.TabIndex = 9;
            // 
            // weightComboBox2
            // 
            weightComboBox2.AutoCompleteCustomSource.AddRange(new string[] { "Gram (g)", "Kilogram (kg)", "Milligram (mg)", "Microgram (µg)", "Pound (lb)", "Ton" });
            weightComboBox2.DisplayMember = "Miles";
            weightComboBox2.FormattingEnabled = true;
            weightComboBox2.Items.AddRange(new object[] { "Meter (m)", "Kilometer (km)", "Centimeter (cm)", "Millimeter (mm)", "Micrometer (µm)", "Nanometer (nm)", "Inch (in)", "Foot (ft)", "Yard (yd)", "Mile (mi)" });
            weightComboBox2.Location = new Point(309, 57);
            weightComboBox2.Name = "weightComboBox2";
            weightComboBox2.Size = new Size(79, 36);
            weightComboBox2.TabIndex = 8;
            // 
            // weightLabel2
            // 
            weightLabel2.AutoSize = true;
            weightLabel2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            weightLabel2.Location = new Point(253, 57);
            weightLabel2.Name = "weightLabel2";
            weightLabel2.Size = new Size(36, 30);
            weightLabel2.TabIndex = 7;
            weightLabel2.Text = "To";
            // 
            // weightComboBox1
            // 
            weightComboBox1.DisplayMember = "KM";
            weightComboBox1.FormattingEnabled = true;
            weightComboBox1.Items.AddRange(new object[] { "Gram (g)", "Kilogram (kg)", "Milligram (mg)", "Microgram (µg)", "Pound (lb)", "Ton" });
            weightComboBox1.Location = new Point(154, 57);
            weightComboBox1.Name = "weightComboBox1";
            weightComboBox1.Size = new Size(79, 36);
            weightComboBox1.TabIndex = 6;
            // 
            // weightTextBox1
            // 
            weightTextBox1.Location = new Point(211, 152);
            weightTextBox1.Name = "weightTextBox1";
            weightTextBox1.Size = new Size(135, 34);
            weightTextBox1.TabIndex = 5;
            // 
            // weightLabel3
            // 
            weightLabel3.AutoSize = true;
            weightLabel3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            weightLabel3.Location = new Point(10, 152);
            weightLabel3.Name = "weightLabel3";
            weightLabel3.Size = new Size(195, 32);
            weightLabel3.TabIndex = 3;
            weightLabel3.Text = "Value To Convert";
            // 
            // weightButton1
            // 
            weightButton1.BackColor = Color.LawnGreen;
            weightButton1.Location = new Point(276, 268);
            weightButton1.Name = "weightButton1";
            weightButton1.Size = new Size(99, 46);
            weightButton1.TabIndex = 4;
            weightButton1.Text = "Convert";
            weightButton1.UseVisualStyleBackColor = false;
            // 
            // weightLabel1
            // 
            weightLabel1.AutoSize = true;
            weightLabel1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            weightLabel1.Location = new Point(10, 63);
            weightLabel1.Name = "weightLabel1";
            weightLabel1.Size = new Size(147, 30);
            weightLabel1.TabIndex = 1;
            weightLabel1.Text = "Convert From";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1172, 1025);
            Controls.Add(groupBox1);
            Controls.Add(length);
            Name = "Form3";
            Text = "Form3";
            length.ResumeLayout(false);
            length.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox length;
        private Label lengthLabel4;
        private ComboBox lengthComboBox2;
        private Label lengthLabel2;
        private ComboBox lengthComboBox1;
        private TextBox lengthTextBox2;
        private Label lengthLabel3;
        private Button lengthButton1;
        private Label lengthLabel1;
        private GroupBox groupBox1;
        private Label weightLabel4;
        private ComboBox weightComboBox2;
        private Label weightLabel2;
        private ComboBox weightComboBox1;
        private TextBox weightTextBox1;
        private Label weightLabel3;
        private Button weightButton1;
        private Label weightLabel1;
    }
}