using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GUI_sec1_q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            textBox1.BackColor = Color.Red;
            textBox1.Text = "The color is changed to red";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor= Color.Yellow;
            textBox1.BackColor = Color.Yellow;
            textBox1.Text = "The color is changed to yellow";



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
