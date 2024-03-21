using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleString
{
    internal class Program
    {
        static void Main(string[] args)
        {

 //q1: Take a string from a user and display the length without using the length property

            Console.WriteLine("Enter a word you want to figure out its length");
            string one = Console.ReadLine();
            int sum = 0;
            foreach (char i in one)
            {
                sum++;
            }
            Console.WriteLine($"The length of the word is {sum}");


 //q2: Take a string from a user and display the reversed string without using any built-in function




            Console.WriteLine("Enter a word you want to be reversed");
            string two = Console.ReadLine();

            for (int j = two.Length - 1; j >= 0; j--)
            {
                Console.Write(two[j]);
            }
            Console.WriteLine();

 //q3: Take a string from a user and display how many digits, alphabets, and special characters it has


            Console.WriteLine("Enter a word to count the number of digits, alphabets, and special characters");
            string three = Console.ReadLine();
            string alphaBets = "abcdefghijklmnopqrstuvwxyz";
            string spechialChar = "!@#$%^&*()_+-={}[]|\\:;'<>,.?/~`";
            string numbers = "0123456789";
            int countNumber = 0;
            int countAlphabet = 0;
            int countSpecialchar = 0;
            for (int k = 0; k < three.Length; k++)
            {
                for (int l = 0; l < alphaBets.Length; l++)
                {
                    if (three[k] == alphaBets[l])
                    {
                        countAlphabet++;
                        break;
                    }
                }

                for (int n = 0; n < spechialChar.Length; n++)
                {
                    if (three[k] == spechialChar[n])
                    {
                        countSpecialchar++;
                        break;
                    }
                }


                for (int m = 0; m < numbers.Length; m++)
                {
                    if (three[k] == numbers[m])
                    {
                        countNumber++;
                        break;
                    }
                }

            }

            Console.WriteLine($"Number of AlphaBets: {countAlphabet} \n " +
                $"Number of special characters: {countSpecialchar} \n Number" +
                $" of numbers(digits): {countNumber}");






            //q4: Take a string from a user and count the number of vowels and consonants


            Console.WriteLine("Enter a Word to count the vowels and consonants");
            string input = Console.ReadLine().ToLower();
            string vowels = "aeiou";
            int countVowel = 0;
            int countConsonant = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                // Check if the current character is a vowel
                if (vowels.Contains(currentChar))
                {
                    countVowel++;
                }
                // Check if the current character is a consonant (assuming letters that are not vowels are consonants)
                else if (char.IsLetter(currentChar))
                {
                    countConsonant++;
                }
            }

            string result = $"The number of Vowels: {countVowel}\nThe number of consonants: {countConsonant}";
            Console.WriteLine(result);






            //q5 Skyline Writing. Take a string from a user and display it in skyline manner where every other letter is upper-case



            Console.WriteLine("Enter a Word you want to conver to Skyline format");
            string five = Console.ReadLine();
            five = five.ToLower();

            for (int z = 0; z < five.Length; z += 2)

            {
                Console.Write(char.ToUpper(five[z]));
                Console.Write(five[z + 1]);

            }
            Console.WriteLine();



        }
    }
}
