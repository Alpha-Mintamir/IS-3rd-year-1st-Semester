using System;
using System.IO;
using System.Linq;

namespace FileStreamExample
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string path = @"C:\EDP\text.txt";
            string[] readtxt = File.ReadAllLines(path);
            int[] readnum = Array.ConvertAll(readtxt, int.Parse);

            Console.WriteLine("there are: " + readtxt.Length + "lines");

            int sum = 0;
            for (int s = 0; s < readnum.Length; s++)
            {
                sum += readnum[s];
            }
            Console.WriteLine("their sum is: " + sum);

            Console.WriteLine("their average is: " + sum / readtxt.Length);


            string filePath = @"C:\users\HP\Desktop\myfile.txt";
            Console.WriteLine(File.GetCreationTime(filePath));

            /*string path = @"C:\Users\HP\Desktop\letters.txt";
            string[] readletter = File.ReadAllLines(path);
            int[] arr_letter = Array.ConvertAll(readletter, int.Parse);
            Console.WriteLine("array length is: ", arr_letter.Length, "lines");*/

            /*string pazu = @"C:\users\HP\Desktop\let.txt";
            string content = "Here we go!";
            string king = "Cristiano Ronaldo!";
            File.WriteAllText(pazu, content);
            File.WriteAllText(pazu, king);

            string ExistingDoc = File.ReadAllText(pazu);
            string numbers = "1, 2, 3, 4, 5";
            string combined = ExistingDoc + Environment.NewLine + numbers;
            Console.WriteLine(combined);
*/







        }
    }
}



























































/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Desktop\text.txt";
            using (FileStream file = File.Create(path))
            if (file.Exists(path))
            {
                Console.WriteLine("file is success fully created!");
            }else
            {
                Console.WriteLine("File is not created");
            }

        }


    }
}*/
