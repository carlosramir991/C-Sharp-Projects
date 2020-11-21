using System;
using System.Collections.Generic;

namespace Drill_198
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = { "I bet you ordered a pumpkin spice latte this morning.", "You must like white claws. smh.", "You're pretty basic." }; 
            Console.WriteLine("Please select an index from my Array!");
            int input1 = Convert.ToInt32(Console.ReadLine());
            if (input1 > 2 || input1 < 0)
            {
                Console.WriteLine("Please enter a number between 0 and 2 for the Array index number.");
                input1 = Convert.ToInt32(Console.ReadLine());
            } 
            Console.WriteLine(stringArray[input1]);
            

            int[] intArray = { 30, 50, 60, 80 };
            Console.WriteLine("Please select an index from my Array!");
            int input2 = Convert.ToInt32(Console.ReadLine());
            if (input2 < 0 || input2 > 3)
            {
                Console.WriteLine("Please enter a number between 0 and 3 for the Array index number.");
                input2 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(intArray[input2]);

            List<string> stringList = new List<string>();
            stringList.Add("Jeffrey Epstein did not kill himself.");
            stringList.Add("Wearing a mask is a violation of my rights lolol");
            stringList.Add("Greg is not that basic.");
            Console.WriteLine("Please select an index from my List!");
            int input3 = Convert.ToInt32(Console.ReadLine());
            if (input3 > 2 || input3 < 0)
            {
                Console.WriteLine("Please enter a number between 0 and 2 for the list index number.");
                input3 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(stringList[input3]);
            Console.ReadLine();

        }
    }
}
