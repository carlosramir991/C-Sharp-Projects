using System;
using System.Collections.Generic;
using System.IO;

namespace Drill_297
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            string filePath = @"/Users/slims/Documents/logs/logs.txt";
            int input = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(filePath, true))
            {
                file.WriteLine(input);
            }
            Console.WriteLine("Your number: "+input+" has been recorded in a new text file. It reads "+ File.ReadAllText(filePath));
        }
    }
}
