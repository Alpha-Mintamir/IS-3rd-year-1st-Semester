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

namespace db_practice_with_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string conn = "Data Source=DESKTOP-EQ55Q8H\\SQLEXPRESS;Initial Catalog=SampleDB;Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertData();
        }


        private void insertData()
        {
            using(SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                int a = int.Parse(textBox1.Text);
                string b = textBox2.Text;
                string c = textBox3.Text;  
                int d = int.Parse(textBox4.Text);

                using(SqlCommand command = new SqlCommand("INSERT INTO Students(StudentID, FirstName, LastName, Age) VALUES(@StudentID, @FirstName, @LastName, @Age)", connection))
                {
                    command.Parameters.AddWithValue("@StudentID", a);
                    command.Parameters.AddWithValue("@FirstName", b);
                    command.Parameters.AddWithValue("@LastName", c);
                    command.Parameters.AddWithValue("@Age", d);

                    int rowaffected = command.ExecuteNonQuery();
                   
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void showData()
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand("SELECT * FROM Students", connection))
                {
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            label5.Text = $"{reader["StudentID"]} {reader["FirstName"]} {reader["LastName"]} {reader["Age"]}";
                        }
                    }
                }
            }
        }
    }
}
