using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Text = comboBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int result;

            if (comboBox1.SelectedIndex == 0)
            {
                result = num1 + num2;
                textBox3.Text = result.ToString();
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                result = num1 - num2;
                textBox3.Text = result.ToString();
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                result=num1 * num2;
                textBox3.Text = result.ToString();
            }
            else if(comboBox1.SelectedIndex == 3)
            {
                result = num1 / num2;
                textBox3.Text = result.ToString();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
