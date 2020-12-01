//1.In the Main() method, create a list of at least 10 employees.
//Each employee should have a first and last name, as well as an Id.
//At least two employees should have the first name "Joe".

//2. Using a foreach loop, create a new list of all employees with the first name "Joe".

//3. Perform the same action again, but this time with a lambda expression.

//4. Using a lambda expression, make a list of all employees with an Id number greater than 5.



using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace Drill_272
{
    class Program : employees<Type>
    {
        static void Main(string[] args)
        {
            employees<string> emp = new employees<string>();
            emp.firstName= new List<string>() { "Carlos", "Eric", "Joe", "Joe" };
            employees<string> emp2 = new employees<string>();
            emp2.lastName = new List<string>() { "Ramirez", "Jones", "Jonas", "Shmo" };
            employees<int> emp3 = new employees<int>();
            emp3.empId = new List<int> { 12, 1, 3, 8 };
            employees<string> emp4 = new employees<string>();
            emp4.joeEmpls = new List<string>();
            employees<string> emp5 = new employees<string>();
            emp5.joeEmpls = new List<string>();
            emp5.joeEmpls = emp.firstName.Where(x => x == "Joe").ToList();
            List<int> empId2 = new List<int>();
            empId2 = emp3.empId.Where(x => x > 5).ToList();
            

            foreach (string name in emp5.joeEmpls)
            {
                Console.WriteLine(name);
            }

            foreach (int number in empId2)
            {
                Console.WriteLine(number);
            }


            foreach (string name in emp.firstName)
            {
                if (name == "Joe")
                {
                    emp4.joeEmpls.Add(name);
                   
                }
                
            }


            




            
            



        }
    }
}
