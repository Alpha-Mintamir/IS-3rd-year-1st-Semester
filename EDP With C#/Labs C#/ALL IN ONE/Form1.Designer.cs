namespace ALL_IN_ONE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            leftPanel = new Panel();
            topPanel = new Panel();
            middlePanel = new Panel();
            additionButtn = new Button();
            sidePanel = new Panel();
            calculatorButton = new Button();
            this.taxButton = new Button();
            this.factorialButton1 = new Button();
            additionFirstNameLabel = new Label();
            additionButton1 = new Button();
            additionFirstNameTextBox = new TextBox();
            additionLastNameLabel = new Label();
            additionLastNameTextBox = new TextBox();
            additionResultBox = new TextBox();
            additionResultLabel = new Label();
            tempratureButton = new Button();
            seeMore1Button = new Button();
            leftPanel.SuspendLayout();
            middlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.Red;
            leftPanel.Controls.Add(seeMore1Button);
            leftPanel.Controls.Add(this.factorialButton1);
            leftPanel.Controls.Add(this.taxButton);
            leftPanel.Controls.Add(tempratureButton);
            leftPanel.Controls.Add(calculatorButton);
            leftPanel.Controls.Add(sidePanel);
            leftPanel.Controls.Add(additionButtn);
            leftPanel.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            leftPanel.Location = new Point(0, 1);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(205, 458);
            leftPanel.TabIndex = 0;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(255, 192, 128);
            topPanel.Location = new Point(202, 1);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(540, 30);
            topPanel.TabIndex = 1;
            // 
            // middlePanel
            // 
            middlePanel.BackColor = Color.White;
            middlePanel.Controls.Add(additionResultLabel);
            middlePanel.Controls.Add(additionResultBox);
            middlePanel.Controls.Add(additionLastNameTextBox);
            middlePanel.Controls.Add(additionLastNameLabel);
            middlePanel.Controls.Add(additionFirstNameTextBox);
            middlePanel.Controls.Add(additionButton1);
            middlePanel.Controls.Add(additionFirstNameLabel);
            middlePanel.Font = new Font("Lucida Bright", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            middlePanel.Location = new Point(205, 28);
            middlePanel.Name = "middlePanel";
            middlePanel.Size = new Size(537, 431);
            middlePanel.TabIndex = 2;
            // 
            // additionButtn
            // 
            additionButtn.BackColor = Color.Red;
            additionButtn.FlatAppearance.BorderSize = 0;
            additionButtn.FlatStyle = FlatStyle.Flat;
            additionButtn.Font = new Font("Georgia", 13F, FontStyle.Regular, GraphicsUnit.Point);
            additionButtn.ForeColor = Color.White;
            additionButtn.Image = Properties.Resources.add_;
            additionButtn.ImageAlign = ContentAlignment.MiddleLeft;
            additionButtn.Location = new Point(0, 48);
            additionButtn.Name = "additionButtn";
            additionButtn.Size = new Size(205, 64);
            additionButtn.TabIndex = 0;
            additionButtn.Text = "Addition";
            additionButtn.TextAlign = ContentAlignment.MiddleRight;
            additionButtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            additionButtn.UseVisualStyleBackColor = false;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.Yellow;
            sidePanel.Location = new Point(0, 48);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(16, 64);
            sidePanel.TabIndex = 0;
            // 
            // calculatorButton
            // 
            calculatorButton.BackColor = Color.Red;
            calculatorButton.FlatAppearance.BorderSize = 0;
            calculatorButton.FlatStyle = FlatStyle.Flat;
            calculatorButton.Font = new Font("Georgia", 13F, FontStyle.Regular, GraphicsUnit.Point);
            calculatorButton.ForeColor = Color.White;
            calculatorButton.Image = (Image)resources.GetObject("calculatorButton.Image");
            calculatorButton.ImageAlign = ContentAlignment.MiddleLeft;
            calculatorButton.Location = new Point(0, 118);
            calculatorButton.Name = "calculatorButton";
            calculatorButton.Size = new Size(205, 64);
            calculatorButton.TabIndex = 1;
            calculatorButton.Text = "Calculator";
            calculatorButton.TextAlign = ContentAlignment.MiddleRight;
            calculatorButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            calculatorButton.UseVisualStyleBackColor = false;
            // 
            // taxButton
            // 
            this.taxButton.BackColor = Color.Red;
            this.taxButton.FlatAppearance.BorderSize = 0;
            this.taxButton.FlatStyle = FlatStyle.Flat;
            this.taxButton.Font = new Font("Georgia", 13F, FontStyle.Regular, GraphicsUnit.Point);
            this.taxButton.ForeColor = Color.White;
            this.taxButton.Image = (Image)resources.GetObject("taxButton.Image");
            this.taxButton.ImageAlign = ContentAlignment.MiddleLeft;
            this.taxButton.Location = new Point(0, 255);
            this.taxButton.Name = "taxButton";
            this.taxButton.Size = new Size(205, 64);
            this.taxButton.TabIndex = 3;
            this.taxButton.Text = "TAX";
            this.taxButton.TextAlign = ContentAlignment.MiddleRight;
            this.taxButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.taxButton.UseVisualStyleBackColor = false;
            // 
            // factorialButton
            // 
            this.factorialButton1.BackColor = Color.Red;
            this.factorialButton1.FlatAppearance.BorderSize = 0;
            this.factorialButton1.FlatStyle = FlatStyle.Flat;
            this.factorialButton1.Font = new Font("Georgia", 13F, FontStyle.Regular, GraphicsUnit.Point);
            this.factorialButton1.ForeColor = Color.White;
            this.factorialButton1.Image = (Image)resources.GetObject("factorialButton.Image");
            this.factorialButton1.ImageAlign = ContentAlignment.MiddleLeft;
            this.factorialButton1.Location = new Point(0, 324);
            this.factorialButton1.Name = "factorialButton";
            this.factorialButton1.Size = new Size(205, 64);
            this.factorialButton1.TabIndex = 4;
            this.factorialButton1.Text = "Factorial";
            this.factorialButton1.TextAlign = ContentAlignment.MiddleRight;
            this.factorialButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.factorialButton1.UseVisualStyleBackColor = false;
            // 
            // additionFirstNameLabel
            // 
            additionFirstNameLabel.AutoSize = true;
            additionFirstNameLabel.Location = new Point(60, 81);
            additionFirstNameLabel.Name = "additionFirstNameLabel";
            additionFirstNameLabel.Size = new Size(165, 26);
            additionFirstNameLabel.TabIndex = 0;
            additionFirstNameLabel.Text = "First Number";
            // 
            // additionButton1
            // 
            additionButton1.BackColor = Color.Gainsboro;
            additionButton1.FlatAppearance.BorderSize = 0;
            additionButton1.FlatStyle = FlatStyle.Flat;
            additionButton1.Location = new Point(78, 228);
            additionButton1.Name = "additionButton1";
            additionButton1.Size = new Size(129, 43);
            additionButton1.TabIndex = 1;
            additionButton1.Text = "Calculate";
            additionButton1.UseVisualStyleBackColor = false;
            additionButton1.Click += additionButton1_Click;
            // 
            // additionFirstNameTextBox
            // 
            additionFirstNameTextBox.Location = new Point(269, 72);
            additionFirstNameTextBox.Name = "additionFirstNameTextBox";
            additionFirstNameTextBox.Size = new Size(199, 35);
            additionFirstNameTextBox.TabIndex = 2;
            additionFirstNameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // additionLastNameLabel
            // 
            additionLastNameLabel.AutoSize = true;
            additionLastNameLabel.Location = new Point(60, 141);
            additionLastNameLabel.Name = "additionLastNameLabel";
            additionLastNameLabel.Size = new Size(192, 26);
            additionLastNameLabel.TabIndex = 3;
            additionLastNameLabel.Text = "Second Number";
            // 
            // additionLastNameTextBox
            // 
            additionLastNameTextBox.Location = new Point(269, 138);
            additionLastNameTextBox.Name = "additionLastNameTextBox";
            additionLastNameTextBox.Size = new Size(199, 35);
            additionLastNameTextBox.TabIndex = 4;
            // 
            // additionResultBox
            // 
            additionResultBox.Location = new Point(285, 236);
            additionResultBox.Name = "additionResultBox";
            additionResultBox.Size = new Size(138, 35);
            additionResultBox.TabIndex = 5;
            // 
            // additionResultLabel
            // 
            additionResultLabel.AutoSize = true;
            additionResultLabel.Location = new Point(308, 197);
            additionResultLabel.Name = "additionResultLabel";
            additionResultLabel.Size = new Size(85, 26);
            additionResultLabel.TabIndex = 6;
            additionResultLabel.Text = "Result";
            // 
            // tempratureButton
            // 
            tempratureButton.BackColor = Color.Red;
            tempratureButton.FlatAppearance.BorderSize = 0;
            tempratureButton.FlatStyle = FlatStyle.Flat;
            tempratureButton.Font = new Font("Georgia", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tempratureButton.ForeColor = Color.White;
            tempratureButton.Image = (Image)resources.GetObject("tempratureButton.Image");
            tempratureButton.ImageAlign = ContentAlignment.MiddleLeft;
            tempratureButton.Location = new Point(0, 186);
            tempratureButton.Name = "tempratureButton";
            tempratureButton.Size = new Size(205, 64);
            tempratureButton.TabIndex = 2;
            tempratureButton.Text = "Temprature";
            tempratureButton.TextAlign = ContentAlignment.MiddleRight;
            tempratureButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            tempratureButton.UseVisualStyleBackColor = false;
            // 
            // seeMore1Button
            // 
            seeMore1Button.BackColor = Color.Red;
            seeMore1Button.FlatAppearance.BorderSize = 0;
            seeMore1Button.FlatStyle = FlatStyle.Flat;
            seeMore1Button.Font = new Font("Georgia", 13F, FontStyle.Regular, GraphicsUnit.Point);
            seeMore1Button.ForeColor = Color.White;
            seeMore1Button.Image = (Image)resources.GetObject("seeMore1Button.Image");
            seeMore1Button.ImageAlign = ContentAlignment.MiddleLeft;
            seeMore1Button.Location = new Point(0, 394);
            seeMore1Button.Name = "seeMore1Button";
            seeMore1Button.Size = new Size(205, 64);
            seeMore1Button.TabIndex = 5;
            seeMore1Button.Text = "See More";
            seeMore1Button.TextAlign = ContentAlignment.MiddleRight;
            seeMore1Button.TextImageRelation = TextImageRelation.ImageBeforeText;
            seeMore1Button.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 459);
            Controls.Add(middlePanel);
            Controls.Add(topPanel);
            Controls.Add(leftPanel);
            Name = "Form1";
            Text = "ALL IN ONE";
            Load += Form1_Load;
            leftPanel.ResumeLayout(false);
            middlePanel.ResumeLayout(false);
            middlePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel leftPanel;
        private Panel topPanel;
        private Panel middlePanel;
        private Button taxButton1;
        private Button taxButton;

        public Button factorialButton1 { get; private set; }

        private Button calculatorButton;
        private Panel sidePanel;
        private Button additionButtn;
        private Label additionLastNameLabel;
        private TextBox additionFirstNameTextBox;
        private Button additionButton1;
        private Label additionFirstNameLabel;
        private TextBox additionLastNameTextBox;
        private Button seeMore1Button;
        private Button tempratureButton;
        private Label additionResultLabel;
        private TextBox additionResultBox;
    }
}