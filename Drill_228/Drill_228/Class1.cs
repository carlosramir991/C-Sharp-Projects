//1.Create a class. In that class, create a void method that takes two integers as parameters.
//Have the method do a math operation on the first integer and display the second integer to the screen.

//2. In the Main() method of the console app, instantiate the class.

//3.Call the method in the class, passing in two numbers.

//4. Call the method in the class, specifying the parameters by name.

using System;
namespace Drill_228
{
    public class Class1
    {
        public void void1(int numb1, int numb2)
        {
            int answer1 = numb1 * 10;
            int answer2 = numb2;
            Console.WriteLine(answer1 + answer2);
            return;

        }
    }
}
