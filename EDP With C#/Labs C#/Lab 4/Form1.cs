namespace Lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int result = num1 + num2;
            textBox3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox4.Text);
            int num2 = int.Parse(textBox5.Text);
            int result = num1 + num2;
            textBox6.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox4.Text);
            int num2 = int.Parse(textBox5.Text);
            int result = num1 - num2;
            textBox6.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox4.Text);
            int num2 = int.Parse(textBox5.Text);
            int result = num1 * num2;
            textBox6.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox4.Text);
            int num2 = int.Parse(textBox5.Text);
            int result = num1 / num2;
            textBox6.Text = result.ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button4.Text = comboBox1.SelectedItem.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox7.Text);
            int num2 = int.Parse(textBox8.Text);
            int result;

            if (comboBox1.SelectedIndex == 0)
            {
                result = num1 + num2;
                label8.Text = result.ToString();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                result = num1 - num2;
                label8.Text = result.ToString();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                result = num1 * num2;
                label8.Text = result.ToString();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                result = num1 / num2;
                label8.Text = result.ToString();
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label12.Text = comboBox2.SelectedItem.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox9.Text);
            bool isPrime = IsPrime(num);

            if (isPrime)
            {
                label14.Text = "Prime";
            }
            else
            {
                label14.Text = "Not Prime";
            }
        }

        // Function to check whether a number is prime or not
        private bool IsPrime(int num)
        {
            if (num <= 1)
                return false;

            if (num <= 3)
                return true;

            if (num % 2 == 0 || num % 3 == 0)
                return false;

            for (int i = 5; i * i <= num; i += 6)
            {
                if (num % i == 0 || num % (i + 2) == 0)
                    return false;
            }

            return true;
        }

    }
    }
