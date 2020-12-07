//1.Prints the current date and time to the console.

//2. Asks the user for a number.

//3. Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.



using System;
using System.Collections.Generic;
using System.IO;

namespace Drill_300
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current date and time at the moment is "+DateTime.Now);
            Console.WriteLine("Please enter a number.");
            int input = Convert.ToInt32(Console.ReadLine());
            TimeSpan result = TimeSpan.FromHours(input);
            DateTime newTime = DateTime.Now + result;
            Console.WriteLine("The time will be "+newTime+ " in "+result+" hours.");



        }
    }
}
