using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Drill_227
{
    class Program
    {
        static void Main(string[] args)
        {
            class1 met = new class1();

            Console.WriteLine("Please enter your first number.");
            int numb1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Please enter another number but know that it is not neccesary.");
            string numb2 = Console.ReadLine();

            if (numb2 == "")
            {
                Console.WriteLine(met.doubleP(numb1));
            }
            else
            {
                int numb3 = Convert.ToInt32(numb2);
                Console.WriteLine(met.doubleP(numb1, numb3));

            }


        }
    }
}
