using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string_with_GUI_lab5_gui_version_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string one = textBox1.Text;
            int sum = 0;
            foreach (char i in one)
            {
                sum++;
            }
            label2.Text = ($"The length of the word is {sum}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string two = textBox2.Text; 
            List<string> result = new List<string>();
            for (int j = two.Length - 1; j >= 0; j--)
            {
                result.Add(two[j].ToString());
            }
            
            string display = string.Join(", ", result);
            label3.Text = display;
            
        }
    }
}
