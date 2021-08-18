using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input = Console.ReadLine();
            while(input!="End")
            {
                string[] splitter = input.Split();
                string name = splitter[0];
                string id = splitter[1];
                int age = int.Parse(splitter[2]);
                Student student = new Student(name, id, age);
                students.Add(student);
                input = Console.ReadLine();
            }

            foreach (var student in students.OrderBy(x=> x.Age))
            {
                Console.WriteLine($"{student.Name} with ID: {student.ID} is {student.Age} years old.");
            }
        }
    }


    public class Student
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public Student(string name , string id , int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
    }
}
