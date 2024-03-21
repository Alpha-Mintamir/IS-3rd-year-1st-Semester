using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LEARASHU
{
    public partial class create_account : Form
    {
        private string connectionString = "Data Source=DESKTOP-EQ55Q8H\\SQLEXPRESS;Initial Catalog=LEARASHU;Integrated Security=True";
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private DataTable dataTable = new DataTable();

        public create_account()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainPage mainPage = new mainPage();
            mainPage.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|PDF files (*.pdf)|*.pdf|Word documents (*.doc;*.docx)|*.doc;*.docx|Image files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file's path
                string selectedFilePath = openFileDialog.FileName;

                // Do something with the selected file path, such as saving it or displaying it
                // For example, you can set the text of a TextBox control:
                filePathTextBox.Text = selectedFilePath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color errorColor = Color.FromArgb(240, 128, 128);

            string patternEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            string patternPhone = @"^[0-9]{9}$";
            string patternStrongPassword = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
            Regex objPhone = new Regex(patternPhone);
            Regex objEmail = new Regex(patternEmail);
            Regex objPassword = new Regex(patternStrongPassword);

            bool isValid = true;

            // Validate phone number
            if (objPhone.IsMatch(EphoneNumTextBox.Text))
            {
                EphoneNumTextBox.BackColor = Color.White;
            }
            else
            {
                EphoneNumTextBox.BackColor = errorColor;
                isValid = false;
            }

            // Validate email
            if (objEmail.IsMatch(EemailTextBox.Text))
            {
                EemailTextBox.BackColor = Color.White;
            }
            else
            {
                EemailTextBox.BackColor = errorColor;
                isValid = false;
            }

            // Validate password
            if (objPassword.IsMatch(EpasswordTextBox.Text))
            {
                EpasswordTextBox.BackColor = Color.White;
            }
            else
            {
                EpasswordTextBox.BackColor = errorColor;
                isValid = false;
            }

            // If data is not valid, return without inserting into the database
            if (!isValid)
            {
                MessageBox.Show("Please correct the errors in the form before proceeding.");
                return;
            }

            string firstName = EfirstNameTextBox.Text;
            string lastName = ElastNameTextBox.Text;
            string phoneNumber = EphoneNumTextBox.Text;
            string email = EemailTextBox.Text;
            string gender = (EmaleRadioButton.Checked) ? "Male" : "Female";
            string region = EregionComboBox.SelectedItem?.ToString();
            string area = EareaComboBox.SelectedItem?.ToString();
            string product = EproductComboBox.SelectedItem?.ToString();
            string password = EpasswordTextBox.Text;

            InsertUserIntoDatabase(firstName, lastName, phoneNumber, email, gender, region, area, product, password);
        }

        private void InsertUserIntoDatabase(string firstName, string lastName, string phoneNumber, string email, string gender, string region, string area, string product, string passwordHash)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Users (FirstName, LastName, PhoneNumber, Email, Gender, Region, Area, Product, Password) " +
                               "VALUES (@FirstName, @LastName, @PhoneNumber, @Email, @Gender, @Region, @Area, @Product, @Password)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@Region", region);
                    command.Parameters.AddWithValue("@Area", area);
                    command.Parameters.AddWithValue("@Product", product);
                    command.Parameters.AddWithValue("@Password", passwordHash);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Registration successful!");
                }

                // Rest of your code for updating the DataGridView goes here

                this.Close();
                Login_page login_Pagee = new Login_page();
                login_Pagee.Show();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            EpasswordTextBox.PasswordChar = showPasswordCheckBox1.Checked ? '\0' : '*';
        }

        private void EregionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EareaComboBox.Items.Clear();
            if (EregionComboBox.SelectedIndex == 0)
            {
                string[] area1 = { "Gonder", "Bahirdar", "Dessie" };
                EareaComboBox.Items.AddRange(area1);
            }
            else if (EregionComboBox.SelectedIndex == 1)
            {
                string[] area2 = { "Illubabor", "Bedele", "Mettu", "Wellega" };
                EareaComboBox.Items.AddRange(area2);
            }
            else if (EregionComboBox.SelectedIndex == 2)
            {
                string[] area3 = { "Bensa", "Boricha" };
                EareaComboBox.Items.AddRange(area3);
            }
            else if (EregionComboBox.SelectedIndex == 3)
            {
                string[] area4 = { "Keffa", "Gedio", "Gamo Goffa" };
                EareaComboBox.Items.AddRange(area4);
            }
        }

        private void create_account_Load(object sender, EventArgs e)
        {
            // You can add any additional initialization code here
        }
    }
}
