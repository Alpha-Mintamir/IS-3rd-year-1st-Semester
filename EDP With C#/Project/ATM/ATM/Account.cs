using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATM
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kidus\OneDrive\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if (AccNametb.Text == "" || AccNumTb.Text == "" || FaNameTb.Text == "" || PhoneTb.Text == "" || Addresstb.Text == "" || occupationtb.Text == "" || pintb.Text == "")
            {
                MessageBox.Show("Missing Info.");

            } else
            {
                try
                {
                    Con.Open();
                    string query = "insert into AccountTbl values('" + AccNumTb.Text + "', '" + AccNametb.Text + "','" + FaNameTb.Text + "','" + dobdate.Value.Date + "', '" + PhoneTb.Text + "', '" + Addresstb.Text + "','" + educationcb.SelectedItem.ToString() + "', '" + occupationtb.Text + "', '" + pintb.Text + "', '"+bal+"')";
                    SqlCommand cmd = new SqlCommand( query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account created Successfully");
                    Con.Close();

                    login log = new login();
                    log.Show();
                    this.Hide();



                }
                catch ( Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
