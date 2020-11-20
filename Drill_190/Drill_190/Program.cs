using System;

namespace Drill_190
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of times you should brush your teeth each day.");
            string input1 = Console.ReadLine();
            int brushNum = Convert.ToInt32(input1);
            bool rightNum = brushNum == 3;
      

            do
            {
                switch (brushNum)
                {
                    case 1:

                        Console.WriteLine("You should be brushing more than once a day!");
                        Console.WriteLine("Try again please");
                        brushNum = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 2:

                        Console.WriteLine("You should be brushing more than twice a day!");
                        Console.WriteLine("Try again please");
                        brushNum = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 3:

                        Console.WriteLine("Great! That is the correct number of times you should be brushing!");
                        rightNum = true;
                        break;

                    default:

                        Console.WriteLine("That is not the correct number of times one should be brushing.");
                        Console.WriteLine("Try again please");
                        brushNum = Convert.ToInt32(Console.ReadLine());
                        break;
                }
                
            }
            while (!rightNum);
            Console.ReadLine();

            Console.WriteLine("Please enter the number of times you floss each day.");
            int flossNum = Convert.ToInt32(Console.ReadLine());
            bool rightNum2 = flossNum == 2;

            while (!rightNum2)
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
