using System;
namespace Drill_244
{
    public abstract class person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public void sayName()
        {

            Console.WriteLine("Name: " + firstName + " " + lastName);
        }


    }
}
