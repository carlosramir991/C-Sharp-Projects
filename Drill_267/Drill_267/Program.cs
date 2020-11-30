//1.Create a struct called Number and give it the property "Amount" and have it be of data type decimal.

//2. In the Main() method, create an object of data type Number and assign an amount to it.

//3. Print this amount to the console.


using System;
using System.Collections.Generic;

namespace Drill_267
{
    class Program
    {
        static void Main(string[] args)
        {
            Number n;
            n.amount = 12.59m;
            Console.WriteLine(n.amount);
            
        }
        public struct Number
        {
            public decimal amount;
        }
    }
}
