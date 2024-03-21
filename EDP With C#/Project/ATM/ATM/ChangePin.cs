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
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kidus\OneDrive\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = login.AccNumber;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Pin1Tb.Text == "" || Pin2Tb.Text == "")
            {
                MessageBox.Show("Enter And Confirm  The New PIN");
            }
            else if (Pin2Tb.Text != Pin1Tb.Text)
            {
                MessageBox.Show("PIN Is Different");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update AccountTbl  set PIN=" + Pin1Tb.Text + " where Acctnum= '" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PIN Successfully Updated");

                    Con.Close();
                    login home = new login();
                    home.Show();
                    this.Hide();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
    }

