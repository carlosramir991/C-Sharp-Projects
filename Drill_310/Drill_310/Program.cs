//1.Create a const variable.

//2. Create a variable using the keyword "var.”

//3.Chain two constructors together.

using System;
using System.Collections.Generic;
using System.IO;

namespace Drill_310
{
    class Program 
    {
        static void Main(string[] args)
        {
            string fname = "Carlos";
            Console.WriteLine("What is your last name?");
            string lname = Console.ReadLine();

            // One can also simply type
            // id starter = new id(fname, lname)
            // this will include the last name that one types above
            id starter = new id(fname);
            
         

        }





    }
}
