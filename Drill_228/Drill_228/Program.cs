//1.Create a class. In that class, create a void method that takes two integers as parameters.
//Have the method do a math operation on the first integer and display the second integer to the screen.

//2. In the Main() method of the console app, instantiate the class.

//3.Call the method in the class, passing in two numbers.

//4. Call the method in the class, specifying the parameters by name.



using System;


namespace Drill_228
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 met = new Class1();

            Console.WriteLine("Please enter your first number.");
            int numb1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your second number.");
            int numb2 = Convert.ToInt32(Console.ReadLine());

            met.void1(numb1, numb2);
        }
    }
}
