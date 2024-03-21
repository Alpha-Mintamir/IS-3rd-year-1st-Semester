using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#1 Create a list of strings using the class ArrayList. Once created, add elements to the arraylis and display them.
            //then modify them by adding an element at the end of it.

            ArrayList listofstrings = new ArrayList();
            listofstrings.Add("alpha");
            listofstrings.Add("lencho");
            listofstrings.Add("firomsa");
            listofstrings.Add("dagmawi");
            listofstrings.RemoveAt(1);

            for (int i = 0; i < listofstrings.count; i++)
            {
                Console.WriteLine(listofstrings[i]);
            }

            Console.WriteLine(listofstrings);

            //2 Given a string of text write a program that collects the upper letter of the string and collects them in string builder. the text is:
            //The Quick Brown Fox Jumps Over the Lazy Dog"

            string txt = "The Quick Brown Fox Jumps Over the Lazy Dog";
            var UpperCaseLetters = new StringBuilder();

            for(int i =0; i < txt.Length; i++)
            {
                if (char.IsUpper(txt[i]))
                {
                    UpperCaseLetters.Append(txt[i]);
                }
            }

            Console.WriteLine(UpperCaseLetters);
            

        }
    }
}
