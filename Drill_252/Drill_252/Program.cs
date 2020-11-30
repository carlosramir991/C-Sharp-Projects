
using System;
using System.Collections.Generic;

namespace Drill_247
{
    class Program : employee
    {
        static void Main(string[] args)
        {
            employee met = new employee();
            met.employee1 = "Carlos";
            met.employee2 = "Carlos2";
            met.id1 = 123;
            met.id2 = 124;

            Console.WriteLine(met.id1 == met.id2);
        }
    }
}

