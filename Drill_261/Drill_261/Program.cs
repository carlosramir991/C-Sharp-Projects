//NOTE: To complete this challenge, you will need to do some online research on how to parse enums.

//Perform these actions and create a console app that includes the following:

//1.Create an enum for the days of the week.


//2.Prompt the user to enter the current day of the week.


//3.Assign the value to a variable of that enum data type you just created.

//4. Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week."
//to the console if an error occurs.

using System;
using System.Collections.Generic;

namespace Drill_261
{
    class Program
    {
        static void Main(string[] args)
        {
            



            try
            {
                Console.WriteLine("Please enter the current day of the week.");
                daysOfWeek day1 = Enum.Parse<daysOfWeek>(Console.ReadLine());

                Console.WriteLine(day1);
            }
            catch(ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                
            }


        }


            public enum daysOfWeek
            {
                Sunday,
                Monday,
                Tuesday,
                Wednesday,
                Thursday,
                Friday,
                Saturday

            }

   

           
        
    }
}
