using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class WITHDRAW : Form
    {
        public WITHDRAW()
        {
            InitializeComponent();
        }
        int newbalance;

        private void button1_Click(object sender, EventArgs e)
        {
            if(wdamtTb.Text == "")
            {
                MessageBox.Show("Missing Info.");
            }
            else if(Convert.ToInt32(wdamtTb.Text) <= 0)
            {
                MessageBox.Show("Enter a valid amount");
            }
            else if (Convert.ToInt32(wdamtTb.Text) > bal)
            {
                MessageBox.Show("Insifficeient Balance");
            }
            else
            {
                try
                {
                    newbalance = bal - Convert.ToInt32(wdamtTb.Text);
                    try
                    {
                        Con.Open();
                        string query = "update AccountTbl  set Balance=" + newbalance + " where Acctnum= '" + Acc + "'";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Success Withdraw");

                        Con.Close();
                        addtransaction();
                        Home home = new Home();
                        home.Show();
                        this.Hide();

                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);

                    }
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }


        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kidus\OneDrive\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = login.AccNumber;
        int bal;
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AcctNum = '" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            balancelbl.Text = "Balance: " + dt.Rows[0][0].ToString() + "  Birr";
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }

        private void addtransaction()
        {
            string TrType = "WithDraw";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "', '" + TrType + "'," + wdamtTb.Text + ",'" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                
                Con.Close();

                login log = new login();
                log.Show();
                this.Hide();



            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }


        }

        private void WITHDRAW_Load(object sender, EventArgs e)
        {
            getbalance();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
        
    }
}
