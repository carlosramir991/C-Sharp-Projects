using System;
using System.Collections.Generic;

namespace Drill_214
{
    class Program
    {

        static void Main()
       {
            try
            {
                List<int> intList = new List<int>() { 12, 20, 25, 44, 78 };
                Console.WriteLine("Please enter a number that will be used to divide each number in our list.");
                int divider = Convert.ToInt32(Console.ReadLine());

                foreach (int number in intList)
                {

                    Console.Write(number / divider + "\n");
                }

            }

            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Try/Catch block completed.");
                Console.ReadLine();
            }









       }
        
    }
}
