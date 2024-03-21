using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace file_practice
{
    internal class Program
    {

        //public class NegativenumException: ApplicationException
        //{
        //    public NegativenumException(string message)
        //    {

        //    }
        //}


        static void Main(string[] args)
        {


            try
            {
                Console.WriteLine("Insert the Gallon");
                double a = double.Parse(Console.ReadLine());

                Console.WriteLine("Inser Killometer");
                double b = double.Parse(Console.ReadLine());

                double c = b / a;
                Console.WriteLine(c);
            }

            catch(FormatException ex)   
            {
                Console.WriteLine(ex.Message);
            }

            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally { Console.WriteLine("Good Bye"); }
            
































            //Console.WriteLine("Enter a positive number");
            

            //try
            //{
            //    int a = int.Parse(Console.ReadLine());
                
            //    if (a < 0)
            //    {
            //        throw new NegativenumException("Invalid Number");
            //    }
            //    double result = Math.Pow(a, 0.5);
            //    Console.WriteLine(result);

            //}
            //catch(NegativenumException message)
            //{
            //    Console.WriteLine("Invalid number");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("GOOD BYE");
            //}


            





            //using (StreamReader reader = new StreamReader(@"C:\EDP\with C#\word.txt"))
            //{
            //    string readd = reader.ReadToEnd();
            //    Console.WriteLine(readd);
            //}





            //using (StreamWriter writer = new StreamWriter(@"C:\EDP\with C#\newfile.txt"))
            //{
            //    // You can write content to the file if needed
            //    writer.WriteLine("Hello, this is a new file!");
            //}



            //using (StreamWriter writer = new StreamWriter(@"C:\EDP\with C#\word.txt", true))
            //{
            //    int n = 10;
            //    int t = 11;
            //    for (int i = 0; i < n; i++)
            //    {
            //        writer.WriteLine(t);
            //        t = t + 1;
            //    }
            //}

            //string[] strings = File.ReadAllLines(@"C:\EDP\with C#\word.txt");
            //int[] ints = Array.ConvertAll(strings, int.Parse);

            //int k = ints.Length;

            //for(int o = 0; o < k; o++)
            //{
            //    Console.WriteLine(ints[o]);


            //}



            //using (StreamWriter writer = new StreamWriter(@"C:\EDP\with C#\alpha.txt"))
            //{
            //    int n = 10;
            //      int t = 1;
            //       for (int i = 0; i < n; i++)
            //      {
            //            writer.WriteLine(t);
            //            t = t + 1;
            //        }
            //}


            //using(StreamReader reader = new StreamReader(@"C:\EDP\with C#\alpha.txt"))
            //{
            //    string heyy = reader.ReadToEnd();

            //    int len = heyy.Length;
            //    int sum = 0;

            //    for (int i = 0; i < len; i++)
            //    {
            //        int k = int.Parse(heyy[i].ToString());
            //        sum = sum + k;

            //    }

            //    Console.WriteLine(sum);
            //}





            //StreamWriter writer1 = new StreamWriter(@"C:\EDP\with C#\alpha1.txt");
            //writer1.WriteLine("Alpha1 ");
            //writer1.Close(); // Close the StreamWriter to release the file lock

            //StreamReader reader1 = new StreamReader(@"C:\EDP\with C#\alpha1.txt");
            //string al1 = reader1.ReadToEnd();
            //reader1.Close(); // Close the StreamReader

            //StreamWriter writer2 = new StreamWriter(@"C:\EDP\with C#\alpha2.txt");
            //writer2.WriteLine("Alpha2 ");
            //writer2.Close(); // Close the StreamWriter

            //StreamReader reader2 = new StreamReader(@"C:\EDP\with C#\alpha2.txt");
            //string al2 = reader2.ReadToEnd();
            //reader2.Close(); // Close the StreamReader

            //StreamWriter writer3 = new StreamWriter(@"C:\EDP\with C#\alpha3.txt");
            //string al3 = al1 + al2;
            //writer3.WriteLine(al3);
            //writer3.Close(); // Close the StreamWriter








        }
    }
}
