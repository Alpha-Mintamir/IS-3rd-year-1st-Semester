using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            string pattern = textBox2.Text;
            Regex objectt = new Regex(pattern);
            MessageBox.Show(objectt.IsMatch(data).ToString());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            String mystr = textBox3.Text;
            Char[] mychar = mystr.ToCharArray();
            Array.Reverse(mychar);
            String reverse = new String(mychar);
            
            textBox4.Text = reverse.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int k = 0;
            string data = textBox6.Text;
            for(int i  = 0; i < data.Length; i++)
            {
                if (data[i].ToString == "r".ToString)
                {
                    k++;
                }
            }
        }
    }
}


