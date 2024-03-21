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
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }
        int starting = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            starting += 1;
            Myprogress.Value = starting;
            Percentage.Text =""+ starting;
            if(Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                timer1.Stop();
                login log = new login();
                this.Hide();
                log.Show();
            }

        }

        private void splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
