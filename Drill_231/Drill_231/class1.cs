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
    public class class1
    {
        public void method1(int numb1)
        {
            int answer1 = numb1 / 2;
            Console.WriteLine(answer1);
        }

        public void method1(decimal numb1)
        {
            decimal answer2 = numb1 / 2;
            Console.WriteLine(answer2);

        }

        public void method2(out int numb3, out int numb4)
        {
            numb3 = 3;
            numb4 = 4;

            int answer3 = numb3 * numb4;
            Console.WriteLine(answer3);
            
        }
    }
}
