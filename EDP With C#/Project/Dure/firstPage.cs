using System;
using System.Windows.Forms;

namespace LEARASHU
{
    public partial class firstPage : Form
    {
        public firstPage()
        {
            InitializeComponent();
        }


        bool menuExpand = false;


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void firstPage_Load(object sender, EventArgs e)
        {

        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height -= 20; // Adjust the value based on the desired speed of the transition

                if (menuContainer.Height <= 69)
                {
                    menuContainer.Height = 69; // Ensure the height doesn't go below 69
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height += 20; // Adjust the value based on the desired speed of the transition

                if (menuContainer.Height >= 280)
                {
                    menuContainer.Height = 280; // Ensure the height doesn't exceed 309
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void logoPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        bool sidebarExpand = true;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 20; 

                if (sidebar.Width <= 80)
                {
                    sidebar.Width = 80; 
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 20; 

                if (sidebar.Width >= 309)
                {
                    sidebar.Width = 309; 
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
             
        }
    }
}
