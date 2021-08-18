using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Student> students = new List<Student>();

            while(command!="end")
            {
                List<string> studentInfo = command.
                    Split(" ", StringSplitOptions.RemoveEmptyEntries).
                    ToList();
                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                int studentAge = int.Parse(studentInfo[2]);
                string hometown = studentInfo[3];
                
                Student student = new Student();
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = studentAge;
                student.Hometown = hometown;
                students.Add(student);
               

                command = Console.ReadLine();
            }
         
            string city = Console.ReadLine();

            foreach (Student student in students)
            {
                if(city==student.Hometown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }

        }
    }


    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }
    }
}
