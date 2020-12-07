//1.Ask the user for their age.

//2. Display the year the user was born.

//3. Exceptions must be handled using “try/catch.”

//4.Display appropriate error messages if the user enters zero or negative numbers.

//5.Display a general message if an exception was caused by anything else.

using System;
using System.Collections.Generic;
using System.IO;

namespace Drill_314
{
    class Program
    {
        private static int age;

        static void Main(string[] args)
        {
            
            try
            {

                Console.WriteLine("Hello! Please enter your age.");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age < 1)
                {
                     AgeError();
                    
                }
                var today = DateTime.Today;
                var born = today.Year - age;
                Console.WriteLine("You were born in " + born);
            }

            catch (Exception)
            {
                Console.WriteLine("Please enter a valid age.");
            }
            




            



        }

        private static void AgeError()
        {
            throw new AgeError();
        }
    }
}
