using System;
namespace Drill_314
{
    public class AgeError:Exception
    {
        public AgeError():base()
        {
            Console.WriteLine("You must enter a number greater than 0! "+"\n"+"now..");
        }

    }
}
