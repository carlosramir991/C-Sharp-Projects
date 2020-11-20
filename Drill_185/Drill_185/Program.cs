using System;

namespace Drill_185
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");


            Console.WriteLine("Please Enter the package weight.");

            string Input1 = Console.ReadLine();
            int PackageWeight = Convert.ToInt32(Input1);


            if (PackageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }
            else
            {


                Console.WriteLine("Please Enter the package width.");
                string Input2 = Console.ReadLine();
                int PackageWidth = Convert.ToInt32(Input2);


                Console.WriteLine("Please Enter the package length.");
                string Input3 = Console.ReadLine();
                int PackageLength = Convert.ToInt32(Input3);

                Console.WriteLine("Please enter the height of the package.");
                string Input4 = Console.ReadLine();
                int PackageHeight = Convert.ToInt32(Input4);

                if (PackageWidth + PackageLength + PackageHeight >= 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {

                    double price = PackageLength * PackageHeight * PackageWidth;
                    int finalPrice = (int)price / 100;
                    Console.WriteLine("Your Your estimated total for shipping this package is: $" + finalPrice + ".00" +
                           " Thank you!");
                }
            }

        }
    }
}
