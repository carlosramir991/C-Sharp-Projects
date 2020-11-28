using System;
namespace Drill_236
{
    public class Person
    {
        public string firstName { set; get; }

        public string lastName { set; get; }

        public void SayName()
        {


            string fullName = firstName + " " + lastName;
            Console.WriteLine("Name: " + fullName);
            

        }
    }
}
    

