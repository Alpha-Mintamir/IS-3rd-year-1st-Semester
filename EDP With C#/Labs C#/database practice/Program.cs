using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace database_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=DESKTOP-EQ55Q8H\\SQLEXPRESS;Initial Catalog=SampleDB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                while (true)
                {
                    Console.WriteLine("\n Choose an Option:");
                    Console.WriteLine("1. Insert Student");
                    Console.WriteLine("2. view Student");
                    Console.WriteLine("3. Update Student");
                    Console.WriteLine("4. Delete Student");
                    Console.WriteLine("5. Create Table");

                    Console.WriteLine("0. Exit");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            InsertStudent(connection);
                            break;
                        case "2":
                            ViewStudents(connection);
                            break;
                        case "3":
                            UpdateStudent(connection);
                            break;
                        case "4":
                            DeleteStudent(connection);
                            break;
                        case "5":
                            CreateTable(connection);
                            break;
                        case "0":
                            return;
                        default:
                            Console.WriteLine("Invalid Option. Please Try AGAIN!");
                            break;

                    }

                }
            }
        }



        static void CreateTable(SqlConnection connection)
        {
            try
            {
                string c = "TeacherID INT PRIMARY KEY,";
                string d = "TeacherFirstName NVARCHAR(50),";
                string e = "TeacherLastName NVARCHAR(50),";
                string f = "Age INT";
                string conn = $"CREATE TABLE Teachers({c} {d} {e} {f})";

                using (SqlCommand command = new SqlCommand(conn, connection))
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Table Created Successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating table: {ex.Message}");
            }
        }






        

















        static void InsertStudent(SqlConnection connection)
        {

            Console.WriteLine("Insert Student ID");
            int studentID = int.Parse(Console.ReadLine());


            Console.WriteLine("Insert Student First Name");
            string firstName = Console.ReadLine();


            Console.WriteLine("Insert Student Last Name");
            string  lastName = Console.ReadLine();


            Console.WriteLine("Insert Student's Age");
            int age = int.Parse(Console.ReadLine());



            string a = "INSERT INTO Students(StudentID, FirstName, LastName, Age)";
            string b = "VALUES(@StudentID, @FirstName, @LastName, @Age);";
            using (SqlCommand command = new SqlCommand(a + b, connection))
            {
                command.Parameters.AddWithValue("@StudentID", studentID);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Age", age);

                int affectedRow = command.ExecuteNonQuery();
                Console.WriteLine($"affected row(s){affectedRow}");
            }
        }






        static void ViewStudents(SqlConnection connection)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM Students;", connection))
            {
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("\nStudents");

                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["StudentID"]}, {reader["FirstName"]}");
                    }
                }
            }
        }





        static void UpdateStudent(SqlConnection connection)
        {
            Console.Write("Enter StudentID to update: ");
            int studentID = int.Parse(Console.ReadLine());

            Console.Write("Enter new FirstName: ");
            string newFirstName = Console.ReadLine();

            Console.Write("Enter new LastName: ");
            string newLastName = Console.ReadLine();

            Console.Write("Enter new Age: ");
            int newAge = int.Parse(Console.ReadLine());

            using (SqlCommand command = new SqlCommand(
                "UPDATE Students SET FirstName = @FirstName, LastName = @LastName, Age = @Age WHERE StudentID = @StudentID;", connection))
            {
                command.Parameters.AddWithValue("@StudentID", studentID);
                command.Parameters.AddWithValue("@FirstName", newFirstName);
                command.Parameters.AddWithValue("@LastName", newLastName);
                command.Parameters.AddWithValue("@Age", newAge);

                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) updated.");
            }
        }











        static void DeleteStudent(SqlConnection connection)
        {
            Console.Write("Enter StudentID to delete: ");
            int studentID = int.Parse(Console.ReadLine());

            using (SqlCommand command = new SqlCommand(
                "DELETE FROM Students WHERE StudentID = @StudentID;", connection))
            {
                command.Parameters.AddWithValue("@StudentID", studentID);

                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) deleted.");
            }
        }
    }
}
