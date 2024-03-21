using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Narcissistic
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number = textBox.Text;
            double sum = 0;
            int digit = number.Length;
            for (int i = 0; i < digit; i++)
            {
                sum += Math.Pow(int.Parse(number[i].ToString()), digit);
            }
            if (sum == int.Parse(number))
            {
                label2.Text = "The number is Narcissistic";
            }
            else
            {
                label2.Text = "The number is not Narcissistic";
            }
        }
    }
}
