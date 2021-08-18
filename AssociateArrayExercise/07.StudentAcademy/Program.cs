using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<double>>();
            var passedStudents = new Dictionary<string, double >();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if(!students.ContainsKey(name))
                {
                    students.Add(name, new List<double> { grade });
                }
                else
                {
                    students[name].Add(grade);
                }
            }
            foreach (var student in students
                                        .Where(student=> student.Value.Sum()/student.Value.Count>=4.5))
                                        
            {
                double grade = student.Value.Sum() / student.Value.Count;
                passedStudents.Add(student.Key, grade);
            }
            foreach (var passedStudent in passedStudents.OrderByDescending(x=> x.Value))
            {
                Console.WriteLine($"{passedStudent.Key} -> {passedStudent.Value:F2}");
            }
        }
    }
}
