//1.Create a class. In that class, create a void method that outputs an integer. Have the method divide the data passed to it by 2.

//2. In the Main() method, instantiate that class.

//3.Have the user enter a number. Call the method on that number. Display the output to the screen. It should be the entered number, divided by two.

//4. Create a method with output parameters.

//5. Overload a method.

//6. Declare a class to be static.


using System;
using System.Collections.Generic;

namespace Drill_231
{
    class Program
    {
        static void Main(string[] args)
        {
            class1 met = new class1();
            
            decimal numb1 = 10.23m;

            met.method1(numb1);
            
            Console.WriteLine("Please enter a number that we will divide by 2.");
            numb1 = Convert.ToInt32(Console.ReadLine());

            met.method1(numb1);

            Console.WriteLine("Please enter your first number.");
            int numb3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your second number.");
            int numb4 = Convert.ToInt32(Console.ReadLine());

            met.method2(out numb3, out numb4);

            staticClass.stat1();







            
        }
    }
}
