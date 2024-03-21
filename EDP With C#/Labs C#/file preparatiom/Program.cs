using System;
using System.IO;

namespace file_preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Writing content to the file
            string filePath = @"C:\EDP\leetcode.txt";
            string content = "dfsgjsrhgjerhgkjerhkjhertkjrehtkjerhtkjerhtkjerht";
            File.WriteAllText(filePath, content);

            // Reading content from the file
            string[] lines = File.ReadAllLines(filePath);

            // Printing each line
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
