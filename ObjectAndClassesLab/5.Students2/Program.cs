
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

            while (command != "end")
            {
                List<string> studentInfo = command.
                    Split(" ", StringSplitOptions.RemoveEmptyEntries).
                    ToList();
                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                int studentAge = int.Parse(studentInfo[2]);
                string hometown = studentInfo[3];
                
                if (IsStudentExisting(students, firstName, lastName))
                {
                    Student student = GetStudent(students, firstName, lastName);
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = studentAge;
                    student.Hometown = hometown;
                    
                }
                else
                {
                    Student student = new Student();
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = studentAge;
                    student.Hometown = hometown;
                    students.Add(student);
                }
                



                command = Console.ReadLine();
            }

            string city = Console.ReadLine();

            foreach (Student student in students)
            {
                if (city == student.Hometown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }

        }


        private static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
        static Student GetStudent(List<Student> students, string firstName , string lastName)
        {
            Student existingStudent = null;
            foreach (Student student in students)
            {
                if(student.FirstName==firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
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


