using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui_sec_1_q5
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int firstNum = int.Parse(textBox1.Text);
            int secondNum = int.Parse(textBox2.Text);
            int result = firstNum + secondNum;
            resultLabel.Text = int.Parse(result);
        }
    }
}
