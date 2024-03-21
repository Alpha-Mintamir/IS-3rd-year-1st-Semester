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

namespace db_trial_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EQ55Q8H\SQLEXPRESS;Initial Catalog=Trial;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[trial 1]
           ([Full Name]
           ,[Age]
           ,[Fav food]
           )
     VALUES
           ('"+fullNameTextBox.Text+"', '"+ageTextBox.Text+"', '"+fav_FoodComboBox.SelectedItem.ToString()+"')", conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
