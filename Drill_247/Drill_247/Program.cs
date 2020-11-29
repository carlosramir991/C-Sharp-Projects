//1.Create an interface called IQuittable and have it define a void method called Quit().

//2.Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose.

//3. Use polymorphism to create an object of type IQuittable and call the Quit() method on it.
//Hint: an object can be of an interface type if it implements that specific interface.


using System;
using System.Collections.Generic;

namespace Drill_247
{
    class Program : employee, IQuittable
    {
        static void Main(string[] args)
        {
            employee met = new employee();
            Console.WriteLine("Please enter your first name.");
            met.firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name.");
            met.lastName = Console.ReadLine();
            Console.WriteLine("Please enter your ID.");
            met.id = Convert.ToInt32(Console.ReadLine());

            void Quit()
            {
                Console.WriteLine("This employee has not yet been terminated.");
            }

            Quit();
            
            
           
        }
    }
}
