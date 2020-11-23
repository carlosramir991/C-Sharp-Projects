using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Drill_223
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number!");
            int numb1;
            numb1 = Convert.ToInt32(Console.ReadLine());

            methods1 met = new methods1();
            Console.WriteLine(numb1 + " divided by 8 equals: "+met.division(numb1));
            Console.WriteLine(numb1 + " plus 300 is: " + met.addition(numb1));
            Console.WriteLine(numb1 + " multiplied by 5 is: "+met.multiplication(numb1));
        }

         

    
    } 




    

    
}
