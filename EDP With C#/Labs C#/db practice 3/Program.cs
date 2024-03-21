using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_practice_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conn = "Data Source=DESKTOP-EQ55Q8H\\SQLEXPRESS;Initial Catalog=SampleDB;Integrated Security=True";
            using(SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();

                Console.WriteLine("Enter a number");
                int a = int.Parse(Console.ReadLine());

                if (a == 1)
                {
                    readdd(connection);
                }

                


            }
        }


        static void readdd(SqlConnection connection)
        {
            using(SqlCommand command = new SqlCommand("SELECT * From Students", connection))
            {
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["StudentID"]}, {reader["FirstName"]}");
                    }
                }
            }
        }
    }
}
