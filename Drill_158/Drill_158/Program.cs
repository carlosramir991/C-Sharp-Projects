using System;

namespace Assignment_3.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1 of Assignment

            Console.WriteLine("Enter a number!");
            string answer1 = Console.ReadLine();
            int number1 = Convert.ToInt32(answer1);
            long product1 = number1 * 50;
            Console.WriteLine("The product of your number and 50 is: " + product1);


            //Part 2 of Assignment

            Console.WriteLine("Enter another number please!");
            string answer2 = Console.ReadLine();
            int number2 = Convert.ToInt32(answer2);
            int summation1 = number2 + 25;
            Console.WriteLine("The summation of your number and 25 is: " + summation1);


            //Part 3 of Assignment

            Console.WriteLine("Please enter another number!");
            string answer3 = Console.ReadLine();
            double number3 = Convert.ToDouble(answer3);
            double quotient1 = number3 / 12.5;
            Console.WriteLine("The quotient of your number and 12.5 is: " + quotient1);


            //Part 4 of Assignment

            Console.WriteLine("Please enter a number.");
            string answer4 = Console.ReadLine();
            int number4 = Convert.ToInt32(answer4);
            bool check1 = number4 > 50;
            string torf = Convert.ToString(check1);
            Console.WriteLine(torf);


            //Part 5 of Assginment

            Console.WriteLine("Please enter a number.");
            string answer5 = Console.ReadLine();
            double number5 = Convert.ToDouble(answer5);
            double remainder1 = number5 % 7;
            Console.WriteLine("The remainder of the quotient of your number and 7 is: " + remainder1);
            Console.ReadLine();


        }
    }
}

