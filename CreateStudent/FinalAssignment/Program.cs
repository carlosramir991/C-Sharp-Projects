using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FinalAssignment
{
    class Program : student 
    {
        static void Main(string[] args)
        {
            using (var db = new context())
            {

                student st = new student();

                Console.WriteLine("Please enter your first name.");
                st.fname = Console.ReadLine();
                Console.WriteLine("Please enter your last name.");
                st.lname = Console.ReadLine();
                st.studentId = 2319;

                var student = new student { fname = st.fname, lname = st.lname , studentId = st.studentId };
                db.students.Add(student);
                db.SaveChanges();
                var query = from s in db.students
                            orderby s.fname
                            select s;

                Console.WriteLine("Student has been entered into the database.");
                foreach ( var item in query)
                {
                    Console.WriteLine(item.fname);
                }

                Console.WriteLine($"Welcome {st.fname} {st.lname}! Today you will be beginning your classes at MIT! Your student ID will be {st.studentId}.");
            }

        }
    }

    public class student
    {

        public string fname { get; set; }
        public string lname { get; set; }

        public int studentId { get; set; }

    }

    public class context : DbContext
    {
        public DbSet<student> students { get; set; }
    }
        



}
