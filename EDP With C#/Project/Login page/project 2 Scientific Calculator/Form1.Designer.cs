namespace project_2_Scientific_Calculator
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
            BinomialPanel = new Panel();
            binomialOperatorLabel = new Label();
            button15 = new Button();
            label2 = new Label();
            label1 = new Label();
            binomialTextBox2 = new TextBox();
            result = new Label();
            BinomialTextBox1 = new TextBox();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button81 = new Button();
            button80 = new Button();
            button79 = new Button();
            button78 = new Button();
            button76 = new Button();
            button75 = new Button();
            button74 = new Button();
            button69 = new Button();
            button68 = new Button();
            button67 = new Button();
            button66 = new Button();
            button64 = new Button();
            button63 = new Button();
            button62 = new Button();
            button57 = new Button();
            button56 = new Button();
            button55 = new Button();
            button54 = new Button();
            button52 = new Button();
            button51 = new Button();
            button46 = new Button();
            button45 = new Button();
            button44 = new Button();
            button43 = new Button();
            button34 = new Button();
            button33 = new Button();
            button32 = new Button();
            button31 = new Button();
            button22 = new Button();
            button21 = new Button();
            button20 = new Button();
            button19 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button11 = new Button();
            button12 = new Button();
            monomial = new Panel();
            button14 = new Button();
            label4 = new Label();
            label5 = new Label();
            monomialTextBox = new TextBox();
            mainPanel = new Panel();
            button13 = new Button();
            label6 = new Label();
            comboBox1 = new ComboBox();
            BinomialPanel.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            monomial.SuspendLayout();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BinomialPanel
            // 
            BinomialPanel.BackColor = SystemColors.ControlLight;
            BinomialPanel.Controls.Add(binomialOperatorLabel);
            BinomialPanel.Controls.Add(button15);
            BinomialPanel.Controls.Add(label2);
            BinomialPanel.Controls.Add(label1);
            BinomialPanel.Controls.Add(binomialTextBox2);
            BinomialPanel.Controls.Add(result);
            BinomialPanel.Controls.Add(BinomialTextBox1);
            BinomialPanel.Location = new Point(0, 0);
            BinomialPanel.Margin = new Padding(0);
            BinomialPanel.Name = "BinomialPanel";
            BinomialPanel.Size = new Size(403, 310);
            BinomialPanel.TabIndex = 0;
            // 
            // binomialOperatorLabel
            // 
            binomialOperatorLabel.AutoSize = true;
            binomialOperatorLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            binomialOperatorLabel.Location = new Point(123, 122);
            binomialOperatorLabel.Name = "binomialOperatorLabel";
            binomialOperatorLabel.Size = new Size(0, 32);
            binomialOperatorLabel.TabIndex = 6;
            // 
            // button15
            // 
            button15.Location = new Point(336, 0);
            button15.Name = "button15";
            button15.Size = new Size(64, 29);
            button15.TabIndex = 5;
            button15.Text = "Back";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(56, 164);
            label2.Name = "label2";
            label2.Size = new Size(198, 32);
            label2.TabIndex = 4;
            label2.Text = "Second Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(56, 20);
            label1.Name = "label1";
            label1.Size = new Size(164, 32);
            label1.TabIndex = 3;
            label1.Text = "First Number";
            // 
            // binomialTextBox2
            // 
            binomialTextBox2.Location = new Point(56, 209);
            binomialTextBox2.Multiline = true;
            binomialTextBox2.Name = "binomialTextBox2";
            binomialTextBox2.Size = new Size(181, 45);
            binomialTextBox2.TabIndex = 2;
            binomialTextBox2.Enter += binomialTextBox2_Enter;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            result.Location = new Point(56, 261);
            result.Name = "result";
            result.Size = new Size(98, 32);
            result.TabIndex = 1;
            result.Text = "Result: ";
            // 
            // BinomialTextBox1
            // 
            BinomialTextBox1.Location = new Point(56, 57);
            BinomialTextBox1.Multiline = true;
            BinomialTextBox1.Name = "BinomialTextBox1";
            BinomialTextBox1.Size = new Size(181, 45);
            BinomialTextBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1095, 637);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 9;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.3456469F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 88.65435F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 124F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 142F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 24F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 149F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 172F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 179F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 166F));
            tableLayoutPanel1.Controls.Add(button81, 8, 6);
            tableLayoutPanel1.Controls.Add(button80, 7, 6);
            tableLayoutPanel1.Controls.Add(button79, 6, 6);
            tableLayoutPanel1.Controls.Add(button78, 5, 6);
            tableLayoutPanel1.Controls.Add(button76, 3, 6);
            tableLayoutPanel1.Controls.Add(button75, 2, 6);
            tableLayoutPanel1.Controls.Add(button74, 1, 6);
            tableLayoutPanel1.Controls.Add(button69, 8, 5);
            tableLayoutPanel1.Controls.Add(button68, 7, 5);
            tableLayoutPanel1.Controls.Add(button67, 6, 5);
            tableLayoutPanel1.Controls.Add(button66, 5, 5);
            tableLayoutPanel1.Controls.Add(button64, 3, 5);
            tableLayoutPanel1.Controls.Add(button63, 2, 5);
            tableLayoutPanel1.Controls.Add(button62, 1, 5);
            tableLayoutPanel1.Controls.Add(button57, 8, 4);
            tableLayoutPanel1.Controls.Add(button56, 7, 4);
            tableLayoutPanel1.Controls.Add(button55, 6, 4);
            tableLayoutPanel1.Controls.Add(button54, 5, 4);
            tableLayoutPanel1.Controls.Add(button52, 3, 4);
            tableLayoutPanel1.Controls.Add(button51, 2, 4);
            tableLayoutPanel1.Controls.Add(button46, 8, 3);
            tableLayoutPanel1.Controls.Add(button45, 7, 3);
            tableLayoutPanel1.Controls.Add(button44, 6, 3);
            tableLayoutPanel1.Controls.Add(button43, 5, 3);
            tableLayoutPanel1.Controls.Add(button34, 8, 2);
            tableLayoutPanel1.Controls.Add(button33, 7, 2);
            tableLayoutPanel1.Controls.Add(button32, 6, 2);
            tableLayoutPanel1.Controls.Add(button31, 5, 2);
            tableLayoutPanel1.Controls.Add(button22, 8, 1);
            tableLayoutPanel1.Controls.Add(button21, 7, 1);
            tableLayoutPanel1.Controls.Add(button20, 6, 1);
            tableLayoutPanel1.Controls.Add(button19, 5, 1);
            tableLayoutPanel1.Controls.Add(button10, 8, 0);
            tableLayoutPanel1.Controls.Add(button9, 7, 0);
            tableLayoutPanel1.Controls.Add(button8, 6, 0);
            tableLayoutPanel1.Controls.Add(button7, 5, 0);
            tableLayoutPanel1.Controls.Add(button2, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 1, 4);
            tableLayoutPanel1.Controls.Add(button3, 2, 7);
            tableLayoutPanel1.Controls.Add(button4, 5, 7);
            tableLayoutPanel1.Controls.Add(button5, 6, 7);
            tableLayoutPanel1.Controls.Add(button6, 7, 7);
            tableLayoutPanel1.Controls.Add(button11, 8, 7);
            tableLayoutPanel1.Controls.Add(button12, 3, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.65035F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.34965F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 89F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 91F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 86F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.Size = new Size(1095, 637);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button81
            // 
            button81.BackColor = Color.Red;
            button81.Dock = DockStyle.Fill;
            button81.FlatAppearance.BorderSize = 0;
            button81.FlatStyle = FlatStyle.Flat;
            button81.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point);
            button81.Location = new Point(931, 483);
            button81.Name = "button81";
            button81.Size = new Size(161, 80);
            button81.TabIndex = 80;
            button81.Text = "Del";
            button81.UseVisualStyleBackColor = false;
            // 
            // button80
            // 
            button80.BackColor = Color.White;
            button80.Dock = DockStyle.Fill;
            button80.FlatAppearance.BorderSize = 0;
            button80.FlatStyle = FlatStyle.Flat;
            button80.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button80.Location = new Point(752, 483);
            button80.Name = "button80";
            button80.Size = new Size(173, 80);
            button80.TabIndex = 79;
            button80.Text = "00";
            button80.UseVisualStyleBackColor = false;
            button80.Click += button80_Click;
            // 
            // button79
            // 
            button79.BackColor = Color.White;
            button79.Dock = DockStyle.Fill;
            button79.FlatAppearance.BorderSize = 0;
            button79.FlatStyle = FlatStyle.Flat;
            button79.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button79.Location = new Point(580, 483);
            button79.Name = "button79";
            button79.Size = new Size(166, 80);
            button79.TabIndex = 78;
            button79.Text = "Rad";
            button79.UseVisualStyleBackColor = false;
            button79.Click += button79_Click;
            // 
            // button78
            // 
            button78.BackColor = Color.White;
            button78.Dock = DockStyle.Fill;
            button78.FlatAppearance.BorderSize = 0;
            button78.FlatStyle = FlatStyle.Flat;
            button78.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button78.Location = new Point(431, 483);
            button78.Name = "button78";
            button78.Size = new Size(143, 80);
            button78.TabIndex = 77;
            button78.Text = "Degree";
            button78.UseVisualStyleBackColor = false;
            button78.Click += button78_Click;
            // 
            // button76
            // 
            button76.BackColor = Color.White;
            button76.Dock = DockStyle.Fill;
            button76.FlatAppearance.BorderSize = 0;
            button76.FlatStyle = FlatStyle.Flat;
            button76.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button76.Location = new Point(265, 483);
            button76.Name = "button76";
            button76.Size = new Size(136, 80);
            button76.TabIndex = 75;
            button76.Text = "9";
            button76.UseVisualStyleBackColor = false;
            button76.Click += button76_Click;
            // 
            // button75
            // 
            button75.BackColor = Color.White;
            button75.Dock = DockStyle.Fill;
            button75.FlatAppearance.BorderSize = 0;
            button75.FlatStyle = FlatStyle.Flat;
            button75.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button75.Location = new Point(141, 483);
            button75.Name = "button75";
            button75.Size = new Size(118, 80);
            button75.TabIndex = 74;
            button75.Text = "8";
            button75.UseVisualStyleBackColor = false;
            button75.Click += button75_Click;
            // 
            // button74
            // 
            button74.BackColor = Color.White;
            button74.Dock = DockStyle.Fill;
            button74.FlatAppearance.BorderSize = 0;
            button74.FlatStyle = FlatStyle.Flat;
            button74.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button74.Location = new Point(18, 483);
            button74.Name = "button74";
            button74.Size = new Size(117, 80);
            button74.TabIndex = 73;
            button74.Text = "7";
            button74.UseVisualStyleBackColor = false;
            button74.Click += button74_Click;
            // 
            // button69
            // 
            button69.BackColor = Color.Lime;
            button69.Dock = DockStyle.Fill;
            button69.FlatAppearance.BorderSize = 0;
            button69.FlatStyle = FlatStyle.Flat;
            button69.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button69.Location = new Point(931, 407);
            button69.Name = "button69";
            button69.Size = new Size(161, 70);
            button69.TabIndex = 68;
            button69.Text = "Clear";
            button69.UseVisualStyleBackColor = false;
            // 
            // button68
            // 
            button68.BackColor = Color.White;
            button68.Dock = DockStyle.Fill;
            button68.FlatAppearance.BorderSize = 0;
            button68.FlatStyle = FlatStyle.Flat;
            button68.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button68.Location = new Point(752, 407);
            button68.Name = "button68";
            button68.Size = new Size(173, 70);
            button68.TabIndex = 67;
            button68.Text = "tanh";
            button68.UseVisualStyleBackColor = false;
            button68.Click += button68_Click;
            // 
            // button67
            // 
            button67.BackColor = Color.White;
            button67.Dock = DockStyle.Fill;
            button67.FlatAppearance.BorderSize = 0;
            button67.FlatStyle = FlatStyle.Flat;
            button67.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button67.Location = new Point(580, 407);
            button67.Name = "button67";
            button67.Size = new Size(166, 70);
            button67.TabIndex = 66;
            button67.Text = "cosh";
            button67.UseVisualStyleBackColor = false;
            button67.Click += button67_Click;
            // 
            // button66
            // 
            button66.BackColor = Color.White;
            button66.Dock = DockStyle.Fill;
            button66.FlatAppearance.BorderSize = 0;
            button66.FlatStyle = FlatStyle.Flat;
            button66.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button66.Location = new Point(431, 407);
            button66.Name = "button66";
            button66.Size = new Size(143, 70);
            button66.TabIndex = 65;
            button66.Text = "Sinh";
            button66.UseVisualStyleBackColor = false;
            button66.Click += button66_Click;
            // 
            // button64
            // 
            button64.BackColor = Color.White;
            button64.Dock = DockStyle.Fill;
            button64.FlatAppearance.BorderSize = 0;
            button64.FlatStyle = FlatStyle.Flat;
            button64.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button64.Location = new Point(265, 407);
            button64.Name = "button64";
            button64.Size = new Size(136, 70);
            button64.TabIndex = 63;
            button64.Text = "6";
            button64.UseVisualStyleBackColor = false;
            button64.Click += button64_Click;
            // 
            // button63
            // 
            button63.BackColor = Color.White;
            button63.Dock = DockStyle.Fill;
            button63.FlatAppearance.BorderSize = 0;
            button63.FlatStyle = FlatStyle.Flat;
            button63.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button63.Location = new Point(141, 407);
            button63.Name = "button63";
            button63.Size = new Size(118, 70);
            button63.TabIndex = 62;
            button63.Text = "5";
            button63.UseVisualStyleBackColor = false;
            button63.Click += button63_Click;
            // 
            // button62
            // 
            button62.BackColor = Color.White;
            button62.Dock = DockStyle.Fill;
            button62.FlatAppearance.BorderSize = 0;
            button62.FlatStyle = FlatStyle.Flat;
            button62.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button62.Location = new Point(18, 407);
            button62.Name = "button62";
            button62.Size = new Size(117, 70);
            button62.TabIndex = 61;
            button62.Text = "4";
            button62.UseVisualStyleBackColor = false;
            button62.Click += button62_Click;
            // 
            // button57
            // 
            button57.BackColor = Color.White;
            button57.Dock = DockStyle.Fill;
            button57.FlatAppearance.BorderSize = 0;
            button57.FlatStyle = FlatStyle.Flat;
            button57.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            button57.Location = new Point(931, 316);
            button57.Name = "button57";
            button57.Size = new Size(161, 85);
            button57.TabIndex = 56;
            button57.Text = "=";
            button57.UseVisualStyleBackColor = false;
            button57.Click += button57_Click;
            // 
            // button56
            // 
            button56.BackColor = Color.White;
            button56.Dock = DockStyle.Fill;
            button56.FlatAppearance.BorderSize = 0;
            button56.FlatStyle = FlatStyle.Flat;
            button56.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button56.Location = new Point(752, 316);
            button56.Name = "button56";
            button56.Size = new Size(173, 85);
            button56.TabIndex = 55;
            button56.Text = "arctan";
            button56.UseVisualStyleBackColor = false;
            button56.Click += button56_Click;
            // 
            // button55
            // 
            button55.BackColor = Color.White;
            button55.Dock = DockStyle.Fill;
            button55.FlatAppearance.BorderSize = 0;
            button55.FlatStyle = FlatStyle.Flat;
            button55.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button55.Location = new Point(580, 316);
            button55.Name = "button55";
            button55.Size = new Size(166, 85);
            button55.TabIndex = 54;
            button55.Text = "arcsin";
            button55.UseVisualStyleBackColor = false;
            button55.Click += button55_Click;
            // 
            // button54
            // 
            button54.BackColor = Color.White;
            button54.Dock = DockStyle.Fill;
            button54.FlatAppearance.BorderSize = 0;
            button54.FlatStyle = FlatStyle.Flat;
            button54.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button54.Location = new Point(431, 316);
            button54.Name = "button54";
            button54.Size = new Size(143, 85);
            button54.TabIndex = 53;
            button54.Text = "arccos";
            button54.UseVisualStyleBackColor = false;
            button54.Click += button54_Click;
            // 
            // button52
            // 
            button52.BackColor = Color.White;
            button52.Dock = DockStyle.Fill;
            button52.FlatAppearance.BorderSize = 0;
            button52.FlatStyle = FlatStyle.Flat;
            button52.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button52.Location = new Point(265, 316);
            button52.Name = "button52";
            button52.Size = new Size(136, 85);
            button52.TabIndex = 51;
            button52.Text = "3";
            button52.UseVisualStyleBackColor = false;
            button52.Click += button52_Click;
            // 
            // button51
            // 
            button51.BackColor = Color.White;
            button51.Dock = DockStyle.Fill;
            button51.FlatAppearance.BorderSize = 0;
            button51.FlatStyle = FlatStyle.Flat;
            button51.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button51.Location = new Point(141, 316);
            button51.Name = "button51";
            button51.Size = new Size(118, 85);
            button51.TabIndex = 50;
            button51.Text = "2";
            button51.UseVisualStyleBackColor = false;
            button51.Click += button51_Click;
            // 
            // button46
            // 
            button46.BackColor = Color.White;
            button46.Dock = DockStyle.Fill;
            button46.FlatAppearance.BorderSize = 0;
            button46.FlatStyle = FlatStyle.Flat;
            button46.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            button46.Location = new Point(931, 227);
            button46.Name = "button46";
            button46.Size = new Size(161, 83);
            button46.TabIndex = 45;
            button46.Text = "e";
            button46.UseVisualStyleBackColor = false;
            button46.Click += button46_Click;
            // 
            // button45
            // 
            button45.BackColor = Color.White;
            button45.Dock = DockStyle.Fill;
            button45.FlatAppearance.BorderSize = 0;
            button45.FlatStyle = FlatStyle.Flat;
            button45.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            button45.Location = new Point(752, 227);
            button45.Name = "button45";
            button45.Size = new Size(173, 83);
            button45.TabIndex = 44;
            button45.Text = "π";
            button45.UseVisualStyleBackColor = false;
            button45.Click += button45_Click;
            // 
            // button44
            // 
            button44.BackColor = Color.White;
            button44.Dock = DockStyle.Fill;
            button44.FlatAppearance.BorderSize = 0;
            button44.FlatStyle = FlatStyle.Flat;
            button44.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            button44.Location = new Point(580, 227);
            button44.Name = "button44";
            button44.Size = new Size(166, 83);
            button44.TabIndex = 43;
            button44.Text = "ln";
            button44.UseVisualStyleBackColor = false;
            button44.Click += button44_Click;
            // 
            // button43
            // 
            button43.BackColor = Color.White;
            button43.Dock = DockStyle.Fill;
            button43.FlatAppearance.BorderSize = 0;
            button43.FlatStyle = FlatStyle.Flat;
            button43.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            button43.Location = new Point(431, 227);
            button43.Name = "button43";
            button43.Size = new Size(143, 83);
            button43.TabIndex = 42;
            button43.Text = "x";
            button43.UseVisualStyleBackColor = false;
            button43.Click += button43_Click;
            // 
            // button34
            // 
            button34.BackColor = Color.White;
            button34.Dock = DockStyle.Fill;
            button34.FlatAppearance.BorderSize = 0;
            button34.FlatStyle = FlatStyle.Flat;
            button34.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point);
            button34.Location = new Point(931, 146);
            button34.Name = "button34";
            button34.Size = new Size(161, 75);
            button34.TabIndex = 33;
            button34.Text = "tan";
            button34.UseVisualStyleBackColor = false;
            button34.Click += button34_Click;
            // 
            // button33
            // 
            button33.BackColor = Color.White;
            button33.Dock = DockStyle.Fill;
            button33.FlatAppearance.BorderSize = 0;
            button33.FlatStyle = FlatStyle.Flat;
            button33.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            button33.Location = new Point(752, 146);
            button33.Name = "button33";
            button33.Size = new Size(173, 75);
            button33.TabIndex = 32;
            button33.Text = "|X|";
            button33.UseVisualStyleBackColor = false;
            button33.Click += button33_Click;
            // 
            // button32
            // 
            button32.BackColor = Color.White;
            button32.Dock = DockStyle.Fill;
            button32.FlatAppearance.BorderSize = 0;
            button32.FlatStyle = FlatStyle.Flat;
            button32.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button32.Location = new Point(580, 146);
            button32.Name = "button32";
            button32.Size = new Size(166, 75);
            button32.TabIndex = 31;
            button32.Text = "Log";
            button32.UseVisualStyleBackColor = false;
            button32.Click += button32_Click;
            // 
            // button31
            // 
            button31.BackColor = Color.White;
            button31.Dock = DockStyle.Fill;
            button31.FlatAppearance.BorderSize = 0;
            button31.FlatStyle = FlatStyle.Flat;
            button31.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            button31.Location = new Point(431, 146);
            button31.Name = "button31";
            button31.Size = new Size(143, 75);
            button31.TabIndex = 30;
            button31.Text = "/";
            button31.UseVisualStyleBackColor = false;
            button31.Click += button31_Click_1;
            // 
            // button22
            // 
            button22.BackColor = Color.White;
            button22.Dock = DockStyle.Fill;
            button22.FlatAppearance.BorderSize = 0;
            button22.FlatStyle = FlatStyle.Flat;
            button22.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point);
            button22.Location = new Point(931, 74);
            button22.Name = "button22";
            button22.Size = new Size(161, 66);
            button22.TabIndex = 21;
            button22.Text = "Cos";
            button22.UseVisualStyleBackColor = false;
            button22.Click += button22_Click;
            // 
            // button21
            // 
            button21.BackColor = Color.White;
            button21.Dock = DockStyle.Fill;
            button21.FlatAppearance.BorderSize = 0;
            button21.FlatStyle = FlatStyle.Flat;
            button21.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            button21.Location = new Point(752, 74);
            button21.Name = "button21";
            button21.Size = new Size(173, 66);
            button21.TabIndex = 20;
            button21.Text = "n!";
            button21.UseVisualStyleBackColor = false;
            button21.Click += button21_Click;
            // 
            // button20
            // 
            button20.BackColor = Color.White;
            button20.Dock = DockStyle.Fill;
            button20.FlatAppearance.BorderSize = 0;
            button20.FlatStyle = FlatStyle.Flat;
            button20.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            button20.Location = new Point(580, 74);
            button20.Name = "button20";
            button20.Size = new Size(166, 66);
            button20.TabIndex = 19;
            button20.Text = "√";
            button20.UseVisualStyleBackColor = false;
            button20.Click += button20_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.White;
            button19.Dock = DockStyle.Fill;
            button19.FlatAppearance.BorderSize = 0;
            button19.FlatStyle = FlatStyle.Flat;
            button19.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
            button19.Location = new Point(431, 74);
            button19.Name = "button19";
            button19.Size = new Size(143, 66);
            button19.TabIndex = 18;
            button19.Text = "-";
            button19.UseVisualStyleBackColor = false;
            button19.Click += button19_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.White;
            button10.Dock = DockStyle.Fill;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(931, 3);
            button10.Name = "button10";
            button10.Size = new Size(161, 65);
            button10.TabIndex = 9;
            button10.Text = "Sin";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.Dock = DockStyle.Fill;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(752, 3);
            button9.Name = "button9";
            button9.Size = new Size(173, 65);
            button9.TabIndex = 8;
            button9.Text = "Abs";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.Dock = DockStyle.Fill;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(580, 3);
            button8.Name = "button8";
            button8.Size = new Size(166, 65);
            button8.TabIndex = 7;
            button8.Text = "Exp";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Dock = DockStyle.Fill;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(431, 3);
            button7.Name = "button7";
            button7.Size = new Size(143, 65);
            button7.TabIndex = 6;
            button7.Text = "+";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(9, 65);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(18, 316);
            button1.Name = "button1";
            button1.Size = new Size(117, 85);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Dock = DockStyle.Fill;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(141, 569);
            button3.Name = "button3";
            button3.Size = new Size(118, 65);
            button3.TabIndex = 82;
            button3.Text = "0";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(431, 569);
            button4.Name = "button4";
            button4.Size = new Size(143, 65);
            button4.TabIndex = 83;
            button4.Text = "00";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(580, 569);
            button5.Name = "button5";
            button5.Size = new Size(166, 65);
            button5.TabIndex = 84;
            button5.Text = "(";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(752, 569);
            button6.Name = "button6";
            button6.Size = new Size(173, 65);
            button6.TabIndex = 85;
            button6.Text = ")";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Fill;
            button11.Location = new Point(931, 569);
            button11.Name = "button11";
            button11.Size = new Size(161, 65);
            button11.TabIndex = 86;
            button11.Text = "button11";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Dock = DockStyle.Fill;
            button12.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            button12.Location = new Point(265, 569);
            button12.Name = "button12";
            button12.Size = new Size(136, 65);
            button12.TabIndex = 87;
            button12.Text = ".";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // monomial
            // 
            monomial.BackColor = SystemColors.ControlLight;
            monomial.Controls.Add(button14);
            monomial.Controls.Add(label4);
            monomial.Controls.Add(label5);
            monomial.Controls.Add(monomialTextBox);
            monomial.Location = new Point(0, 0);
            monomial.Margin = new Padding(0);
            monomial.Name = "monomial";
            monomial.Size = new Size(403, 310);
            monomial.TabIndex = 5;
            // 
            // button14
            // 
            button14.Location = new Point(339, 0);
            button14.Name = "button14";
            button14.Size = new Size(64, 29);
            button14.TabIndex = 4;
            button14.Text = "Back";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(56, 20);
            label4.Name = "label4";
            label4.Size = new Size(223, 32);
            label4.TabIndex = 3;
            label4.Text = "Enter The Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(56, 164);
            label5.Name = "label5";
            label5.Size = new Size(98, 32);
            label5.TabIndex = 1;
            label5.Text = "Result: ";
            // 
            // monomialTextBox
            // 
            monomialTextBox.Location = new Point(56, 57);
            monomialTextBox.Multiline = true;
            monomialTextBox.Name = "monomialTextBox";
            monomialTextBox.Size = new Size(212, 45);
            monomialTextBox.TabIndex = 0;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = SystemColors.ControlLight;
            mainPanel.Controls.Add(button13);
            mainPanel.Controls.Add(label6);
            mainPanel.Controls.Add(comboBox1);
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(403, 310);
            mainPanel.TabIndex = 6;
            // 
            // button13
            // 
            button13.BackColor = Color.Lime;
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button13.Location = new Point(143, 177);
            button13.Name = "button13";
            button13.Size = new Size(94, 37);
            button13.TabIndex = 2;
            button13.Text = "Select";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(98, 69);
            label6.Name = "label6";
            label6.Size = new Size(232, 28);
            label6.TabIndex = 1;
            label6.Text = "Choose Operation Type";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Monomial", "Binomial" });
            comboBox1.Location = new Point(129, 122);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 637);
            Controls.Add(monomial);
            Controls.Add(BinomialPanel);
            Controls.Add(mainPanel);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Form1";
            BinomialPanel.ResumeLayout(false);
            BinomialPanel.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            monomial.ResumeLayout(false);
            monomial.PerformLayout();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel BinomialPanel;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button81;
        private Button button80;
        private Button button79;
        private Button button78;
        private Button button76;
        private Button button75;
        private Button button74;
        private Button button69;
        private Button button68;
        private Button button67;
        private Button button66;
        private Button button64;
        private Button button63;
        private Button button62;
        private Button button57;
        private Button button56;
        private Button button55;
        private Button button54;
        private Button button52;
        private Button button51;
        private Button button46;
        private Button button45;
        private Button button44;
        private Button button43;
        private Button button34;
        private Button button33;
        private Button button32;
        private Button button31;
        private Button button22;
        private Button button21;
        private Button button20;
        private Button button19;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button11;
        private Button button12;
        private Label result;
        private TextBox BinomialTextBox1;
        private Panel monomial;
        private Panel mainPanel;
        private Label label6;
        private ComboBox comboBox1;
        private Label label4;
        private Label label5;
        private TextBox monomialTextBox;
        private Label label2;
        private Label label1;
        private TextBox binomialTextBox2;
        private Button button13;
        private Button button15;
        private Button button14;
        private Label binomialOperatorLabel;
    }
}