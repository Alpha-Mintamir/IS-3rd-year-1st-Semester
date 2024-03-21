using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            logoutBtn.BackColor = Color.Red;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
