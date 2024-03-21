using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            BALANCE bal = new BALANCE();
            this.Hide();
            bal.Show();
        }
        public static String AccNumber;
        private void Home_Load(object sender, EventArgs e)
        {
            AccNumlbl.Text = "Account Number:" + login.AccNumber;
            AccNumber = login.AccNumber;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DEPOSIT depo = new DEPOSIT();
            depo.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangePin Pin = new ChangePin();
            Pin.Show();
            this.Hide();

        }

        private void label13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WITHDRAW wd = new WITHDRAW();
            wd.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FastCash Fcash = new FastCash();
            Fcash.Show();
            this.Hide();
        }
    }
}
