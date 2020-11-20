using System;
using System.Text;

namespace Drill_193
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name.");
            string user1 = Console.ReadLine();
            user1 = user1.ToUpper();
            string greeting = "Hello there " + user1 + "! ";
            string explanation = "Today you will be learning about the big rona. ";
            string explanation2 = "Lets begin.";

            Console.WriteLine(greeting + explanation + explanation2);

            StringBuilder sb = new StringBuilder("If you have a runny nose",50);

            sb.Append(", go get tested at your nearest testing center.");

            sb.Append(" And stay away from friends and family.");

            Console.WriteLine(sb);
        }
    }
}
