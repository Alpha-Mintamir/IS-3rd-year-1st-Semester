namespace project_2_Scientific_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button95_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 1;
            BinomialTextBox1.Text += a.ToString();


        }

        private void button51_Click(object sender, EventArgs e)
        {
            int a = 2;
            BinomialTextBox1.Text += a.ToString();
        }

        private void button52_Click(object sender, EventArgs e)
        {
            int a = 3;
            BinomialTextBox1.Text += a.ToString();
        }

        private void button62_Click(object sender, EventArgs e)
        {
            int a = 4;
            BinomialTextBox1.Text += a.ToString();
        }

        private void button63_Click(object sender, EventArgs e)
        {
            int a = 5;
            BinomialTextBox1.Text += a.ToString();
        }

        private void button64_Click(object sender, EventArgs e)
        {
            int a = 6;
            BinomialTextBox1.Text += a.ToString();
        }

        private void button74_Click(object sender, EventArgs e)
        {
            int a = 7;
            BinomialTextBox1.Text += a.ToString();
        }

        private void button75_Click(object sender, EventArgs e)
        {
            int a = 8;
            BinomialTextBox1.Text += a.ToString();
        }

        private void button76_Click(object sender, EventArgs e)
        {
            int a = 9;
            BinomialTextBox1.Text += a.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = 0;
            BinomialTextBox1.Text += a.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            String a = ".";
            BinomialTextBox1.Text += a;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String a = "+";
            binomialOperatorLabel.Text += a;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String a = "^";
            BinomialTextBox1.Text += a;
        }

        private void button9_Click(object sender, EventArgs e)
        {

            String a = " Abs( ";
            BinomialTextBox1.Text += a;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String a = " sin( ";
            BinomialTextBox1.Text += a;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            String a = "-";
            binomialOperatorLabel.Text += a;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            String a = " V( ";
            BinomialTextBox1.Text += a;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            String a = "!";
            BinomialTextBox1.Text += a;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            String a = " Cos( ";
            BinomialTextBox1.Text += a;
        }

        private void button31_Click_1(object sender, EventArgs e)
        {
            String a = "/";
            binomialOperatorLabel.Text += a;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            String a = " Log( ";
            BinomialTextBox1.Text += a;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            String a = " Modulus( ";
            BinomialTextBox1.Text += a;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            String a = " tan( ";
            BinomialTextBox1.Text += a;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            String a = " x ";
            binomialOperatorLabel.Text += a;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            String a = " ln( ";
            BinomialTextBox1.Text += a;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            String a = "π";
            BinomialTextBox1.Text += a;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            String a = "e";
            BinomialTextBox1.Text += a;
        }

        private void button54_Click(object sender, EventArgs e)
        {
            String a = " arccos( ";
            BinomialTextBox1.Text += a;
        }

        private void button55_Click(object sender, EventArgs e)
        {
            String a = " arcsin( ";
            BinomialTextBox1.Text += a;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            String a = " arctan( ";
            BinomialTextBox1.Text += a;
        }

        private void button66_Click(object sender, EventArgs e)
        {
            String a = " Sinh( ";
            BinomialTextBox1.Text += a;
        }

        private void button67_Click(object sender, EventArgs e)
        {
            String a = " Cosh( ";
            BinomialTextBox1.Text += a;
        }

        private void button68_Click(object sender, EventArgs e)
        {
            String a = " tanh( ";
            BinomialTextBox1.Text += a;
        }

        private void button78_Click(object sender, EventArgs e)
        {
            String a = "°";
            BinomialTextBox1.Text += a;
        }

        private void button79_Click(object sender, EventArgs e)
        {
            String a = "rad";
            BinomialTextBox1.Text += a;

        }

        private void button80_Click(object sender, EventArgs e)
        {
            String a = "00";
            BinomialTextBox1.Text += a;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String a = "(";
            BinomialTextBox1.Text += a;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String a = ")";
            BinomialTextBox1.Text += a;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                monomial.Show();
                mainPanel.Hide();

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                BinomialPanel.Show();
                mainPanel.Hide();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            monomial.Show();
            BinomialPanel.Hide();
            mainPanel.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            mainPanel.Show();
            BinomialPanel.Hide();
            monomial.Hide();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (binomialOperatorLabel.Text == "+")
            {

            }
        }

        private void binomialTextBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}