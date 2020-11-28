//1.Create an abstract class called Person with two properties: string firstName and string lastName.

//2. Give it the method SayName().

//3.Create another class called Employee and have it inherit from the Person class.

//4.Implement the SayName() method inside of the Employee class.

//5.Inside the Main() method, instantiate an Employee object with firstName "Sample" and lastName "Student".
//Call the SayName() method on the object.

using System;
using System.Collections.Generic;

namespace Drill_244
{
    class Program
    {
        static void Main(string[] args)
        {
            employee met = new employee();
            met.firstName = "Sample";
            met.lastName = "Student";

            met.sayName();
        }
    }
}
