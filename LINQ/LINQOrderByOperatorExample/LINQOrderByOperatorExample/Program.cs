using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQOrderByOperatorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> Objstudent = new List<Student>(){
            new Student() { RoleNumberId=1, Name = "Ak", Gender = "Male", Subjects = new List<string> { "Mathematics", "Physics" } },
                new Student() { RoleNumberId=2, Name = "Shalu", Gender = "Female", Subjects = new List<string> { "Computers", "Botany" } },
                new Student() { RoleNumberId=3, Name = "Shubham", Gender = "Male", Subjects = new List<string> { "Economics", "Operating System", "Java" } },
                new Student() { RoleNumberId=4, Name = "Shubham", Gender = "Male", Subjects = new List<string> { "Accounting", "Social Studies", "Chemistry" } },
                new Student() { RoleNumberId=5, Name = "Shivani", Gender = "FeMale", Subjects = new List<string> { "English", "Charterd" } }
            };

            var studentname = Objstudent.OrderBy(x => x.Name);

            Console.WriteLine("Name of the student in the ascending form");
            foreach (var student in studentname)  
            {
                Console.WriteLine(student.Name);
            }

            /*OrderByDescending() operator is used to print  
             the name of the student in the descending form*/

            studentname = Objstudent.OrderByDescending(x => x.Name);
            Console.WriteLine("\nName of the student in the descending form");
            //foreach loop is used to print the name of the student  
            foreach (var student in studentname)
            {
                Console.WriteLine(student.Name);
            }

            //ThenBy() operator is used here to sort the Information of the student in ascending form on the behalf of the RollNumber  
            studentname = Objstudent.OrderBy(x => x.Name).ThenBy(x => x.RoleNumberId);

            Console.WriteLine("\nName of the student in the ascending form on the behalf of the Name and RollNumber");
            //foreach loop is used to print the information  
            foreach (var student in studentname)
            {
                Console.WriteLine("Name = {0} studentid = {1}", student.Name, student.RoleNumberId);
            }

            //ThenByDescending() operator is used to sort the information of the student in the descending form  
            studentname = Objstudent.OrderBy(x => x.Name).ThenByDescending(x => x.RoleNumberId);

            Console.WriteLine("\nName of the student in the descending form on the behalf of the RollNumber");

            foreach (var student in studentname)
            {
                Console.WriteLine("Name={0} StudentId={1}", student.Name, student.RoleNumberId);
            }

            Console.ReadLine();
        }
    }
    class Student
    {
        public int RoleNumberId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public List<string> Subjects { get; set; }
    }
}
