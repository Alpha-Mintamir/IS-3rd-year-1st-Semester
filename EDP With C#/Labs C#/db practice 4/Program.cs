using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_practice_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            string conn = "Data Source=DESKTOP-EQ55Q8H\\SQLEXPRESS;Initial Catalog=SampleDB;Integrated Security=True";
            using(SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();

                Console.WriteLine("Please Insert a number");
                int num = int.Parse(Console.ReadLine());

                if(num == 1)
                {
                    updatee(connection);
                }
            }
        }

        static void updatee(SqlConnection connection)
        {

            int a = 114;
            string b = "beki";
            string c = "Beti";
            int d = 45;

            using(SqlCommand command = new SqlCommand("UPDATE Students SET StudentID = @StudentID, FirstName = @FirstName, LastName = @LastName, Age = @Age  WHERE StudentID = 111", connection))
            {
                command.Parameters.AddWithValue("@StudentID", a);
                command.Parameters.AddWithValue("@FirstName", b);
                command.Parameters.AddWithValue("@LastName", c);
                command.Parameters.AddWithValue("@Age", d);

                int rowaffected = command.ExecuteNonQuery();
                Console.WriteLine($"row affected{rowaffected}");
            }
        }
    }
}
