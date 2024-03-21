using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_practice_2
{
    internal class Program
    {
        static void Main(string[] args)


        {
            
            string conn = "Data Source=DESKTOP-EQ55Q8H\\SQLEXPRESS;Initial Catalog=SampleDB;Integrated Security=True";

            using(SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();


                Console.WriteLine("heyyy");
                int b = int.Parse(Console.ReadLine());
                if(b == 1)
                {
                    nameee(connection);
                }
               


            }
            

        }

        static void nameee(SqlConnection connection)
        {
            int studentID = 1268785;
            string firstname = "Alpha";
            string lastname = "Lencho";
            int age = 34;

            using(SqlCommand command = new SqlCommand("INSERT INTO Students(StudentID, FirstName, LastName, Age) VALUES(@StudentID, @FirstName, @LastName, @Age)", connection))
            {
                command.Parameters.AddWithValue("@StudentID", studentID);
                command.Parameters.AddWithValue("@FirstName", firstname);
                command.Parameters.AddWithValue("@LastName", lastname);
                command.Parameters.AddWithValue("@Age", age);

                int rowaffected = command.ExecuteNonQuery();
                Console.WriteLine($"Inserted Successfully{rowaffected}");

            }
        }
        
    }
}
