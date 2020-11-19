using System;

namespace Assignment_5.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            String input1 = Console.ReadLine();
            int age = Convert.ToInt32(input1);
            Console.WriteLine("Have you ever had a DUI?");
            string input2 = Console.ReadLine();
            Boolean DuiAnswer = Convert.ToBoolean(input2);
            Console.WriteLine("How many speeding tickets have you had?");
            String input3 = Console.ReadLine();
            int speedTickets = Convert.ToInt32(input3);
            Boolean qualified = (age > 15 && DuiAnswer == false && speedTickets <= 3);
            Console.WriteLine(qualified);


        }
    }
}
