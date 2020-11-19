using System;

namespace Assignment_2.cs
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("The Tech Academy." + "\n" +
                "Student Daily Report.");
            Console.WriteLine("What is your name?");
            string nameAnswer = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string courseAnswer = Console.ReadLine();
            Console.WriteLine("What page number are you on?");
            string pageNum = Console.ReadLine();
            int pageAnswer = Convert.ToInt32(pageNum);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string booAnswer = Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveAnswer = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedbackAnswer = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            int hoursAnswer = Convert.ToInt32(hours);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");








        }
    }
}