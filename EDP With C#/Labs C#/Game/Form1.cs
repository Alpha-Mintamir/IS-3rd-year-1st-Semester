using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            //string[] game = { "rock", "paper", "scissor" };
            int computer = random.Next(0, 3);
            if (computer == 0)
            {
                label2.Text = "The computer choose ROCK \n YOU LOSE";
            }
            else if (computer == 1)
            {
                label2.Text = "The computer choose PAPER \n YOU WIN";
            }
            else if (computer == 2)
            {
                label2.Text = "YOU BOTH TAKEN THE SAME ACTION PLEASE TRY AGAIN";
            }
        }

        private void Rock_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            
            int computer = random.Next(0, 3);
            if (computer == 0)
            {
                label2.Text = "YOU BOTH TAKEN THE SAME ACTION PLEASE TRY AGAIN";
            }
            else if(computer == 1)
            {
                label2.Text = "The computer choose PAPER \n YOU LOSE";
            }
            else if (computer == 2)
            {
                label2.Text = "The computer choose ROCK \n YOU WIN";
            }
            
        }

        private void paper_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            
            int computer = random.Next(0, 3);
            if (computer == 0)
            {
                label2.Text = "The computer choose ROCK \n YOU WIN";
            }
            else if (computer == 1)
            {
                label2.Text = "YOU BOTH TAKEN THE SAME ACTION PLEASE TRY AGAIN";
            }
            else if (computer == 2)
            {
                label2.Text = "The computer choose Scissor \n YOU LOSE";
            }
        }
    }
}
