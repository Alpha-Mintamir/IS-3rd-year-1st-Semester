using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_scissor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            Random random = new Random();
            int computer = random.Next(0,3);
            if(computer == 0)
            {
                label2.Text = "YOU BOTH TAKEN THE SAME ACTION, \n PLEASE TRY AGAIN";
            }
            else if(computer == 1)
            {
                label2.Text = "THE COMPUTER CHOOSE PAPER. \n YOU LOSE";
            }
            else if(computer == 2)
            {
                
                label2.Text = "THE COMPUTER CHOOSE SCISSOR. \n YOU WINNN";
                pictureBox4.Visible = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int computer = random.Next(0, 3);
            if (computer == 0)
            {
                label2.Text = "THE COMPUTER CHOOSE ROCK. \n YOU WIN";
            }
            else if (computer == 1)
            {
                label2.Text = "YOU BOTH TAKEN THE SAME ACTION, \n PLEASE TRY AGAIN";
            }
            else if (computer == 2)
            {
                label2.Text = "THE COMPUTER CHOOSE SCISSOR. \n YOU LOSE";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int computer = random.Next(0, 3);
            if (computer == 0)
            {
                label2.Text = "THE COMPUTER CHOOSE ROCK. \n YOU LOSE";
            }
            else if (computer == 1)
            {
                label2.Text = "THE COMPUTER CHOOSE PAPER. \n YOU WIN";
            }
            else if (computer == 2)
            {
                label2.Text = "YOU BOTH TAKEN THE SAME ACTION, \n PLEASE TRY AGAIN";
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
        }
    }
}
