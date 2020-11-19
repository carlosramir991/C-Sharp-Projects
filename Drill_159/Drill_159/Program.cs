using System;

namespace Assignment_4.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person 1

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Please enter your hourly rate.");
            string input1 = Console.ReadLine();
            decimal hrate1 = Convert.ToDecimal(input1);
            Console.WriteLine("How many hours did your work this week.");
            string input2 = Console.ReadLine();
            float hoursWorked1 = float.Parse(input2);

            //Person 2

            Console.WriteLine("Person 2");
            Console.WriteLine("Please enter your hourly rate.");
            string input3 = Console.ReadLine();
            decimal hrate2 = Convert.ToDecimal(input3);
            Console.WriteLine("How many hours did your work this week.");
            string input4 = Console.ReadLine();
            float hoursWorked2 = float.Parse(input4);

            //Calculations for annual salary of person 1

            double AnnualSalary1 = hoursWorked1 * (float)hrate1 * 52;
            Console.WriteLine("Annual salary of Person 1: " + AnnualSalary1);

            //Calculations for annual salary of person 2

            double AnnualSalary2 = hoursWorked2 * (float)hrate2 * 52;
            Console.WriteLine("Annual salary of Person 2: " + AnnualSalary2);

            //Who made more money question

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Boolean comparison = AnnualSalary1 > AnnualSalary2;
            string WhoMakesMore = Convert.ToString(comparison);
            Console.WriteLine(WhoMakesMore);



        }
    }
}
