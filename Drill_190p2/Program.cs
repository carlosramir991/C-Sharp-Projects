using System;

namespace Drill_190p2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of times you floss each day.");
            int flossNum = Convert.ToInt32(Console.ReadLine());
            bool rightNum2 = flossNum == 2;

            while (!rightNum)
            {
                switch (flossNum)
                {
                    case 1:
                        Console.WriteLine("You should be flossing more!");
                        Console.WriteLine("Try again please.");
                        flossNum = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 2:

                        Console.WriteLine("That is correct!");
                        rightNum2 = true;
                        break;

                    default:
                        Console.WriteLine("Try again.");
                        flossNum = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }
        }
    }
}
