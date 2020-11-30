//1.Make the Employee class take a generic type parameter.

//2. Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class.

//3.Instantiate an Employee object with type "string" as its generic parameter. Assign a list of strings as the property value of Things.

//4. Instantiate an Employee object with type "int" as its generic parameter. Assign a list of integers as the property value of Things.

//5. Create a loop that prints all of the Things to the Console.




using System.Collections.Generic;
using System;

namespace Drill_255
{
    class Program : employee<Type>
    {
        static void Main(string[] args)
        {
            employee<string> emp = new employee<string>();
            emp.things  = new List<string>() { "Mop", "Bucket", "Pine Sol", "Paper Towels" };
            employee<int> emp2 = new employee<int>();
            emp2.things = new List<int>() { 12, 1, 3, 4 };

            foreach (string thing in emp.things){
                Console.WriteLine(thing);
            }

            foreach (int thing in emp2.things){
                Console.WriteLine(thing);




            }

        
        }
    }
}
