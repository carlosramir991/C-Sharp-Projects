using System;
namespace Drill_247
{
    public class employee : IQuittable
    {

        public string firstName { get; set; }
        public string lastName { get; set; }
        public int id { get; set; }

        public void Quit()
        {
            Console.WriteLine("This employee is not working here anymore.");
        }
        
       
    
    }
}
