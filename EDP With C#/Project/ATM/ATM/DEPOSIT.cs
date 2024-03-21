using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class DEPOSIT : Form
    {
        public DEPOSIT()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kidus\OneDrive\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = login.AccNumber;

        private void addtransaction()
        {
            string TrType = "Deposit";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "', '" + TrType + "'," + DepoAmtTb.Text + ",'" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                // MessageBox.Show("Account created Successfully");
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



        private void button1_Click(object sender, EventArgs e)
        {
            if(DepoAmtTb.Text == "" || Convert.ToInt32(DepoAmtTb.Text) <= 0)
            {
                MessageBox.Show("Enter The Amount To Deposit");
            }
            else
            {
               
                newbalance = oldbalance + Convert.ToInt32(DepoAmtTb.Text);
                try
                {
                    Con.Open();
                    string query = "update AccountTbl  set Balance=" + newbalance + " where Acctnum= '" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sucess Deposit");

                    Con.Close();
                    addtransaction();
                    Home home = new Home();
                    home.Show();
                    this.Hide();

                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        int oldbalance, newbalance;
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AcctNum = '" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldbalance = Convert.ToInt32 (dt.Rows[0][0].ToString());
            Con.Close();

        }
        private void DEPOSIT_Load(object sender, EventArgs e)
        {
            getbalance();


        }
    }
}
