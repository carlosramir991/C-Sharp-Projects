using System;
namespace Drill_310
{
    public class id
    {

            const string fname = "Carlos";
            string lname { get; set; }


            public id(string fname, string lname)
            {

                Console.WriteLine("How old are you?");
                var age = Convert.ToInt32(Console.ReadLine());



                Console.WriteLine("Hello " +fname + " " + lname + " You are " +age+" years old.");

            }
            public id(string fname) : this(fname, "Rodriguez")
            {

            }
       
    }
}
