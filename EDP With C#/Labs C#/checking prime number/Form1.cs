using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checking_prime_number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            bool isPrime = IsPrime(num);

            if (isPrime)
            {
                label2.Text = "Prime";
            }
            else
            {
                label2.Text = "Not Prime";
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
    
