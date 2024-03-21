using System;
using System.Linq;
using System.Windows.Forms;

namespace LEARASHU
{
    public partial class mainPage : Form
    {
        private string text;
        private int len = 0;
        public mainPage()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if(len < text.Length)
            {
                lblWelcomeTxt.Text = lblWelcomeTxt.Text + text.ElementAt(len);
                len++;
            }
            else
                welcomeTextTimer.Stop();
        }

        private void mainPage_Load(object sender, EventArgs e)
        {
            text = lblWelcomeTxt.Text;
            lblWelcomeTxt.Text = "";
            welcomeTextTimer.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login_page Login_Page = new Login_page();

            if(comboBox1.SelectedIndex == 1)
            {
                Login_Page.Show();
            }
        }
    }
}
